namespace Bai_5
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
            this.lbSum = new System.Windows.Forms.Label();
            this.lbMaxMin = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnRList = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(664, 9);
            this.lbSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(42, 20);
            this.lbSum.TabIndex = 1;
            this.lbSum.Text = "Sum";
            // 
            // lbMaxMin
            // 
            this.lbMaxMin.AutoSize = true;
            this.lbMaxMin.Location = new System.Drawing.Point(664, 39);
            this.lbMaxMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaxMin.Name = "lbMaxMin";
            this.lbMaxMin.Size = new System.Drawing.Size(63, 20);
            this.lbMaxMin.TabIndex = 2;
            this.lbMaxMin.Text = "MaxMin";
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(12, 77);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(183, 32);
            this.btnAddList.TabIndex = 4;
            this.btnAddList.Text = "Thêm vào DS";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.BtnAddList_Click);
            // 
            // btnRList
            // 
            this.btnRList.Location = new System.Drawing.Point(12, 115);
            this.btnRList.Name = "btnRList";
            this.btnRList.Size = new System.Drawing.Size(183, 32);
            this.btnRList.TabIndex = 5;
            this.btnRList.Text = "Xoá khỏi DS";
            this.btnRList.UseVisualStyleBackColor = true;
            this.btnRList.Click += new System.EventHandler(this.BtnRList_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 153);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(183, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(474, 9);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(183, 32);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(474, 48);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(183, 32);
            this.btnMax.TabIndex = 8;
            this.btnMax.Text = "Tìm max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(474, 86);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(183, 32);
            this.btnMin.TabIndex = 9;
            this.btnMin.Text = "Tìm min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(201, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 308);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy Số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 264);
            this.listBox1.TabIndex = 0;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(183, 26);
            this.txtNumber.TabIndex = 11;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(474, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 332);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lbMaxMin);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Dãy số";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbMaxMin;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnRList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnExit;
    }
}

