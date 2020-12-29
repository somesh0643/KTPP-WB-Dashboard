using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiloReports
{
    public partial class frmLiveDataDashboard : Form
    {
        public frmLiveDataDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            cmbProduct.SelectedIndex = 0;
            lblHeader.Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Visible = false;
          // dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times", 9F, FontStyle.Bold);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            dateTimePicker1.Value = DateTime.Today;
        
        }

        private void frmLiveDataDashboard_Load(object sender, EventArgs e)
        {
            radioButtonTotal.Checked = true;
            btnFTPstatus.Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLiveDashboard_Click(object sender, EventArgs e)
        {
            btnLiveDashboard.Enabled = false;
            radioButtonTotal.Enabled = false;
            radioButtonToday.Enabled = false;
            cmbProduct.Enabled = false;
            dateTimePicker1.Enabled = false;

            lblHeader.Text = "List of "+cmbProduct.Text+" Vehicles whose Second Weighment is Yet to be Done";
            lblHeader.Visible = true;
            string sqlQuery = "";
            string productCode="";
            string indateFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            
            if(cmbProduct.SelectedIndex==0)
            {
                productCode = "17";
            }
            else if(cmbProduct.SelectedIndex==1)
            {
                productCode = "1";
            }
            else if(cmbProduct.SelectedIndex==2)
            {
                productCode = "8";
            }
            else
            {
                //do notting
            }
            
            
            
            if (radioButtonTotal.Checked==true)
            {
                sqlQuery = "select * from weighment,Supplier_master where weighment.supcode=Supplier_master.supcode and weighment.prodcode='" + productCode
                           +"' and weighment.outdate is NULL order by weighment.indate asc";
            }
            else if (radioButtonToday.Checked==true)
            {
                sqlQuery = "select * from weighment,Supplier_master where weighment.supcode=Supplier_master.supcode and weighment.prodcode='" + productCode
                            + "' and weighment.indate>='"+indateFrom+"' and weighment.outdate is NULL order by weighment.indate asc";
            
            }
            else
            {
                //do notting
            }

            DBmanager dbm = new DBmanager();
            DataTable dtaTable = new DataTable();
            dtaTable = dbm.fetchDataFromDatabase(sqlQuery);
            dtaTable.Columns.Add("timeElapsed", typeof(System.String));
            for (int i = 0; i < dtaTable.Rows.Count;i++)
            {
                DateTime InTimeStamp = Convert.ToDateTime(dtaTable.Rows[i]["indate"].ToString());
               
                TimeSpan difference = DateTime.Now - InTimeStamp;

                ulong elapsedMinutes = (ulong)difference.TotalMinutes;
                ulong Days;
                ulong Hours;
                ulong Minutes;
                Days=elapsedMinutes/(24*60);
                Hours=(elapsedMinutes%(24*60))/60;
                Minutes=((elapsedMinutes%(24*60))%60);




                dtaTable.Rows[i]["timeElapsed"] = Days + " Days - " + Hours.ToString("00") + " Hrs - " + Minutes.ToString("00") + " Min";
            }

            //Clearing DataGridView

           // dataGridView1.DataSource = null;
           // dataGridView1.Rows.Clear();
            
            dataGridView1.Refresh();

            //Set AutoGenerateColumns False
            dataGridView1.AutoGenerateColumns = false;

            //Set Columns Count
            dataGridView1.ColumnCount = 11;

            
            /*dataGridView1.Columns[1].DataPropertyName = "srno";
            dataGridView1.Columns[2].DataPropertyName = "vehicleno";*/
            dataGridView1.DataSource = dtaTable;
            dataGridView1.ReadOnly = true;
        }

        private void radioButtonToday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToday.Checked == true)
            {
                dateTimePicker1.Visible = true;
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void radioButtonTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonToday.Checked == false)
            {
                dateTimePicker1.Visible = false;
            }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == 2)
            {
                radioButtonToday.Checked = true;
                dateTimePicker1.Visible = true;
                btnFTPstatus.Visible = true;
            }
            else
            {
                btnFTPstatus.Visible = false;
            }
        }

        private void btnFTPstatus_Click(object sender, EventArgs e)
        {
            frmFTPstatus FTPstatus = new frmFTPstatus();
            FTPstatus.ShowDialog();
        }

        

       
    }
}
