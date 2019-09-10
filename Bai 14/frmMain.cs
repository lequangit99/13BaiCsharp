using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai_14
{
    public partial class frmMain : Form
    {
        List<Student> students = new List<Student>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnDK_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text) && cbFaculty.SelectedIndex != -1 && cbKhoa.SelectedIndex != -1 && listGiaoTrinh.SelectedIndex != -1)
            {
                string s = null;
                foreach (var item in listGiaoTrinh.SelectedItems)
                {
                    s += item + ", ";
                }
                listGiaoTrinh.SelectedIndex = -1;
                Student student = new Student(txtName.Text, cbFaculty.Text, int.Parse(cbKhoa.Text), s);
                students.Add(student);
                listMuon.Items.Add(student.ToString());
            }
            else
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listMuon.SelectedIndex != -1)
            {
                if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    students.RemoveAt(listMuon.SelectedIndex);
                    listMuon.Items.RemoveAt(listMuon.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Chọn sinh viên cần xoá");
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            cbFaculty.SelectedIndex = -1;
            cbKhoa.SelectedIndex = -1;
            listGiaoTrinh.SelectedIndex = -1;
            listMuon.Items.Clear();
            students.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
