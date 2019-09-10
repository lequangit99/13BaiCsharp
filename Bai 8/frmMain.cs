using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class frmMain : Form
    {
        List<int> listNumber = new List<int>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addList()
        {
            if (int.TryParse(txtAdd.Text,out int temp))
            {
                listNumber.Add(temp);
                listBox1.Items.Add(temp);
                txtAdd.Text = null;
                txtAdd.Focus();
            }
            else
            {
                MessageBox.Show("Nhập vào số nguyên");
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addList();
        }

        private void RList()
        {
                if (listBox1.SelectedIndex!=-1)
                {
                    if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
                    {
                        listNumber.RemoveAt(listBox1.SelectedIndex);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn phần tử để xoá");
                }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RList();
        }

        private void plus3()
        {
            for (int i = 0; i < listNumber.Count; i++)
            {
                listNumber[i] += 3;
            }
            listBox1.Items.Clear();
            foreach (var item in listNumber)
            {
                listBox1.Items.Add(item);
            }
        }
        private void BtnPlus3_Click(object sender, EventArgs e)
        {
            plus3();
        }

        private void BtnSoChanDau_Click(object sender, EventArgs e)
        {
            soChanDau();
        }

        private void soChanDau()
        {
            int temp = 0;
            int viTri = 0;
            for (int i = 0; i < listNumber.Count; i++)
            {
                if (listNumber[i] % 2 == 0)
                {
                    temp = listNumber[i];
                    viTri = i;
                }
            }
            listBox1.SelectedIndex = viTri;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt|Keys.H))
            {
                Exit();
            }
            if (keyData == (Keys.Alt | Keys.T))
            {
                addList();
            }
            if (keyData == (Keys.Alt | Keys.X))
            {
                RList();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
