using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool loai = false;
        private void TxtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtDeposits_KeyPress(object sender, KeyPressEventArgs e)
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
        /// AddList
        /// </summary>
        private void AddList()
        {
            if (!String.IsNullOrEmpty(txtCode.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                !String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDeposits.Text) &&
                !String.IsNullOrEmpty(cbMonth.Text) && !String.IsNullOrEmpty(dtDateTime.Text) &&
                txtCode.TextLength ==6)
            {
                List<KhachHang> listKhachHangs = new List<KhachHang>();
                KhachHang khachHang = new KhachHang(txtCode.Text, txtName.Text, txtAddress.Text, int.Parse(txtDeposits.Text),
                    dtDateTime.Text, int.Parse(cbMonth.Text), loai);
                listKhachHangs.Add(khachHang);
                listBox1.Items.Add(khachHang.ToString());
                StaticData.khachHangs = listKhachHangs;
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
        }
        /// <summary>
        /// Exit
        /// </summary>
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
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
            txtAddress.Text = null;
            txtCode.Text = null;
            txtDeposits.Text = null;
            txtName.Text = null;
            cbMonth.SelectedIndex = -1;
            rdbNormal.Checked = false;
            rdbPhatLoc.Checked = false;
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
            if (keyData==(Keys.Alt|Keys.T))
            {
                AddList();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void RdbNormal_CheckedChanged(object sender, EventArgs e)
        {
            loai = false;
        }

        private void RdbPhatLoc_CheckedChanged(object sender, EventArgs e)
        {
            loai = true;
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }
    }
}
