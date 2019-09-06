using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
