namespace Bai_7
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbDaySo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.cbChucNang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử của dãy";
            // 
            // lbDaySo
            // 
            this.lbDaySo.AutoSize = true;
            this.lbDaySo.Location = new System.Drawing.Point(18, 65);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(127, 20);
            this.lbDaySo.TabIndex = 1;
            this.lbDaySo.Text = "Dãy số vừa nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn chức năng";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(18, 166);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(51, 20);
            this.lbKetQua.TabIndex = 3;
            this.lbKetQua.Text = "label4";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Nhập dãy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(663, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(530, 166);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(127, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(209, 10);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(202, 26);
            this.txtNhapSo.TabIndex = 7;
            this.txtNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapSo_KeyPress);
            // 
            // cbChucNang
            // 
            this.cbChucNang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucNang.FormattingEnabled = true;
            this.cbChucNang.Items.AddRange(new object[] {
            "Trung bình cộng của dãy",
            "Đếm số phần tử âm"});
            this.cbChucNang.Location = new System.Drawing.Point(209, 114);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(202, 28);
            this.cbChucNang.TabIndex = 8;
            this.cbChucNang.SelectedIndexChanged += new System.EventHandler(this.CbChucNang_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 242);
            this.Controls.Add(this.cbChucNang);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDaySo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Tính toán trên dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDaySo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.ComboBox cbChucNang;
    }
}

