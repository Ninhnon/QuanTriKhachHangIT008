namespace WPSQL
{
    partial class Insert
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtMSKH = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.NGSinh = new System.Windows.Forms.DateTimePicker();
            this.NGDK = new System.Windows.Forms.DateTimePicker();
            this.MSKHerorr = new System.Windows.Forms.Label();
            this.MSKHerror = new System.Windows.Forms.Label();
            this.NameError = new System.Windows.Forms.Label();
            this.DateError = new System.Windows.Forms.Label();
            this.NGDKError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày Đăng Ký";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "MSKH";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(660, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(266, 31);
            this.txtname.TabIndex = 10;
            // 
            // txtMSKH
            // 
            this.txtMSKH.Location = new System.Drawing.Point(166, 27);
            this.txtMSKH.Name = "txtMSKH";
            this.txtMSKH.Size = new System.Drawing.Size(225, 31);
            this.txtMSKH.TabIndex = 9;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(845, 238);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(81, 37);
            this.btn_OK.TabIndex = 17;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // NGSinh
            // 
            this.NGSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NGSinh.Location = new System.Drawing.Point(170, 168);
            this.NGSinh.Name = "NGSinh";
            this.NGSinh.Size = new System.Drawing.Size(221, 31);
            this.NGSinh.TabIndex = 18;
            // 
            // NGDK
            // 
            this.NGDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NGDK.Location = new System.Drawing.Point(660, 159);
            this.NGDK.Name = "NGDK";
            this.NGDK.Size = new System.Drawing.Size(266, 31);
            this.NGDK.TabIndex = 19;
            // 
            // MSKHerorr
            // 
            this.MSKHerorr.AutoSize = true;
            this.MSKHerorr.Location = new System.Drawing.Point(165, 61);
            this.MSKHerorr.Name = "MSKHerorr";
            this.MSKHerorr.Size = new System.Drawing.Size(0, 25);
            this.MSKHerorr.TabIndex = 20;
            // 
            // MSKHerror
            // 
            this.MSKHerror.AutoSize = true;
            this.MSKHerror.Location = new System.Drawing.Point(165, 75);
            this.MSKHerror.Name = "MSKHerror";
            this.MSKHerror.Size = new System.Drawing.Size(118, 25);
            this.MSKHerror.TabIndex = 21;
            this.MSKHerror.Text = "MSKHerror";
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.Location = new System.Drawing.Point(655, 75);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(115, 25);
            this.NameError.TabIndex = 22;
            this.NameError.Text = "NameError";
            // 
            // DateError
            // 
            this.DateError.AutoSize = true;
            this.DateError.Location = new System.Drawing.Point(165, 202);
            this.DateError.Name = "DateError";
            this.DateError.Size = new System.Drawing.Size(104, 25);
            this.DateError.TabIndex = 23;
            this.DateError.Text = "DateError";
            // 
            // NGDKError
            // 
            this.NGDKError.AutoSize = true;
            this.NGDKError.Location = new System.Drawing.Point(655, 193);
            this.NGDKError.Name = "NGDKError";
            this.NGDKError.Size = new System.Drawing.Size(119, 25);
            this.NGDKError.TabIndex = 24;
            this.NGDKError.Text = "NGDKError";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(729, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 37);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 308);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.NGDKError);
            this.Controls.Add(this.DateError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.MSKHerror);
            this.Controls.Add(this.MSKHerorr);
            this.Controls.Add(this.NGDK);
            this.Controls.Add(this.NGSinh);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtMSKH);
            this.Name = "Insert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtMSKH;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DateTimePicker NGSinh;
        private System.Windows.Forms.DateTimePicker NGDK;
        private System.Windows.Forms.Label MSKHerorr;
        private System.Windows.Forms.Label MSKHerror;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label DateError;
        private System.Windows.Forms.Label NGDKError;
        private System.Windows.Forms.Button btnCancel;
    }
}