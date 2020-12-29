namespace SiloReports
{
    partial class frmFTPstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFTPstatus));
            this.radioButtonDCNo = new System.Windows.Forms.RadioButton();
            this.radioButtonInvoice = new System.Windows.Forms.RadioButton();
            this.btnFTPdata = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResultBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonDCNo
            // 
            this.radioButtonDCNo.AutoSize = true;
            this.radioButtonDCNo.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDCNo.Location = new System.Drawing.Point(73, 107);
            this.radioButtonDCNo.Name = "radioButtonDCNo";
            this.radioButtonDCNo.Size = new System.Drawing.Size(138, 25);
            this.radioButtonDCNo.TabIndex = 11;
            this.radioButtonDCNo.TabStop = true;
            this.radioButtonDCNo.Text = "Delivery No";
            this.radioButtonDCNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonInvoice
            // 
            this.radioButtonInvoice.AutoSize = true;
            this.radioButtonInvoice.Font = new System.Drawing.Font("Bookman Old Style", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInvoice.Location = new System.Drawing.Point(73, 67);
            this.radioButtonInvoice.Name = "radioButtonInvoice";
            this.radioButtonInvoice.Size = new System.Drawing.Size(130, 25);
            this.radioButtonInvoice.TabIndex = 10;
            this.radioButtonInvoice.TabStop = true;
            this.radioButtonInvoice.Text = "Invoice No";
            this.radioButtonInvoice.UseVisualStyleBackColor = true;
            // 
            // btnFTPdata
            // 
            this.btnFTPdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFTPdata.Font = new System.Drawing.Font("Modern No. 20", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFTPdata.Image = ((System.Drawing.Image)(resources.GetObject("btnFTPdata.Image")));
            this.btnFTPdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFTPdata.Location = new System.Drawing.Point(73, 201);
            this.btnFTPdata.Name = "btnFTPdata";
            this.btnFTPdata.Size = new System.Drawing.Size(221, 105);
            this.btnFTPdata.TabIndex = 9;
            this.btnFTPdata.Text = "Get FTP DATA";
            this.btnFTPdata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFTPdata.UseVisualStyleBackColor = true;
            this.btnFTPdata.Click += new System.EventHandler(this.btnFTPdata_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 12;
            // 
            // txtResultBox
            // 
            this.txtResultBox.Font = new System.Drawing.Font("Times New Roman", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBox.Location = new System.Drawing.Point(374, 76);
            this.txtResultBox.Multiline = true;
            this.txtResultBox.Name = "txtResultBox";
            this.txtResultBox.Size = new System.Drawing.Size(477, 346);
            this.txtResultBox.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.841726F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFTPstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtResultBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButtonDCNo);
            this.Controls.Add(this.radioButtonInvoice);
            this.Controls.Add(this.btnFTPdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFTPstatus";
            this.Text = "FTP DATA Search";
            this.Load += new System.EventHandler(this.frmFTPstatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDCNo;
        private System.Windows.Forms.RadioButton radioButtonInvoice;
        private System.Windows.Forms.Button btnFTPdata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtResultBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;

    }
}