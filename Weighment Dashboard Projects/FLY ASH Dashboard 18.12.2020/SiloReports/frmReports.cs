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
    public partial class frmReports : Form
    {
        DBmanager dbManage = new DBmanager();
        string fromDate = "";
        string toDate = "";

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
            
            lblUserInfo.Visible = false;
            radioButtonOUT.Checked = true;
            lblTrxnSource.Visible = false;
            cmbTrxnSource.Visible = false;
            cmbTrxnSource.SelectedIndex = 0;
            cmbProduct.SelectedIndex = 1;
            cmbProduct.Enabled = false;
           

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            lblUserInfo.Visible = true;
            lblUserInfo.Text = "Please Wait"+Environment.NewLine+"System is Generating the Excel Sheet in Background.....";
            btnExportToExcel.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            cmbProduct.Enabled = false;
            radioButtonIN.Enabled = false;
            radioButtonOUT.Enabled = false;
            cmbTrxnSource.Enabled = false;
            string product = "";

            if(cmbProduct.SelectedIndex==0)
            {
                product="17";
                cmbTrxnSource.SelectedIndex = 0;
            }
            else if(cmbProduct.SelectedIndex==1)
            {
                 product="1";
                 cmbTrxnSource.SelectedIndex = 0;
            }
            else if (cmbProduct.SelectedIndex == 2)
            {
                product = "8";
                
            }
            else
            {
                //Do notting
            }

            fromDate = dateTimePicker1.Value.ToString("dd MMMM yyyy HH:mm tt");
           
            if (dateTimePicker2.Value.Date > DateTime.Today.Date)
            {
                toDate = DateTime.Now.ToString("dd MMMM yyyy HH:mm tt");
            }
            else
            {
                toDate = dateTimePicker2.Value.ToString("dd MMMM yyyy HH:mm tt");
                //toDate = dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss.fff");
            }

            //------Query Selection code----------------------------------
            string sqlQuery = "";

            if(cmbTrxnSource.SelectedIndex==0){

                    if(radioButtonOUT.Checked==true)
                    {
                        sqlQuery = "select Weighment.srno,Weighment.vehicleno,Weighment.supcode,Supplier_master.supplier,Weighment.prodcode," +
                                                   "Weighment.indate,	Weighment.intime,	Weighment.outdate, Weighment.outtime, Weighment.firstweight, Weighment.secondweight, Weighment.netweight,	Weighment.remarks, Weighment.unit" +
                                                   " from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" +
                                                     dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + product + "  order by weighment.intime asc";
                    }

            
                    if (radioButtonIN.Checked == true)
                    {
                        sqlQuery = "select Weighment.srno,Weighment.vehicleno,Weighment.supcode,Supplier_master.supplier,Weighment.prodcode," +
                                                   "Weighment.indate,	Weighment.intime,	Weighment.outdate, Weighment.outtime, Weighment.firstweight, Weighment.secondweight, Weighment.netweight,	Weighment.remarks, Weighment.unit" +
                                                   " from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.indate between '" +
                                                     dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + product + "  order by weighment.intime asc";
                    }

            }
            else if (cmbTrxnSource.SelectedIndex == 1)
            {

                if (radioButtonOUT.Checked == true)
                {
                    sqlQuery = "select Weighment.srno,Weighment.vehicleno,Weighment.supcode,Supplier_master.supplier,Weighment.prodcode," +
                                               "Weighment.indate,	Weighment.intime,	Weighment.outdate, Weighment.outtime, Weighment.firstweight, Weighment.secondweight, Weighment.netweight,	Weighment.remarks, Weighment.unit" +
                                               ",SECURITY_CHECK.S_INTIME,SECURITY_CHECK.S_OUTTIME,SECURITY_CHECK.REMARKS_IN,SECURITY_CHECK.REMARKS_OUT"+
                                               " from Weighment,Supplier_master,SECURITY_CHECK where SECURITY_CHECK.SRNO=Weighment.srno and Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" +
                                                 dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + product + "  order by weighment.intime asc";
                }


                if (radioButtonIN.Checked == true)
                {
                    sqlQuery = "select Weighment.srno,Weighment.vehicleno,Weighment.supcode,Supplier_master.supplier,Weighment.prodcode," +
                                               "Weighment.indate,	Weighment.intime,	Weighment.outdate, Weighment.outtime, Weighment.firstweight, Weighment.secondweight, Weighment.netweight,	Weighment.remarks, Weighment.unit" +
                                               ",SECURITY_CHECK.S_INTIME,SECURITY_CHECK.S_OUTTIME,SECURITY_CHECK.REMARKS_IN,SECURITY_CHECK.REMARKS_OUT" +
                                               " from Weighment,Supplier_master,SECURITY_CHECK where SECURITY_CHECK.SRNO=Weighment.srno and Supplier_master.supcode=Weighment.supcode and  weighment.indate between '" +
                                                 dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + product + "  order by weighment.intime asc";
                }
            }
            else
            {
                ///---do Notting--------
            }
            //----------------------------------------------------------------
            
            DataTable dtaTable = new DataTable();
            dtaTable = dbManage.fetchDataFromDatabase(sqlQuery);

            
                        // creating Excel Application  
                        Microsoft.Office.Interop.Excel._Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                        // creating new WorkBook within Excel application  
                        Microsoft.Office.Interop.Excel._Workbook workbook = ExcelApp.Workbooks.Add(Type.Missing);
                        // creating new Excelsheet in workbook  
                        Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                        
                        // get the reference of first sheet. By default its name is Sheet1.  
                        // store its reference to worksheet  
                        worksheet = workbook.Sheets["Sheet1"];
                        worksheet = workbook.ActiveSheet;
                        // changing the name of active sheet  
                        worksheet.Name = "Weighment TRXN Report";

                        if (cmbTrxnSource.SelectedIndex == 0)
                        {
                            // Heading Part part Formatting in Excel
                            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 15]].Merge();
                            worksheet.Cells[1, 1].Font.Bold = true;
                            worksheet.Cells[1, 1].Font.Name = "Times";
                            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            worksheet.Cells[1, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                            worksheet.Cells[1, 1].Font.Size = 12;
                            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 15]].Interior.Color = Color.Aquamarine;
                            worksheet.Range["A1", "O" + ((dtaTable.Rows.Count) + 2).ToString()].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;
                            worksheet.Range["A1", "O" + ((dtaTable.Rows.Count) + 2).ToString()].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                            worksheet.Rows[1].RowHeight = 40;

                            // storing header part in Excel 
                            string excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " from " + fromDate.ToString() + " to " + toDate.ToString() + ".";
                            if (dateTimePicker1.Value == DateTime.Today)
                            {
                                excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " as on " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ".";

                            }
                            worksheet.Cells[1, 1] = excelHeader;


                            //Column Names formatting 
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].Font.Bold = true;
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].Font.Name = "Times";
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].Font.Size = 10;
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].WrapText = true;
                            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].Interior.Color = Color.Bisque;

                            worksheet.Cells[2, 1] = "S.NO";
                            worksheet.Cells[2, 2] = "SRNO";
                            worksheet.Cells[2, 3] = "Vehicle NO";
                            worksheet.Cells[2, 4] = "Supplier Code";
                            worksheet.Cells[2, 5] = "Supplier Name";
                            worksheet.Cells[2, 6] = "Product Code";
                            worksheet.Cells[2, 7] = "IN Date";
                            worksheet.Cells[2, 8] = "IN Time";
                            worksheet.Cells[2, 9] = "OUT Date";
                            worksheet.Cells[2, 10] = "OUT Time";
                            worksheet.Cells[2, 11] = "First Weight";
                            worksheet.Cells[2, 12] = "Second Weight";
                            worksheet.Cells[2, 13] = "Net Weight";
                            worksheet.Cells[2, 14] = "Remarks";
                            worksheet.Cells[2, 15] = "Location";

                            worksheet.Columns[1].ColumnWidth = 5;
                            worksheet.Columns[2].ColumnWidth = 8;
                            worksheet.Columns[3].ColumnWidth = 12;
                            worksheet.Columns[4].ColumnWidth = 8;
                            worksheet.Columns[5].ColumnWidth = 25;
                            worksheet.Columns[6].ColumnWidth = 8;
                            worksheet.Columns[7].ColumnWidth = 15;
                            worksheet.Columns[8].ColumnWidth = 15;
                            worksheet.Columns[9].ColumnWidth = 15;
                            worksheet.Columns[10].ColumnWidth = 15;
                            worksheet.Columns[11].ColumnWidth = 7;
                            worksheet.Columns[12].ColumnWidth = 7;
                            worksheet.Columns[13].ColumnWidth = 7;
                            worksheet.Columns[14].ColumnWidth = 7;
                            worksheet.Columns[15].ColumnWidth = 15;

                            worksheet.Range["G3", "G" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mmmm-yyyy";
                            worksheet.Range["I3", "I" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mmmm-yyyy";
                            worksheet.Range["H3", "H" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "HH:mm:ss";
                            worksheet.Range["J3", "J" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "HH:mm:ss";


                            // storing Each row and column value to excel sheet  
                            for (int i = 0; i < dtaTable.Rows.Count; i++)
                            {
                                worksheet.Cells[i + 3, 1] = i + 1;

                                for (int j = 0; j < dtaTable.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 3, j + 2] = dtaTable.Rows[i][j].ToString();
                                }
                            }
                     }

                       if(cmbTrxnSource.SelectedIndex==1)
                       {

                           // Heading Part part Formatting in Excel
                           worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 19]].Merge();
                           worksheet.Cells[1, 1].Font.Bold = true;
                           worksheet.Cells[1, 1].Font.Name = "Times";
                           worksheet.Rows[1].RowHeight = 40;
                           //worksheet.Range["A3", "S" + ((dtaTable.Rows.Count) + 2).ToString()].RowHeight=30; 
                           worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                           worksheet.Cells[1, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                           worksheet.Cells[1, 1].Font.Size = 12;
                           worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 19]].Interior.Color = Color.Aquamarine;
                           worksheet.Range["A1", "S" + ((dtaTable.Rows.Count) + 2).ToString()].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;
                           worksheet.Range["A1", "S" + ((dtaTable.Rows.Count) + 2).ToString()].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                           worksheet.Range["A1", "S" + ((dtaTable.Rows.Count) + 2).ToString()].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                           

                           // storing header part in Excel 
                           string excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " from " + fromDate.ToString() + " to " + toDate.ToString() + ".";
                           if (dateTimePicker1.Value == DateTime.Today)
                           {
                               excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " as on " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + ".";

                           }
                           worksheet.Cells[1, 1] = excelHeader;


                           //Column Names formatting 
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].Font.Bold = true;
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].Font.Name = "Times";
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].Font.Size = 10;
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 19]].WrapText = true;
                           worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 15]].Interior.Color = Color.Bisque;
                           worksheet.Range[worksheet.Cells[2, 16], worksheet.Cells[2, 19]].Interior.Color = Color.BlueViolet;

                           worksheet.Cells[2, 1] = "S.NO";
                           worksheet.Cells[2, 2] = "SRNO";
                           worksheet.Cells[2, 3] = "Vehicle NO";
                           worksheet.Cells[2, 4] = "Supplier Code";
                           worksheet.Cells[2, 5] = "Supplier Name";
                           worksheet.Cells[2, 6] = "Product Code";
                           worksheet.Cells[2, 7] = "IN Date";
                           worksheet.Cells[2, 8] = "IN Time";
                           worksheet.Cells[2, 9] = "OUT Date";
                           worksheet.Cells[2, 10] = "OUT Time";
                           worksheet.Cells[2, 11] = "First Weight";
                           worksheet.Cells[2, 12] = "Second Weight";
                           worksheet.Cells[2, 13] = "Net Weight";
                           worksheet.Cells[2, 14] = "Remarks";
                           worksheet.Cells[2, 15] = "Location";

                           worksheet.Cells[2, 16] = "Security Check IN Time";
                           worksheet.Cells[2, 17] = "Security Check OUT Time";
                           worksheet.Cells[2, 18] = "Security Check IN Remarks";
                           worksheet.Cells[2, 19] = "Security Check OUT Remarks";

                           worksheet.Columns[1].ColumnWidth = 5;
                           worksheet.Columns[2].ColumnWidth = 8;
                           worksheet.Columns[3].ColumnWidth = 12;
                           worksheet.Columns[4].ColumnWidth = 8;
                           worksheet.Columns[5].ColumnWidth = 25;
                           worksheet.Columns[6].ColumnWidth = 8;
                           worksheet.Columns[7].ColumnWidth = 15;
                           worksheet.Columns[8].ColumnWidth = 15;
                           worksheet.Columns[9].ColumnWidth = 15;
                           worksheet.Columns[10].ColumnWidth = 15;
                           worksheet.Columns[11].ColumnWidth = 7;
                           worksheet.Columns[12].ColumnWidth = 7;
                           worksheet.Columns[13].ColumnWidth = 7;
                           worksheet.Columns[14].ColumnWidth = 7;
                           worksheet.Columns[15].ColumnWidth = 15;

                           worksheet.Columns[16].ColumnWidth = 15;
                           worksheet.Columns[17].ColumnWidth = 15;
                           worksheet.Columns[18].ColumnWidth = 15;
                           worksheet.Columns[19].ColumnWidth = 15;

                           worksheet.Range["G3", "G" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mmmm-yyyy";
                           worksheet.Range["I3", "I" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mmmm-yyyy";
                           worksheet.Range["H3", "H" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "HH:mm:ss";
                           worksheet.Range["J3", "J" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "HH:mm:ss";


                           worksheet.Range["P3", "P" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mm-yyyy HH:mm:ss";
                           worksheet.Range["Q3", "Q" + ((dtaTable.Rows.Count) + 2).ToString()].NumberFormat = "dd-mm-yyyy HH:mm:ss";
                          

                           // storing Each row and column value to excel sheet  
                           for (int i = 0; i < dtaTable.Rows.Count; i++)
                           {
                               worksheet.Cells[i + 3, 1] = i + 1;

                               for (int j = 0; j < dtaTable.Columns.Count; j++)
                               {
                                   worksheet.Cells[i + 3, j + 2] = dtaTable.Rows[i][j].ToString();
                               }
                           }



                       }
                




             /* 
                        worksheet.Range[worksheet.Cells[dataGridView1.Rows.Count + 3, 1], worksheet.Cells[dataGridView1.Rows.Count + 3, 4]].Merge();
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Bold = true;
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Name = "Times";
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Size = 12;
                        worksheet.Rows[dataGridView1.Rows.Count + 3].RowHeight = 30;
                        worksheet.Cells[dataGridView1.Rows.Count + 3, 1] = "Total Tonnage in Metric Tonnes :" + txtTotalTonnage.Text;
                        
              */    string root = @"D:\Weighment Reports";
                        // If directory does not exist, create it. 
                        if (!System.IO.Directory.Exists(root))
                        {
                            System.IO.Directory.CreateDirectory(root);
                        }
                        
            
            
                       
                        // save the application  
                        workbook.SaveAs("D:\\Weighment Reports\\"+cmbProduct.Text+ " Report "+ DateTime.Now.ToString("dd MMMM yyyy HHmmss").ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                        // see the excel sheet behind the program  
                        ExcelApp.Visible = true;
            // ExcelApp.Quit();
                        releaseObject(ExcelApp);
                        releaseObject(workbook);
                        releaseObject(worksheet);
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
            lblUserInfo.Visible = false;
            radioButtonOUT.Checked = true;
            
            radioButtonIN.Enabled = true;
            radioButtonOUT.Enabled = true;

            lblTrxnSource.Visible = false;
            cmbTrxnSource.Visible = false;
            cmbTrxnSource.SelectedIndex = 0;
            cmbProduct.SelectedIndex = 1;
            cmbProduct.Enabled = false;

            
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProduct.SelectedIndex==2){
                    lblTrxnSource.Visible = true;
                    cmbTrxnSource.Visible = true;
                    cmbTrxnSource.SelectedIndex = 0;
                 }
            else if (cmbProduct.SelectedIndex == 0 || cmbProduct.SelectedIndex == 1)
            {
                lblTrxnSource.Visible = false;
                cmbTrxnSource.Visible = false;
                cmbTrxnSource.SelectedIndex = 0;
            }
             
            else
            {
                ///----do notting---------
            }
            

        }
    }
}
