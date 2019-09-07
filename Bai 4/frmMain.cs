using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class frmMain : Form
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiem.Text = null;
            if (cbName.SelectedIndex != -1)
            {
                if (cbName.SelectedIndex == 0)
                {
                    txtSoTinChi.Text = "2";
                }
                else if (cbName.SelectedIndex == 1)
                {
                    txtSoTinChi.Text = "3";
                }
                else if (cbName.SelectedIndex == 2)
                {
                    txtSoTinChi.Text = "3";
                }
                else if (cbName.SelectedIndex == 3)
                {
                    txtSoTinChi.Text = "2";
                }
                else if (cbName.SelectedIndex == 4)
                {
                    txtSoTinChi.Text = "3";
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void AddList()
        {
            if (cbName.SelectedIndex != -1 && !String.IsNullOrEmpty(txtDiem.Text) && double.TryParse(txtDiem.Text, out double temp))
            {
                SinhVien sinhVien = new SinhVien(cbName.Text, int.Parse(txtSoTinChi.Text), double.Parse(txtDiem.Text));
                sinhViens.Add(sinhVien);
                listBox1.Items.Add(sinhVien.ToString());
            }
            else
            {
                MessageBox.Show("Nhập lại");
            }
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
            if (keyData == (Keys.Alt | Keys.D))
            {
                AddList();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                int tongTinChi = 0;
                double tongDiem = 0.0;
                foreach (var item in sinhViens)
                {
                    tongTinChi += item.SoTinChi;
                    tongDiem += item.Diem * item.SoTinChi;

                }
                double diemTB = tongDiem / tongTinChi;
                txtTongTinChi.Text = tongTinChi.ToString();
                txtTongDiem.Text = tongDiem.ToString();
                txtDiemTB.Text = diemTB.ToString();
            }
            else
            {
                MessageBox.Show("Thêm môn học vào");
            }
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            AddList();
        }
    }
}
