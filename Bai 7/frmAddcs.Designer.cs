namespace Bai_7
{
    partial class frmAddcs
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
            this.lbSoPhanTu = new System.Windows.Forms.Label();
            this.txtPhanTu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSoPhanTu
            // 
            this.lbSoPhanTu.AutoSize = true;
            this.lbSoPhanTu.Location = new System.Drawing.Point(191, 9);
            this.lbSoPhanTu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoPhanTu.Name = "lbSoPhanTu";
            this.lbSoPhanTu.Size = new System.Drawing.Size(174, 20);
            this.lbSoPhanTu.TabIndex = 0;
            this.lbSoPhanTu.Text = "Nhấp vào phần tử thứ 1";
            // 
            // txtPhanTu
            // 
            this.txtPhanTu.Location = new System.Drawing.Point(136, 44);
            this.txtPhanTu.Name = "txtPhanTu";
            this.txtPhanTu.Size = new System.Drawing.Size(286, 26);
            this.txtPhanTu.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmAddcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 130);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhanTu);
            this.Controls.Add(this.lbSoPhanTu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddcs";
            this.Text = "frmAddcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoPhanTu;
        private System.Windows.Forms.TextBox txtPhanTu;
        private System.Windows.Forms.Button btnAdd;
    }
}