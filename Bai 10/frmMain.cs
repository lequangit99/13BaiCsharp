using System;
using System.Windows.Forms;

namespace Bai_10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            lamLai();
            ptB1();
        }
        private void ptB1()
        {
            txtC.Enabled = false;
        }

        private void RbB1_CheckedChanged(object sender, EventArgs e)
        {
            lamLai();
            ptB1();
        }

        private void ptB2()
        {
            txtC.Enabled = true;
        }

        private void RbB2_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
            ptB2();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            lamLai();
        }

        private void lamLai()
        {
            txtA.Text = null;
            txtB.Text = null;
            txtC.Text = null;
            txtKetQua.Text = null;
        }
        private void giaiPTB1()
        {
            if (!String.IsNullOrEmpty(txtA.Text) && !String.IsNullOrEmpty(txtB.Text)
                && double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b))
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        txtKetQua.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        txtKetQua.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    txtKetQua.Text = "Nghiệm của phương trình là: " + Math.Round(Convert.ToDouble(-b / a), 2);
                }
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }
        private void giaiPTB2()
        {
            if (!String.IsNullOrEmpty(txtA.Text) && !String.IsNullOrEmpty(txtA.Text)
                && !String.IsNullOrEmpty(txtB.Text)
                && double.TryParse(txtA.Text, out double a) && double.TryParse(txtB.Text, out double b)
                && double.TryParse(txtC.Text, out double c))
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    txtKetQua.Text = "Phương trình vô nghiệm";
                }
                if (delta == 0)
                {
                    txtKetQua.Text = "Phương trình có nghiệm kép x1=x2=" + (-(b / 2 * a));
                }
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    txtKetQua.Text = "Phương trình có 2 nghiệm phân biệt " + "X1=" + Math.Round(x1, 2) + " X2=" + Math.Round(x2, 2);
                }
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }
        private void BtnGiai_Click(object sender, EventArgs e)
        {
            giaiPhuongTrinh();
        }

        private void giaiPhuongTrinh()
        {
            if (rbB1.Checked == true)
            {
                giaiPTB1();
            }
            if (rbB2.Checked == true)
            {
                giaiPTB2();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.T))
            {
                Exit();
            }
            if (keyData == (Keys.Alt | Keys.L))
            {
                lamLai();
            }
            if (keyData == (Keys.Alt | Keys.G))
            {
                giaiPhuongTrinh();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
