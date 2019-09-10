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
            cbKichThuoc.SelectedIndex = 0;
            cbFont.SelectedIndex = 0;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtTEXT.Text = "BÀI THI MÔN TIN HỌC ĐẠI CƯƠNG";
        }

        private void CbKichThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTEXT.Font = new Font(Convert.ToString(cbFont.Text), int.Parse(cbKichThuoc.Text));
            Default();
            thayDoi();
            thayDoiMau();
        }

        private void CbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTEXT.Font = new Font(Convert.ToString(cbFont.Text), int.Parse(cbKichThuoc.Text));
            Default();
            thayDoi();
            thayDoiMau();
        }
        private void Default()
        {
            txtTEXT.Font = new Font(Convert.ToString(cbFont.Text), int.Parse(cbKichThuoc.Text), FontStyle.Regular);
        }
        private void thayDoi()
        {
            if (cbDam.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font, FontStyle.Bold);
            }
            if (cbDam.Checked == true && cbNghieng.Checked == true)
            {   
                txtTEXT.Font = new Font(txtTEXT.Font,FontStyle.Bold|FontStyle.Italic);
            }
            if (cbDam.Checked == true && cbGachChan.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font, FontStyle.Bold | FontStyle.Underline);
            }
            if (cbDam.Checked == true && cbNghieng.Checked == true && cbGachChan.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font,FontStyle.Bold | FontStyle.Italic| FontStyle.Underline);
            }
            if (cbNghieng.Checked==true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font,FontStyle.Italic);
            }
            if (cbNghieng.Checked== true&&cbGachChan.Checked == true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font, FontStyle.Italic | FontStyle.Underline);
            }
            if (cbGachChan.Checked==true)
            {
                txtTEXT.Font = new Font(txtTEXT.Font,FontStyle.Underline);
            }
        }
        private void thayDoiMau()
        {
            if (rbBlack.Checked==true)
            {
                Default();
                thayDoi();
                txtTEXT.ForeColor = Color.Black;
            }
            if (rbRed.Checked == true)
            {
                Default();
                thayDoi();
                txtTEXT.ForeColor = Color.Red;
            }
            if (rbGreen.Checked == true)
            {
                Default();
                thayDoi();
                txtTEXT.ForeColor = Color.Green;
            }
        }
        private void CbDam_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
        }

        private void CbNghieng_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
            thayDoiMau();
        }

        private void CbGachChan_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
            thayDoiMau();
        }

        private void RbRed_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
            thayDoiMau();

        }

        private void RbBlack_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
            thayDoiMau();
        }

        private void BtnLamLai_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void RbGreen_CheckedChanged(object sender, EventArgs e)
        {
            thayDoi();
            thayDoiMau();
        }
    }
}
