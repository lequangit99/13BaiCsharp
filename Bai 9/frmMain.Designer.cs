namespace Bai_9
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
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbATM = new System.Windows.Forms.RadioButton();
            this.rbMorney = new System.Windows.Forms.RadioButton();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.cbBook);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(364, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn sách";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(127, 108);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(227, 26);
            this.txtSL.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(127, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 26);
            this.txtPrice.TabIndex = 4;
            // 
            // cbBook
            // 
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Tiếng anh F2",
            "Giải tích F1",
            "Đại số tuyến tính"});
            this.cbBook.Location = new System.Drawing.Point(127, 25);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(227, 28);
            this.cbBook.TabIndex = 3;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.CbBook_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.rbATM);
            this.groupBox2.Controls.Add(this.rbMorney);
            this.groupBox2.Controls.Add(this.txtSale);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(392, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(390, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phương thức thanh toán";
            // 
            // rbATM
            // 
            this.rbATM.AutoSize = true;
            this.rbATM.Location = new System.Drawing.Point(156, 43);
            this.rbATM.Name = "rbATM";
            this.rbATM.Size = new System.Drawing.Size(91, 24);
            this.rbATM.TabIndex = 7;
            this.rbATM.TabStop = true;
            this.rbATM.Text = "Thẻ ATM";
            this.rbATM.UseVisualStyleBackColor = true;
            this.rbATM.CheckedChanged += new System.EventHandler(this.RbATM_CheckedChanged);
            // 
            // rbMorney
            // 
            this.rbMorney.AutoSize = true;
            this.rbMorney.Location = new System.Drawing.Point(11, 43);
            this.rbMorney.Name = "rbMorney";
            this.rbMorney.Size = new System.Drawing.Size(88, 24);
            this.rbMorney.TabIndex = 6;
            this.rbMorney.TabStop = true;
            this.rbMorney.Text = "Tiền mặt";
            this.rbMorney.UseVisualStyleBackColor = true;
            this.rbMorney.CheckedChanged += new System.EventHandler(this.RbMorney_CheckedChanged);
            // 
            // txtSale
            // 
            this.txtSale.Enabled = false;
            this.txtSale.Location = new System.Drawing.Point(156, 105);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(154, 26);
            this.txtSale.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giảm giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.txtSum);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnSum);
            this.groupBox3.Location = new System.Drawing.Point(101, 229);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(601, 288);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách đã mua";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(8, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(572, 164);
            this.listBox1.TabIndex = 6;
            // 
            // txtSum
            // 
            this.txtSum.Enabled = false;
            this.txtSum.Location = new System.Drawing.Point(353, 204);
            this.txtSum.Multiline = true;
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(227, 41);
            this.txtSum.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(32, 206);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 39);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Xoá";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(175, 206);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(125, 39);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Tổng tiền";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(346, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(346, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(317, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "%";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 577);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbATM;
        private System.Windows.Forms.RadioButton rbMorney;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
    }
}

