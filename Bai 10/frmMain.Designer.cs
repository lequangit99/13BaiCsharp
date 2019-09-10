namespace Bai_10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbB2 = new System.Windows.Forms.RadioButton();
            this.rbB1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbB2);
            this.groupBox1.Controls.Add(this.rbB1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // rbB2
            // 
            this.rbB2.AutoSize = true;
            this.rbB2.Location = new System.Drawing.Point(7, 56);
            this.rbB2.Name = "rbB2";
            this.rbB2.Size = new System.Drawing.Size(172, 24);
            this.rbB2.TabIndex = 1;
            this.rbB2.TabStop = true;
            this.rbB2.Text = "Phương trình bậc hai";
            this.rbB2.UseVisualStyleBackColor = true;
            this.rbB2.CheckedChanged += new System.EventHandler(this.RbB2_CheckedChanged);
            // 
            // rbB1
            // 
            this.rbB1.AutoSize = true;
            this.rbB1.Location = new System.Drawing.Point(7, 26);
            this.rbB1.Name = "rbB1";
            this.rbB1.Size = new System.Drawing.Size(183, 24);
            this.rbB1.TabIndex = 0;
            this.rbB1.TabStop = true;
            this.rbB1.Text = "Phương trình bậc nhất";
            this.rbB1.UseVisualStyleBackColor = true;
            this.rbB1.CheckedChanged += new System.EventHandler(this.RbB1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(86, 159);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(289, 26);
            this.txtA.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(86, 202);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(289, 26);
            this.txtB.TabIndex = 7;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(86, 246);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(289, 26);
            this.txtC.TabIndex = 8;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Enabled = false;
            this.txtKetQua.Location = new System.Drawing.Point(86, 292);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(289, 51);
            this.txtKetQua.TabIndex = 9;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(412, 162);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(156, 57);
            this.btnGiai.TabIndex = 10;
            this.btnGiai.Text = "Giải phương trình";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.BtnGiai_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(412, 225);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 57);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Làm lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(412, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 57);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 363);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbB2;
        private System.Windows.Forms.RadioButton rbB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
    }
}

