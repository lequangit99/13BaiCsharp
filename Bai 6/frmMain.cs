using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class frmMain : Form
    {
        List<int> listNumber = new List<int>();

        public frmMain()
        {
            InitializeComponent();
            Start();
            randomNumber();
        }

        private void randomNumber()
        {
            Random random = new Random();
            listNumber.Add(random.Next(0, 999999999));
            listNumber.Add(random.Next(0, 999999999));
            listNumber.Add(random.Next(0, 999999999));
            foreach (var item in listNumber)
            {
                listBox1.Items.Add(item);
            }
        }
        private void addList()
        {
            if (!String.IsNullOrEmpty(txtAdd.Text) && int.TryParse(txtAdd.Text, out int temp))
            {
                listNumber.Add(temp);
                listBox1.Items.Add(temp);
                txtAdd.Text = null;
                txtAdd.Focus();
            }
            else
            {
                MessageBox.Show("Bạn phải nhập vào số");
            }
        }
        private void removeList()
        {
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listNumber.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        private void Start()
        {
            lbGiaTriLonNhat.Visible = false;
            btnRemove.Enabled = false;
            txtAdd.Text = null;
        }
        private void EnabledControl()
        {
            lbGiaTriLonNhat.Visible = true;
            btnRemove.Enabled = true;
        }
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            listNumber.Clear();
            listBox1.Items.Clear();
            Start();
            randomNumber();
        }

        private void TxtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addList();
        }

        private void ListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            removeList();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            giaTriLonNhat();
        }

        private void giaTriLonNhat()
        {
            lbGiaTriLonNhat.Visible = true;
            int MAX = listNumber.Max();
            lbGiaTriLonNhat.Text = "Giá trị lớn nhất của dãy là: " + MAX;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                if (keyData == (Keys.Alt | Keys.H))
                {
                    Exit();
                }
                if (keyData == (Keys.Alt | Keys.L))
                {
                    Refresh();
                }
                if (keyData == (Keys.Alt | Keys.T))
                {
                    addList();
                }
                if (keyData == (Keys.Alt | Keys.X))
                {
                    removeList();
                }
            }
            catch
            {
                MessageBox.Show("Chưa được phép sử dụng");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
