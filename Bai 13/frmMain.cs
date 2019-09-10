using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_13
{
    public partial class frmMain : Form
    {
        List<int> viTri = new List<int>();
        public frmMain()
        {
            InitializeComponent();
            lamLai();
        }

        private void lamLai()
        {
            lbSoDuongMin.Visible = false;
            lbDaySo.Visible = false;
            btnSearch.Enabled = false;
            btnDuongMin.Enabled = false;
            txtAdd.Text = null;
            txtCheck.Text = null;
            StaticData.listNumber.Clear();
            viTri.Clear();
        }

        private void BtnNhapDay_Click(object sender, EventArgs e)
        {
            addList();
        }

        private void addList()
        {
            if (!String.IsNullOrEmpty(txtAdd.Text) && int.TryParse(txtAdd.Text, out int temp))
            {
                frmNhap frmNhap = new frmNhap(temp);
                frmNhap.ShowDialog();
                frmNhap.Close();
                lbDaySo.Text = "Dãy số vừa nhập là: " + listNumber();
                lbDaySo.Visible = true;
                btnSearch.Enabled = true;
                btnDuongMin.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
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
            lamLai();
        }
        private string listNumber()
        {
            string s = null;
            foreach (var item in StaticData.listNumber)
            {
                s += " " + item;
            }
            return s;
        }

        private void BtnDuongMin_Click(object sender, EventArgs e)
        {
            int MIN = int.MaxValue;
            foreach (var item in StaticData.listNumber)
            {
                if (item % 2 == 0 && item < MIN)
                {
                    MIN = item;
                }
            }
            lbSoDuongMin.Visible = true;
            lbSoDuongMin.Text = "Số dương nhỏ nhất là: " + MIN;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int dem = 0;
            if (!String.IsNullOrEmpty(txtCheck.Text) && int.TryParse(txtCheck.Text, out int temp))
            {
                for (int i = 0; i < StaticData.listNumber.Count; i++)
                {
                    if (StaticData.listNumber[i] == temp)
                    {
                        dem++;
                        viTri.Add(i + 1);
                    }
                }
                if (dem == 0)
                {
                    MessageBox.Show("Không phần tử có giá bằng " + txtCheck.Text + " trong dãy ");
                }
                else
                {
                    string s = null;
                    foreach (var item in viTri)
                    {
                        s += item + " ";
                    }
                    MessageBox.Show("Số phần tử có giá bằng " + txtCheck.Text + " là " + dem + " nằm ở vị trí " + s);
                    viTri.Clear();
                }
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }
    }
}
