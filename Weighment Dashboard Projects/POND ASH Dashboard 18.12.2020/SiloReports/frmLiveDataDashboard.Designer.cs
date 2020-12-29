namespace SiloReports
{
    partial class frmLiveDataDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiveDataDashboard));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLiveDashboard = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.radioButtonTotal = new System.Windows.Forms.RadioButton();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.733813F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRNO,
            this.VehicleNo,
            this.SupplierCode,
            this.SupplierName,
            this.ProductName,
            this.firstWeight,
            this.location,
            this.remarks,
            this.indate,
            this.intime,
            this.TimeElapsed});
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SRNO
            // 
            this.SRNO.DataPropertyName = "srno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SRNO.DefaultCellStyle = dataGridViewCellStyle2;
            this.SRNO.FillWeight = 78.97607F;
            this.SRNO.HeaderText = "SRNO";
            this.SRNO.Name = "SRNO";
            // 
            // VehicleNo
            // 
            this.VehicleNo.DataPropertyName = "vehicleno";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.VehicleNo.FillWeight = 104.8895F;
            this.VehicleNo.HeaderText = "Vehicle NO";
            this.VehicleNo.Name = "VehicleNo";
            // 
            // SupplierCode
            // 
            this.SupplierCode.DataPropertyName = "supcode";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierCode.DefaultCellStyle = dataGridViewCellStyle4;
            this.SupplierCode.FillWeight = 52.59411F;
            this.SupplierCode.HeaderText = "Supplier Code";
            this.SupplierCode.MinimumWidth = 10;
            this.SupplierCode.Name = "SupplierCode";
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "supplier";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierName.DefaultCellStyle = dataGridViewCellStyle5;
            this.SupplierName.FillWeight = 215.3846F;
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "prodcode";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle6;
            this.ProductName.FillWeight = 81.04993F;
            this.ProductName.HeaderText = "Product Code";
            this.ProductName.Name = "ProductName";
            // 
            // firstWeight
            // 
            this.firstWeight.DataPropertyName = "firstweight";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.firstWeight.DefaultCellStyle = dataGridViewCellStyle7;
            this.firstWeight.FillWeight = 81.91573F;
            this.firstWeight.HeaderText = "First Weight";
            this.firstWeight.MinimumWidth = 10;
            this.firstWeight.Name = "firstWeight";
            // 
            // location
            // 
            this.location.DataPropertyName = "unit";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.location.DefaultCellStyle = dataGridViewCellStyle8;
            this.location.FillWeight = 107.4809F;
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            // 
            // remarks
            // 
            this.remarks.DataPropertyName = "remarks";
            this.remarks.HeaderText = "Delivery No";
            this.remarks.Name = "remarks";
            // 
            // indate
            // 
            this.indate.DataPropertyName = "indate";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "dd-MMM-yyyy";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.indate.DefaultCellStyle = dataGridViewCellStyle9;
            this.indate.FillWeight = 81.75528F;
            this.indate.HeaderText = "IN Date";
            this.indate.Name = "indate";
            // 
            // intime
            // 
            this.intime.DataPropertyName = "intime";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Format = "HH:mm ";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.intime.DefaultCellStyle = dataGridViewCellStyle10;
            this.intime.FillWeight = 83.75635F;
            this.intime.HeaderText = "IN Time";
            this.intime.Name = "intime";
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.DataPropertyName = "timeElapsed";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 8.805756F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Format = "HH:mm Hrs";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TimeElapsed.DefaultCellStyle = dataGridViewCellStyle11;
            this.TimeElapsed.FillWeight = 149.7916F;
            this.TimeElapsed.HeaderText = "Time Elapsed";
            this.TimeElapsed.Name = "TimeElapsed";
            // 
            // btnLiveDashboard
            // 
            this.btnLiveDashboard.Font = new System.Drawing.Font("Modern No. 20", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiveDashboard.Location = new System.Drawing.Point(368, 69);
            this.btnLiveDashboard.Name = "btnLiveDashboard";
            this.btnLiveDashboard.Size = new System.Drawing.Size(254, 38);
            this.btnLiveDashboard.TabIndex = 1;
            this.btnLiveDashboard.Text = "Fetch Live DATA ";
            this.btnLiveDashboard.UseVisualStyleBackColor = true;
            this.btnLiveDashboard.Click += new System.EventHandler(this.btnLiveDashboard_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.AutoCompleteCustomSource.AddRange(new string[] {
            "FLY ASH"});
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "POND ASH",
            "FLY ASH"});
            this.cmbProduct.Location = new System.Drawing.Point(134, 75);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(206, 24);
            this.cmbProduct.TabIndex = 5;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(39, 78);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(89, 21);
            this.lblProductCode.TabIndex = 4;
            this.lblProductCode.Text = "Product ";
            // 
            // radioButtonTotal
            // 
            this.radioButtonTotal.AutoSize = true;
            this.radioButtonTotal.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTotal.Location = new System.Drawing.Point(43, 126);
            this.radioButtonTotal.Name = "radioButtonTotal";
            this.radioButtonTotal.Size = new System.Drawing.Size(206, 25);
            this.radioButtonTotal.TabIndex = 7;
            this.radioButtonTotal.TabStop = true;
            this.radioButtonTotal.Text = "Total Transactions";
            this.radioButtonTotal.UseVisualStyleBackColor = true;
            this.radioButtonTotal.CheckedChanged += new System.EventHandler(this.radioButtonTotal_CheckedChanged);
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonToday.Location = new System.Drawing.Point(264, 126);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(208, 25);
            this.radioButtonToday.TabIndex = 8;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "From Specific Date";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            this.radioButtonToday.CheckedChanged += new System.EventHandler(this.radioButtonToday_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(286, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 22, 0, 0, 0, 0);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 13.98561F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(39, 209);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(92, 31);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Text = "Header";
            // 
            // frmLiveDataDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 611);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonToday);
            this.Controls.Add(this.radioButtonTotal);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.btnLiveDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLiveDataDashboard";
            this.Text = "KTPP Live Trip information Dashboard";
            this.Load += new System.EventHandler(this.frmLiveDataDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLiveDashboard;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.RadioButton radioButtonTotal;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn indate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeElapsed;
        private System.Windows.Forms.Label lblHeader;
    }
}