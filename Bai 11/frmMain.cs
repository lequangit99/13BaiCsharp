using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_11
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            macDinh();
        }
        private void macDinh()
        {
            txtTEXT.Text = "Bài tập C#";
            cbKichThuoc.SelectedIndex = 0;
            cbFont.SelectedIndex = 0;
            cbDam.Checked = false;
            cbNghieng.Checked = false;
            cbGachChan.Checked = false;
            rbRed.Checked = false;
            rbGreen.Checked = false;
            rbBlack.Checked = false;

        }
        private void hieuUng()
        {
            if (cbDam.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Bold);
                if (cbNghieng.Checked == true)
                {
                    txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Bold | FontStyle.Italic);
                    if (cbGachChan.Checked == true)
                    {
                        txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                    }
                }
                else if (cbGachChan.Checked == true)
                {
                    txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Bold | FontStyle.Underline);
                }
            }
            else if (cbNghieng.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Italic);
                if (cbGachChan.Checked == true)
                {
                    txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Italic | FontStyle.Underline);
                }
            }
            else if (cbGachChan.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Underline);
            }
            else
            {
                txtTEXT.Font = new Font(txtTEXT.Text, txtTEXT.Font.Size, FontStyle.Regular);
            }
        }
        private void mauChu()
        {
            if (rbRed.Checked == true)
            {
                txtTEXT.ForeColor = Color.Red;
            }
            if (rbGreen.Checked == true)
            {
                txtTEXT.ForeColor = Color.Green;
            }
            if (rbBlack.Checked == true)
            {
                txtTEXT.ForeColor = Color.Black;
            }
        }
        private void CbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTEXT.Font = new Font(Convert.ToString(cbFont.Text), int.Parse(cbKichThuoc.Text));
        }

        private void CbKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTEXT.Font = new Font(Convert.ToString(cbFont.Text), int.Parse(cbKichThuoc.Text));
        }

        private void CbDam_CheckedChanged(object sender, EventArgs e)
        {
            hieuUng();
        }

        private void CbNghieng_CheckedChanged(object sender, EventArgs e)
        {
            hieuUng();
        }

        private void CbGachChan_CheckedChanged(object sender, EventArgs e)
        {
            hieuUng();
        }

        private void RbRed_CheckedChanged(object sender, EventArgs e)
        {
            mauChu();
        }

        private void RbGreen_CheckedChanged(object sender, EventArgs e)
        {
            mauChu();
        }

        private void RbBlack_CheckedChanged(object sender, EventArgs e)
        {
            mauChu();
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            macDinh();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}