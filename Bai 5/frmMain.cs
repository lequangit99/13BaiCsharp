using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class frmMain : Form
    {
        List<int> listNumber = new List<int>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            NewForm();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NewForm();
        }
        private void NewForm()
        {
            lbMaxMin.Visible = false;
            lbSum.Visible = false;
            btnMax.Enabled = false;
            btnMin.Enabled = false;
            btnRList.Enabled = false;
            btnSum.Enabled = false;
            listBox1.Items.Clear();
            listNumber.Clear();
        }

        private void EnabledBtn()
        {
            btnMax.Enabled = true;
            btnMin.Enabled = true;
            btnRList.Enabled = true;
            btnSum.Enabled = true;
        }
        private void DisabledBtn()
        {
            btnMax.Enabled = false;
            btnMin.Enabled = false;
            btnRList.Enabled = false;
            btnSum.Enabled = false;
        }
        private void BtnAddList_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void AddList()
        {
            if (!String.IsNullOrEmpty(txtNumber.Text) && int.TryParse(txtNumber.Text, out int temp))
            {
                listNumber.Add(temp);
                listBox1.Items.Add(temp);
                EnabledBtn();
                txtNumber.Text = null;
                txtNumber.Focus();
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }

        private void BtnRList_Click(object sender, EventArgs e)
        {
            RList();
        }

        private void RList()
        {
            if (listBox1.SelectedIndex != -1)
            {
                listNumber.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                if (listBox1.Items.Count == 0)
                {
                    DisabledBtn();
                }
            }
            else
            {
                MessageBox.Show("Chọn mục cần xoá");
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            Sum();
        }

        private void Sum()
        {
            int sum = 0;
            foreach (var item in listNumber)
            {
                sum += item;
            }
            lbSum.Visible = true;
            lbSum.Text = "Tổng : " + sum.ToString();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            Max();
        }

        private void Max()
        {
            lbMaxMin.Visible = true;
            int max = listNumber[0];
            foreach (var item in listNumber)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            lbMaxMin.Text = "Max : " + max;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            Min();
        }

        private void Min()
        {
            lbMaxMin.Visible = true;
            int max = listNumber[0];
            foreach (var item in listNumber)
            {
                if (item < max)
                {
                    max = item;
                }
            }
            lbMaxMin.Text = "Min : " + max;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
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
                    NewForm();
                }
                if (keyData == (Keys.Alt | Keys.D))
                {
                    AddList();
                }
                if (keyData == (Keys.Alt | Keys.X))
                {
                    RList();
                }
                if (keyData == (Keys.Alt | Keys.N))
                {
                    Sum();
                }
                if (keyData == (Keys.Alt | Keys.A))
                {
                    Max();
                }
                if (keyData == (Keys.Alt | Keys.S))
                {
                    Min();
                }
            }
            catch
            {
                MessageBox.Show("Chưa được phép sử dụng");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
