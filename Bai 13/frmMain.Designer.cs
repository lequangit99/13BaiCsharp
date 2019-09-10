namespace Bai_13
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
            this.lbSoDuongMin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnNhapDay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDuongMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử";
            // 
            // lbDaySo
            // 
            this.lbDaySo.AutoSize = true;
            this.lbDaySo.Location = new System.Drawing.Point(12, 65);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(69, 20);
            this.lbDaySo.TabIndex = 1;
            this.lbDaySo.Text = "lbDaySo";
            // 
            // lbSoDuongMin
            // 
            this.lbSoDuongMin.AutoSize = true;
            this.lbSoDuongMin.Location = new System.Drawing.Point(12, 161);
            this.lbSoDuongMin.Name = "lbSoDuongMin";
            this.lbSoDuongMin.Size = new System.Drawing.Size(114, 20);
            this.lbSoDuongMin.TabIndex = 2;
            this.lbSoDuongMin.Text = "lbSoDuongMin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập 1 số =";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(145, 13);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(131, 26);
            this.txtAdd.TabIndex = 4;
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(113, 198);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(163, 26);
            this.txtCheck.TabIndex = 5;
            // 
            // btnNhapDay
            // 
            this.btnNhapDay.Location = new System.Drawing.Point(302, 7);
            this.btnNhapDay.Name = "btnNhapDay";
            this.btnNhapDay.Size = new System.Drawing.Size(136, 41);
            this.btnNhapDay.TabIndex = 6;
            this.btnNhapDay.Text = "Nhập dãy";
            this.btnNhapDay.UseVisualStyleBackColor = true;
            this.btnNhapDay.Click += new System.EventHandler(this.BtnNhapDay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(302, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(136, 41);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(142, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 41);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Làm lại";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(302, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnDuongMin
            // 
            this.btnDuongMin.Location = new System.Drawing.Point(12, 103);
            this.btnDuongMin.Name = "btnDuongMin";
            this.btnDuongMin.Size = new System.Drawing.Size(187, 41);
            this.btnDuongMin.TabIndex = 10;
            this.btnDuongMin.Text = "Tìm số dương nhỏ nhất";
            this.btnDuongMin.UseVisualStyleBackColor = true;
            this.btnDuongMin.Click += new System.EventHandler(this.BtnDuongMin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 338);
            this.Controls.Add(this.btnDuongMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNhapDay);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSoDuongMin);
            this.Controls.Add(this.lbDaySo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDaySo;
        private System.Windows.Forms.Label lbSoDuongMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnNhapDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDuongMin;
    }
}

