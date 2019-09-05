using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHoTen.Text) && !String.IsNullOrEmpty(txtDiaChi.Text)
                && !String.IsNullOrEmpty(txtSoThangTruoc.Text) && !String.IsNullOrEmpty(txtSoThangNay.Text)
                && txtMaKH.TextLength == 6 && int.Parse(txtSoThangNay.Text) > int.Parse(txtSoThangTruoc.Text))
            {
                List<KhachHang> listKhachHang = new List<KhachHang>();
                KhachHang khachHang = new KhachHang(
                    txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, dtChotSo.Text,
                    int.Parse(txtSoThangTruoc.Text), int.Parse(txtSoThangNay.Text));
                listKhachHang.Add(khachHang);
                listBox1.Items.Add(khachHang.ToString());
                StaticData.khachHangs = listKhachHang;
            }
            else
            {
                MessageBox.Show("Nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void TxtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSoThangTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtSoThangNay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }
        /// <summary>
        /// Alt+H
        /// Alt+M
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.H))
            {
                Exit();
            }
            if (keyData == (Keys.Alt | Keys.M))
            {
                AddNew();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        /// <summary>
        /// Thoát
        /// </summary>
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Thêm mới
        /// </summary>
        private void AddNew()
        {
            txtHoTen.Text = null;
            txtMaKH.Text = null;
            txtDiaChi.Text = null;
            txtSoThangNay.Text = null;
            txtSoThangTruoc.Text = null;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }
    }
}
