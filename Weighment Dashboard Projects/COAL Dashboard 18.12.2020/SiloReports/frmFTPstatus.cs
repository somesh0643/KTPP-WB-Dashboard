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
    public partial class frmFTPstatus : Form
    {
        public frmFTPstatus()
        {
            InitializeComponent();
        }

        

        private void frmFTPstatus_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            txtResultBox.Visible = true;
            radioButtonInvoice.Checked = true;


        }

        private void btnFTPdata_Click(object sender, EventArgs e)
        {

            radioButtonInvoice.Enabled = false;
            radioButtonDCNo.Enabled = false;
            btnFTPdata.Enabled = false;
            textBox1.Enabled = false;

            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Invoice No / DC No and Try Again","Warning Message",MessageBoxButtons.OK);
                goto endOfMethod;
            }


            string sqlQuery = "";

            if (radioButtonInvoice.Checked == true)
            {
                sqlQuery = "select * from WB_INVOICE where CINUM='" + textBox1.Text + "'";
            }
            else if (radioButtonDCNo.Checked == true)
            {
                sqlQuery = "select * from WB_INVOICE where DELNO='" + textBox1.Text + "'";
            }
            else
            {
                //do notting
            }

            DBmanager dbm = new DBmanager();
            DataTable dtaTable = new DataTable();
            dtaTable = dbm.fetchDataFromDatabase(sqlQuery);

            if (dtaTable !=null)
            {
                if (dtaTable.Rows.Count > 0)
                {
                    txtResultBox.Text = Environment.NewLine+
                                  "-----------------------------------------------------------------" + Environment.NewLine +
                                  "         COAL Vehicle Transaction FTP DATA " + Environment.NewLine +
                                  "-----------------------------------------------------------------"+Environment.NewLine+
                                  "  INVOICE NO           :      " + dtaTable.Rows[0][1].ToString() + Environment.NewLine +
                                  "  DELIVERY NO        :      " + dtaTable.Rows[0][2].ToString() + Environment.NewLine +
                                  "  DELIVERY DATE   :      " + dtaTable.Rows[0][6].ToString() + Environment.NewLine +
                                  "  DISPATCH MINE  :      " + dtaTable.Rows[0][5].ToString() + Environment.NewLine +
                                  "  VEHICLE NO          :      " + dtaTable.Rows[0][3].ToString() + Environment.NewLine +
                                  "  TOTAL Wt (MT)   :      " + dtaTable.Rows[0][4].ToString() + Environment.NewLine +
                                  "  GRADE                    :      " + dtaTable.Rows[0][7].ToString() + Environment.NewLine +
                                  Environment.NewLine+"-----------------------------------------------------------------"+Environment.NewLine+
                                                      "-----------------------------------------------------------------";
                    txtResultBox.ReadOnly = true;
                    txtResultBox.BackColor = Color.White;

                }
                else
                {
                    txtResultBox.Visible = false;
                    pictureBox1.Visible = true;
                }
                
            }




        endOfMethod: ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            pictureBox1.Visible = false;
            txtResultBox.Visible = true;


            radioButtonInvoice.Enabled = true;
            radioButtonDCNo.Enabled = true;
            radioButtonInvoice.Checked = true;
            btnFTPdata.Enabled = true;
            textBox1.Enabled = true;
        }
    }
}
