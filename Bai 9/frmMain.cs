using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_9
{
    public partial class frmMain : Form
    {
        List<Book> books = new List<Book>();
        public frmMain()
        {
            InitializeComponent();
        }
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.H))
            {
                Exit();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void RbMorney_CheckedChanged(object sender, EventArgs e)
        {
            txtSale.Text = "5";
        }

        private void RbATM_CheckedChanged(object sender, EventArgs e)
        {
            txtSale.Text = "10";
        }

        private void CbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBook.SelectedIndex == 0)
            {
                txtPrice.Text = "22000";
            }
            if (cbBook.SelectedIndex == 1)
            {
                txtPrice.Text = "27000";
            }
            if (cbBook.SelectedIndex == 2)
            {
                txtPrice.Text = "25000";
            }
            if (cbBook.SelectedIndex == 3)
            {
                txtPrice.Text = "26000";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addBook();
        }

        private void addBook()
        {
            if (cbBook.SelectedIndex != -1 && !String.IsNullOrEmpty(txtSL.Text) && (rbATM.Checked == true || rbMorney.Checked == true))
            {
                Book book = new Book(cbBook.SelectedItem.ToString(), int.Parse(txtPrice.Text), int.Parse(txtSL.Text),
                    int.Parse(txtSale.Text));
                books.Add(book);
                listBox1.Items.Add(book.ToString());
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RBook();
        }

        private void RBook()
        {
            if (listBox1.SelectedIndex!=-1)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            == DialogResult.Yes)
                {
                    books.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Chọn sách muốn xoá");
            }
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            Sum();
        }

        private void Sum()
        {
            int tongGia = 0;
            foreach (var item in books)
            {
                tongGia += item.Sum();
            }
            txtSum.Text = tongGia.ToString();
        }
    }
}
