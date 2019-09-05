using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_1
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
                if (String.Compare(item.HoTen, txtSearch.Text) == 0)
                {
                    MessageBox.Show("Họ tên: " + item.HoTen + " Số tiền phải trả là " + item.tienDien());
                    timThay = true;
                }
                if (timThay == false)
                {
                    MessageBox.Show("Không tim thấy khách hàng " + txtSearch.Text);
                }
            }
        }
    }
}
