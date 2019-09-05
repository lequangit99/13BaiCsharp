using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class frmSearch : Form
    {
        List<KhachHang> khachHangs = new List<KhachHang>();
        public frmSearch()
        {
            InitializeComponent();
            khachHangs = StaticData.khachHangs;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            bool timThay = false;
            foreach (var item in khachHangs)
            {
                if (String.Compare(item.Code, txtCode.Text) == 0)
                {
                    MessageBox.Show("Mã KH: " + item.Code + " số tiền phải trả là: " + (item.tienLai()));
                    timThay = true;
                }
                if (timThay == false)
                {
                    MessageBox.Show("Khách hàng có mã: " + txtCode.Text + " chưa có trong danh sách!");
                }
            }
        }

        private void TxtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
