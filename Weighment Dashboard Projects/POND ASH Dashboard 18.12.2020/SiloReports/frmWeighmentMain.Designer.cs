namespace SiloReports
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnFetchRecords = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWeighmentHeader = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.lblTotalTonnage = new System.Windows.Forms.Label();
            this.txtTotalTonnage = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiloReports.Properties.Resources.Header;
            this.pictureBox1.InitialImage = global::SiloReports.Properties.Resources.Header;
            this.pictureBox1.Location = new System.Drawing.Point(150, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Modern No. 20", 16.05755F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(240, 153);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(632, 32);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "WEIGHMENT REPORTING DASHBOARD";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(71, 233);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(89, 21);
            this.lblProductCode.TabIndex = 2;
            this.lblProductCode.Text = "Product ";
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "FLY ASH"});
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "POND ASH",
            "FLY ASH"});
            this.cmbProduct.Location = new System.Drawing.Point(165, 229);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(163, 24);
            this.cmbProduct.TabIndex = 3;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.Leave += new System.EventHandler(this.cmbProduct_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "DD-MMM-YYYY HH:mm:ss.fff";
            this.dateTimePicker1.Location = new System.Drawing.Point(441, 231);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 20, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(357, 233);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(77, 21);
            this.lblfrom.TabIndex = 5;
            this.lblfrom.Text = "From : ";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(739, 233);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(45, 21);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "To :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "DD-MMM-YYYY HH:mm:ss.fff";
            this.dateTimePicker2.Location = new System.Drawing.Point(789, 233);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Value = new System.DateTime(2019, 12, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.DropDown += new System.EventHandler(this.dateTimePicker2_DropDown);
            // 
            // btnFetchRecords
            // 
            this.btnFetchRecords.Font = new System.Drawing.Font("Verdana", 7.251799F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchRecords.Location = new System.Drawing.Point(363, 298);
            this.btnFetchRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFetchRecords.Name = "btnFetchRecords";
            this.btnFetchRecords.Size = new System.Drawing.Size(177, 44);
            this.btnFetchRecords.TabIndex = 8;
            this.btnFetchRecords.Text = "Fetch Records";
            this.btnFetchRecords.UseVisualStyleBackColor = true;
            this.btnFetchRecords.Click += new System.EventHandler(this.btnFetchRecords_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Font = new System.Drawing.Font("Verdana", 7.251799F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToExcel.Location = new System.Drawing.Point(563, 299);
            this.btnExportToExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(319, 44);
            this.btnExportToExcel.TabIndex = 9;
            this.btnExportToExcel.Text = "Export DATA to Excel Spreadsheet";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.841726F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Location,
            this.Column3,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(75, 416);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1199, 327);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "S.NO";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "supcode";
            this.Column1.HeaderText = "Supplier Code";
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "supplier";
            this.Column2.HeaderText = "Supplier Name";
            this.Column2.Name = "Column2";
            // 
            // Location
            // 
            this.Location.DataPropertyName = "unit";
            dataGridViewCellStyle2.NullValue = "KTPP Stage-I & Stage-II";
            this.Location.DefaultCellStyle = dataGridViewCellStyle2;
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Total_trips";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "No of Trips";
            this.Column3.MinimumWidth = 20;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Total_Tonnage";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Total Wt (MT)";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // lblWeighmentHeader
            // 
            this.lblWeighmentHeader.AutoSize = true;
            this.lblWeighmentHeader.Font = new System.Drawing.Font("Bookman Old Style", 10.8777F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeighmentHeader.Location = new System.Drawing.Point(69, 378);
            this.lblWeighmentHeader.Name = "lblWeighmentHeader";
            this.lblWeighmentHeader.Size = new System.Drawing.Size(228, 25);
            this.lblWeighmentHeader.TabIndex = 11;
            this.lblWeighmentHeader.Text = "Weighment Report";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Verdana", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.Location = new System.Drawing.Point(903, 298);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(143, 44);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Clear";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // lblTotalTonnage
            // 
            this.lblTotalTonnage.AutoSize = true;
            this.lblTotalTonnage.Font = new System.Drawing.Font("Times New Roman", 11.91367F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTonnage.Location = new System.Drawing.Point(101, 770);
            this.lblTotalTonnage.Name = "lblTotalTonnage";
            this.lblTotalTonnage.Size = new System.Drawing.Size(336, 26);
            this.lblTotalTonnage.TabIndex = 13;
            this.lblTotalTonnage.Text = "Total Tonnage in Metric Tonnes";
            // 
            // txtTotalTonnage
            // 
            this.txtTotalTonnage.Font = new System.Drawing.Font("Times New Roman", 16.05755F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTonnage.Location = new System.Drawing.Point(441, 759);
            this.txtTotalTonnage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalTonnage.Name = "txtTotalTonnage";
            this.txtTotalTonnage.ReadOnly = true;
            this.txtTotalTonnage.Size = new System.Drawing.Size(259, 43);
            this.txtTotalTonnage.TabIndex = 14;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(103, 938);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(436, 16);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "* Contact KTPP IT Team intercomm 2546 or 4546 for further IT Assistance";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "KTPP Stage-I",
            "KTPP Stage-II",
            "KTPP Stage-I & II"});
            this.cmbLocation.Location = new System.Drawing.Point(168, 299);
            this.cmbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(160, 24);
            this.cmbLocation.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Location";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1383, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtTotalTonnage);
            this.Controls.Add(this.lblTotalTonnage);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.lblWeighmentHeader);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnFetchRecords);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WEIGHMENT SUMMARY DASHBOARD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFetchRecords;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblWeighmentHeader;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lblTotalTonnage;
        private System.Windows.Forms.TextBox txtTotalTonnage;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

