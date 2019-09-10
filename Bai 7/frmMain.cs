using System;
using System.Linq;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            newForm();

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
        private void newForm()
        {
            txtNhapSo.Text = null;
            lbDaySo.Visible = false;
            lbKetQua.Visible = false;
            cbChucNang.SelectedIndex = -1;
            StaticData.listNumber.Clear();
        }

        private void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            newForm();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapSo.Text, out int temp))
            {
                frmAddcs frmAddcs = new frmAddcs(temp);
                frmAddcs.ShowDialog();
                frmAddcs.Close();
                lbDaySo.Visible = true;
                lbDaySo.Text = "Dãy số vừa nhập là " + listNumber();
            }
            else
            {
                MessageBox.Show("Nhập vào số phần tử");
            }
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

        private void CbChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKetQua.Visible = true;
            if (cbChucNang.SelectedIndex == 0)
            {
                lbKetQua.Text = "Trung bình cộng của dãy là " + (Convert.ToDouble(StaticData.listNumber.Sum()) / StaticData.listNumber.Count);
            }
            if (cbChucNang.SelectedIndex == 1)
            {
                int temp = 0;
                foreach (var item in StaticData.listNumber)
                {
                    if (item < 0)
                    {
                        temp++;
                    }
                }
                lbKetQua.Text = "Có " + temp + " phần tử âm";
            }
        }
    }
}
