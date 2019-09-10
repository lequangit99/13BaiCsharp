namespace Bai_8
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPlus3 = new System.Windows.Forms.Button();
            this.btnSoChanDau = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập 1 số";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(209, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnPlus3
            // 
            this.btnPlus3.Location = new System.Drawing.Point(12, 93);
            this.btnPlus3.Name = "btnPlus3";
            this.btnPlus3.Size = new System.Drawing.Size(209, 38);
            this.btnPlus3.TabIndex = 2;
            this.btnPlus3.Text = "Tăng mỗi số lên 3";
            this.btnPlus3.UseVisualStyleBackColor = true;
            this.btnPlus3.Click += new System.EventHandler(this.BtnPlus3_Click);
            // 
            // btnSoChanDau
            // 
            this.btnSoChanDau.Location = new System.Drawing.Point(12, 137);
            this.btnSoChanDau.Name = "btnSoChanDau";
            this.btnSoChanDau.Size = new System.Drawing.Size(209, 38);
            this.btnSoChanDau.TabIndex = 3;
            this.btnSoChanDau.Text = "Chọn số chẵn đầu";
            this.btnSoChanDau.UseVisualStyleBackColor = true;
            this.btnSoChanDau.Click += new System.EventHandler(this.BtnSoChanDau_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(262, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(35, 262);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(122, 38);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(99, 6);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(122, 26);
            this.txtAdd.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(227, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 224);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSoChanDau);
            this.Controls.Add(this.btnPlus3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlus3;
        private System.Windows.Forms.Button btnSoChanDau;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

