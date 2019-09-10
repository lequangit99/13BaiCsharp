using System;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class frmAddcs : Form
    {
        int length = 0;
        int i = 1;
        public frmAddcs(int n)
        {
            Length = n;
            InitializeComponent();
        }

        public int Length { get => length; set => length = value; }

        private void addList()
        {
            StaticData.listNumber.Add(int.Parse(txtPhanTu.Text));
            if (StaticData.listNumber.Count == length)
            {
                this.Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPhanTu.Text) && int.TryParse(txtPhanTu.Text, out int temp))
            {
                addList();
                txtPhanTu.Text = null;
                lbSoPhanTu.Text = "Nhập vào phần tử thứ " + (i + 1);
                i++;
            }
            else
            {
                MessageBox.Show("Nhập vào số");
            }
        }
    }
}
