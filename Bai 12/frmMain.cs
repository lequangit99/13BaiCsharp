using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_12
{
    public partial class frmMain : Form
    {
        List<int> listNumber = new List<int>();
        public frmMain()
        {
            InitializeComponent();
            lamMoi();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void lamMoi()
        {
            txtAdd.Text = null;
            listBox1.Items.Clear();
            lbKQ.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addList();
        }

        private void addList()
        {
            if (!String.IsNullOrEmpty(txtAdd.Text) && int.TryParse(txtAdd.Text, out int temp))
            {
                listNumber.Add(temp);
                listBox1.Items.Add(temp);
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            removeList();
        }

        private void removeList()
        {
            if (listBox1.Items.Count != 0)
            {
                if (listBox1.SelectedIndex != -1)
                {
                    listNumber.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Chọn số cần xoá");
                }
            }
            else
            {
                MessageBox.Show("Chưa có số nào trong dãy");
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (soNguyenTo(listNumber[listBox1.SelectedIndex]))
                {
                    lbKQ.Visible = true;
                    lbKQ.Text = listNumber[listBox1.SelectedIndex] + " là số nguyên tố";
                }
                else
                {
                    lbKQ.Visible = true;
                    lbKQ.Text = listNumber[listBox1.SelectedIndex] + " không là số nguyên tố";
                }
            }
            else
            {
                MessageBox.Show("Chọn số cần kiểm tra");
            }
        }
        private bool soNguyenTo(int n)
        {
            try
            {
                if (n <= 1)
                {
                    return false;
                }
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}