namespace Bai_11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbKichThuoc = new System.Windows.Forms.ComboBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGachChan = new System.Windows.Forms.CheckBox();
            this.cbNghieng = new System.Windows.Forms.CheckBox();
            this.cbDam = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTEXT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbKichThuoc);
            this.groupBox1.Controls.Add(this.cbFont);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chữ";
            // 
            // cbKichThuoc
            // 
            this.cbKichThuoc.FormattingEnabled = true;
            this.cbKichThuoc.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "24"});
            this.cbKichThuoc.Location = new System.Drawing.Point(776, 29);
            this.cbKichThuoc.Name = "cbKichThuoc";
            this.cbKichThuoc.Size = new System.Drawing.Size(121, 28);
            this.cbKichThuoc.TabIndex = 3;
            this.cbKichThuoc.SelectedIndexChanged += new System.EventHandler(this.CbKichThuoc_SelectedIndexChanged);
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Items.AddRange(new object[] {
            "Arial",
            "Consolas",
            "Microsoft Sans Serif",
            "Source Code Pro"});
            this.cbFont.Location = new System.Drawing.Point(194, 29);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(265, 28);
            this.cbFont.TabIndex = 2;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.CbFont_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(680, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khích thước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGachChan);
            this.groupBox2.Controls.Add(this.cbNghieng);
            this.groupBox2.Controls.Add(this.cbDam);
            this.groupBox2.Location = new System.Drawing.Point(13, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 68);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng chữ";
            // 
            // cbGachChan
            // 
            this.cbGachChan.AutoSize = true;
            this.cbGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGachChan.Location = new System.Drawing.Point(776, 25);
            this.cbGachChan.Name = "cbGachChan";
            this.cbGachChan.Size = new System.Drawing.Size(106, 24);
            this.cbGachChan.TabIndex = 2;
            this.cbGachChan.Text = "Gạch chân";
            this.cbGachChan.UseVisualStyleBackColor = true;
            this.cbGachChan.CheckedChanged += new System.EventHandler(this.CbGachChan_CheckedChanged);
            // 
            // cbNghieng
            // 
            this.cbNghieng.AutoSize = true;
            this.cbNghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNghieng.Location = new System.Drawing.Point(435, 25);
            this.cbNghieng.Name = "cbNghieng";
            this.cbNghieng.Size = new System.Drawing.Size(87, 24);
            this.cbNghieng.TabIndex = 1;
            this.cbNghieng.Text = "Nghiêng";
            this.cbNghieng.UseVisualStyleBackColor = true;
            this.cbNghieng.CheckedChanged += new System.EventHandler(this.CbNghieng_CheckedChanged);
            // 
            // cbDam
            // 
            this.cbDam.AutoSize = true;
            this.cbDam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDam.Location = new System.Drawing.Point(141, 25);
            this.cbDam.Name = "cbDam";
            this.cbDam.Size = new System.Drawing.Size(65, 24);
            this.cbDam.TabIndex = 0;
            this.cbDam.Text = "Đậm";
            this.cbDam.UseVisualStyleBackColor = true;
            this.cbDam.CheckedChanged += new System.EventHandler(this.CbDam_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBlack);
            this.groupBox3.Controls.Add(this.rbGreen);
            this.groupBox3.Controls.Add(this.rbRed);
            this.groupBox3.Location = new System.Drawing.Point(13, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1003, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlack.Location = new System.Drawing.Point(776, 25);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(60, 24);
            this.rbBlack.TabIndex = 5;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Đen";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.RbBlack_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGreen.ForeColor = System.Drawing.Color.Lime;
            this.rbGreen.Location = new System.Drawing.Point(435, 25);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(120, 24);
            this.rbGreen.TabIndex = 4;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Xanh lá cây";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.RbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(141, 25);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(50, 24);
            this.rbRed.TabIndex = 3;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Đỏ";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.RbRed_CheckedChanged);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(364, 439);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(108, 39);
            this.btnLamLai.TabIndex = 3;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.BtnLamLai_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(527, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtTEXT
            // 
            this.txtTEXT.Location = new System.Drawing.Point(154, 22);
            this.txtTEXT.Multiline = true;
            this.txtTEXT.Name = "txtTEXT";
            this.txtTEXT.Size = new System.Drawing.Size(756, 116);
            this.txtTEXT.TabIndex = 6;
            this.txtTEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 486);
            this.Controls.Add(this.txtTEXT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbKichThuoc;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbGachChan;
        private System.Windows.Forms.CheckBox cbNghieng;
        private System.Windows.Forms.CheckBox cbDam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTEXT;
    }
}

