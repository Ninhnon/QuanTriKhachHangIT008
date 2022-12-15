namespace WPSQL
{
    partial class DanhSachKhachHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSKHColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGDKColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMSKH = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.tp_BirthDay = new System.Windows.Forms.DateTimePicker();
            this.tp_RegisterDay = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new System.Windows.Forms.Button();
            this.DateError = new System.Windows.Forms.Label();
            this.NGDKError = new System.Windows.Forms.Label();
            this.NameError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSKHColumn,
            this.NameColumn,
            this.BirthDayColumn,
            this.NGDKColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 472);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MSKHColumn
            // 
            this.MSKHColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSKHColumn.HeaderText = "MSKH";
            this.MSKHColumn.MinimumWidth = 10;
            this.MSKHColumn.Name = "MSKHColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Tên";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            // 
            // BirthDayColumn
            // 
            this.BirthDayColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BirthDayColumn.HeaderText = "Ngày Sinh";
            this.BirthDayColumn.MinimumWidth = 10;
            this.BirthDayColumn.Name = "BirthDayColumn";
            // 
            // NGDKColumn
            // 
            this.NGDKColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGDKColumn.HeaderText = "Ngày Đăng Ký";
            this.NGDKColumn.MinimumWidth = 10;
            this.NGDKColumn.Name = "NGDKColumn";
            // 
            // txtMSKH
            // 
            this.txtMSKH.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMSKH.Enabled = false;
            this.txtMSKH.Location = new System.Drawing.Point(181, 48);
            this.txtMSKH.Name = "txtMSKH";
            this.txtMSKH.Size = new System.Drawing.Size(225, 31);
            this.txtMSKH.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(675, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(266, 31);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "MSKH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Đăng Ký";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(806, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 47);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(660, 240);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(124, 44);
            this.btn_Insert.TabIndex = 10;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // tp_BirthDay
            // 
            this.tp_BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tp_BirthDay.Location = new System.Drawing.Point(185, 160);
            this.tp_BirthDay.Name = "tp_BirthDay";
            this.tp_BirthDay.Size = new System.Drawing.Size(221, 31);
            this.tp_BirthDay.TabIndex = 11;
            // 
            // tp_RegisterDay
            // 
            this.tp_RegisterDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tp_RegisterDay.Location = new System.Drawing.Point(675, 155);
            this.tp_RegisterDay.Name = "tp_RegisterDay";
            this.tp_RegisterDay.Size = new System.Drawing.Size(266, 31);
            this.tp_RegisterDay.TabIndex = 12;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(506, 241);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 44);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // DateError
            // 
            this.DateError.AutoSize = true;
            this.DateError.Location = new System.Drawing.Point(189, 194);
            this.DateError.Name = "DateError";
            this.DateError.Size = new System.Drawing.Size(104, 25);
            this.DateError.TabIndex = 24;
            this.DateError.Text = "DateError";
            // 
            // NGDKError
            // 
            this.NGDKError.AutoSize = true;
            this.NGDKError.Location = new System.Drawing.Point(670, 194);
            this.NGDKError.Name = "NGDKError";
            this.NGDKError.Size = new System.Drawing.Size(119, 25);
            this.NGDKError.TabIndex = 25;
            this.NGDKError.Text = "NGDKError";
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.Location = new System.Drawing.Point(674, 88);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(115, 25);
            this.NameError.TabIndex = 26;
            this.NameError.Text = "NameError";
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 766);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.NGDKError);
            this.Controls.Add(this.DateError);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tp_RegisterDay);
            this.Controls.Add(this.tp_BirthDay);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtMSKH);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách Khách hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMSKH;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSKHColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGDKColumn;
        private System.Windows.Forms.DateTimePicker tp_BirthDay;
        private System.Windows.Forms.DateTimePicker tp_RegisterDay;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label DateError;
        private System.Windows.Forms.Label NGDKError;
        private System.Windows.Forms.Label NameError;
    }
}

