using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class frmMain : Form
    {
        string thoiGianThue = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        /// <summary>
        /// Exit
        /// </summary>
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Add New
        /// </summary>
        private void AddNew()
        {
            radioNuaNgay.Checked = false;
            radioCaNgay.Checked = false;
            txtPriceShip.Text = null;
            txtName.Text = null;
            cbDoUong.SelectedIndex = -1;
            cbSoLuong.SelectedIndex = -1;
            txtPriceDrink.Text = null;
            txtName.Focus();
        }
        /// <summary>
        /// Add List
        /// </summary>
        private void AddList()
        {
            if (!String.IsNullOrEmpty(txtName.Text) && (radioCaNgay.Checked == true || radioNuaNgay.Checked == true) &&
                cbDoUong.SelectedIndex != -1 && cbSoLuong.SelectedIndex != -1)
            {
                List<KhachHang> khachHangs = new List<KhachHang>();
                KhachHang khachHang = new KhachHang(txtName.Text, thoiGianThue, int.Parse(txtPriceShip.Text),
                    cbDoUong.Text, int.Parse(cbSoLuong.Text), double.Parse(txtPriceDrink.Text));
                khachHangs.Add(khachHang);
                listBox1.Items.Add(khachHang.ToString());
                StaticData.khachHangs = khachHangs;

            }
            else
            {
                MessageBox.Show("Nhập lại");
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.M))
            {
                AddNew();
            }
            if (keyData == (Keys.Alt | Keys.H))
            {
                Exit();
            }
            if (keyData == (Keys.Alt | Keys.T))
            {
                AddList();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CbDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPriceDrink.Text = null;
            tinhTien();
        }

        private void CbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPriceDrink.Text = null;
            tinhTien();
        }
        private void tinhTien()
        {
            if (cbDoUong.SelectedIndex != -1 && cbSoLuong.SelectedIndex != -1)
            {
                if (cbDoUong.SelectedIndex == 0)
                {
                    txtPriceDrink.Text = (0.5 * double.Parse(cbSoLuong.Text)).ToString();
                }
                else if (cbDoUong.SelectedIndex == 1)
                {
                    txtPriceDrink.Text = (0.8 * double.Parse(cbSoLuong.Text)).ToString();
                }
                else if (cbDoUong.SelectedIndex == 2)
                {
                    txtPriceDrink.Text = (1 * double.Parse(cbSoLuong.Text)).ToString();
                }
            }
        }

        private void RadioCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtPriceShip.Text = "200";
            thoiGianThue = "Cả Ngày";
        }

        private void RadioNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtPriceShip.Text = "100";
            thoiGianThue = "Nửa Ngày";
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            AddList();
        }
    }
}
