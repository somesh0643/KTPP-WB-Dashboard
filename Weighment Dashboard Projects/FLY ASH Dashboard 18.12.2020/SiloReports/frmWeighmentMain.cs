using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SiloReports
{
    public partial class Form1 : Form
    {
        DBmanager dbManage = new DBmanager();
        public string sqlQuery = "";
        public string totalTonnageSqlQuery = "";
        DataTable dtaTable = new DataTable();



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnExportToExcel.Enabled = false;
            cmbProduct.SelectedIndex = 1;
            cmbProduct.Enabled = false;
           
            
            cmbLocation.Enabled = true;
            cmbLocation.SelectedIndex = 0;
            lblWeighmentHeader.Visible = false;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);



        }

        private void btnFetchRecords_Click(object sender, EventArgs e)
        {

            if (cmbProduct.SelectedIndex == 1 && cmbLocation.Text == "KTPP ASH POND")
            {
                MessageBox.Show("You have selected invalid Location for the selected product \n Please Select the Correct Location", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            btnExportToExcel.Enabled = true;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

            string fromDate = dateTimePicker1.Value.ToString("dd MMMM yyyy HH:mm tt");
            string toDate = "";
            if (dateTimePicker2.Value.Date > DateTime.Today.Date)
            {
                toDate = DateTime.Now.ToString("dd MMMM yyyy HH:mm tt");
            }
            else
            {
                toDate = dateTimePicker2.Value.ToString("dd MMMM yyyy HH:mm tt");
                //toDate = dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss.fff");
            }
            string ProductCode = "1";
            dataGridView1.DataSource = null;
            
            lblWeighmentHeader.Text = "Weighment Summary Report of " + cmbProduct.Text.ToString() + " from " + fromDate + " to " + toDate + "";
            if (dateTimePicker1.Value.Date == DateTime.Today)
            {
                lblWeighmentHeader.Text = "Weighment Transaction Report of " + cmbProduct.Text + " as on " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " till " + DateTime.Now.ToShortTimeString() + ".";

            }

            if (dateTimePicker1.Value != DateTime.Today && dateTimePicker2.Value > DateTime.Today)
            {
                lblWeighmentHeader.Text = "Weighment Transaction Report of " + cmbProduct.Text + " from " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " to " + DateTime.Now.ToString("dd MMMM yyyy hh:mm tt") + ".";

            }

            lblWeighmentHeader.Visible = Enabled;

            if (cmbProduct.SelectedIndex == 0)
            {
                ProductCode = "17";
                sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips,Weighment.unit from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + " group by weighment.unit,weighment.supcode,Supplier_master.supplier order by weighment.unit,weighment.supcode";
                totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + "";

            }
            else if (cmbProduct.SelectedIndex == 1 && cmbLocation.SelectedIndex == 0)
            {
                ProductCode = "1";
                sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips,Weighment.unit from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + " and weighment.unit ='KTPP Stage-I' group by weighment.unit,weighment.supcode,Supplier_master.supplier order by weighment.unit,weighment.supcode";
                totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + "and weighment.unit = 'KTPP Stage-I' ";

            }
            else if (cmbProduct.SelectedIndex == 1 && cmbLocation.SelectedIndex == 1)
            {
                ProductCode = "1";
                sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips,Weighment.unit from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + " and weighment.unit ='KTPP Stage-II' group by weighment.unit,weighment.supcode,Supplier_master.supplier order by weighment.unit,weighment.supcode";
                totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + "and weighment.unit = 'KTPP Stage-II'";

            }
            else if (cmbProduct.SelectedIndex == 1 && cmbLocation.SelectedIndex == 2)
            {
                ProductCode = "1";
                sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + " group by weighment.supcode,Supplier_master.supplier order by weighment.supcode";
                totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + "";

            }
            else if (cmbProduct.SelectedIndex == 2)
            {
                ProductCode = "8";
                sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips,weighment.unit from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + " group by weighment.supcode,Supplier_master.supplier,weighment.unit order by weighment.supcode";
                totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "' and prodcode=" + ProductCode + "";

            }
            else
            {
                //Notting to do
            }
            // sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips,Weighment.unit from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + ProductCode + " group by weighment.unit,weighment.supcode,Supplier_master.supplier order by weighment.unit,weighment.supcode";
            // sqlQuery = "select Weighment.supcode,Supplier_master.supplier,ROUND((SUM(weighment.netweight)/1000),2) Total_Tonnage,COUNT(Weighment.supcode) Total_trips from Weighment,Supplier_master where Supplier_master.supcode=Weighment.supcode and  weighment.outdate between '" + dateTimePicker1.Value.ToString() + "' and '" + dateTimePicker2.Value.ToString() + "' and prodcode=" + ProductCode + " group by weighment.supcode,Supplier_master.supplier order by weighment.supcode";
            //totalTonnageSqlQuery = "select ROUND((SUM(weighment.netweight)/1000),3) Total_Tonnage from Weighment where  weighment.outdate between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.fff") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss.fff") + "' and prodcode=" + ProductCode + "";

            dtaTable = dbManage.fetchDataFromDatabase(sqlQuery);
            dataGridView1.DataSource = dtaTable;

            txtTotalTonnage.Text = dbManage.fetchTotalTonnage(totalTonnageSqlQuery);
            btnFetchRecords.Enabled = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
            // dateTimePicker2.MaxDate = dateTimePicker2.MaxDate.AddMinutes(59 - DateTime.Now.Minute);


        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);

            cmbProduct.SelectedIndex = 1;
            cmbProduct.Enabled = false;
            cmbLocation.Enabled = true;
            cmbLocation.SelectedIndex = 0;

            
            
            btnExportToExcel.Enabled = false;

            lblWeighmentHeader.Visible = false;
            btnFetchRecords.Enabled = true;
            dataGridView1.Rows.Clear();

        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
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
            worksheet.Name = "Weighment Report";
            // storing Heading Part part in Excel
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Merge();
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Interior.ColorIndex = 37;
            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 6]].Interior.ColorIndex = 36;


            // workSheet.Range("a2:n2").Interior.ColorIndex = 36;
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].Font.Name = "Times";
            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[1, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            worksheet.Cells[1, 1].Font.Size = 12;
            worksheet.Columns[1].ColumnWidth = 5;
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 45;
            worksheet.Columns[4].ColumnWidth = 20;
            worksheet.Columns[5].ColumnWidth = 15;
            worksheet.Columns[6].ColumnWidth = 20;
            worksheet.Rows[1].RowHeight = 30;



            // storing header part in Excel 
            string excelHeader = lblWeighmentHeader.Text;
            if (dateTimePicker1.Value == DateTime.Today)
            {
                excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " as on " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " till " + DateTime.Now.ToShortTimeString() + ".";
                lblWeighmentHeader.Text = "Weighment Transaction Report of " + cmbProduct.Text + " as on " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " till " + DateTime.Now.ToShortTimeString() + ".";

            }

            if (dateTimePicker1.Value != DateTime.Today && dateTimePicker2.Value > DateTime.Today)
            {
                excelHeader = "Weighment Transaction Report of " + cmbProduct.Text + " from " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " to " + DateTime.Now.ToString("dd MMMM yyyy hh:mm tt") + ".";
                lblWeighmentHeader.Text = "Weighment Transaction Report of " + cmbProduct.Text + " from " + dateTimePicker1.Value.ToString("dd MMMM yyyy") + " to " + DateTime.Now.ToString("dd MMMM yyyy hh:mm tt") + ".";

            }

            worksheet.Cells[1, 1] = excelHeader;


            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[2, i] = dataGridView1.Columns[i - 1].HeaderText;
                worksheet.Cells[2, i].Font.Bold = true;
            }

            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtaTable.Rows.Count; i++)
            {
                worksheet.Cells[i + 3, 1] = i + 1;

                for (int j = 0; j < dtaTable.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 2] = dtaTable.Rows[i][j].ToString();
                }
            }

            ////--------Assigning Borders arouns the cells-----------------------------

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick);
            //worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Merge();
            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Interior.Color = Color.Aquamarine; ;

            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;
            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;
            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;
            worksheet.Range[worksheet.Cells[dtaTable.Rows.Count + 3, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; ;

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeTop].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[dtaTable.Rows.Count + 3, 1]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[2, 2], worksheet.Cells[dtaTable.Rows.Count + 3, 2]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[2, 3], worksheet.Cells[dtaTable.Rows.Count + 3, 3]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[2, 4], worksheet.Cells[dtaTable.Rows.Count + 3, 4]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[2, 5], worksheet.Cells[dtaTable.Rows.Count + 3, 5]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            worksheet.Range[worksheet.Cells[2, 6], worksheet.Cells[dtaTable.Rows.Count + 3, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeRight].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 6]].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;


            ///-------------------------------------------------------------------------------------------


            worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Bold = true;
            worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Name = "Times";
            worksheet.Cells[dataGridView1.Rows.Count + 3, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[dataGridView1.Rows.Count + 3, 1].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            worksheet.Cells[dataGridView1.Rows.Count + 3, 1].Font.Size = 12;
            worksheet.Rows[dataGridView1.Rows.Count + 3].RowHeight = 30;
            worksheet.Cells[dataGridView1.Rows.Count + 3, 1] = "Total Tonnage in Metric Tonnes :" + txtTotalTonnage.Text;

            // see the excel sheet behind the program  
            ExcelApp.Visible = true;

            string root = @"D:\Weighment Reports";
            // If directory does not exist, create it. 
            if (!System.IO.Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            // save the application  
            workbook.SaveAs("D:\\Weighment Reports\\Weighment Report " + DateTime.Now.ToString("dd MMMM yyyy HHmmss").ToString() + ".xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // ExcelApp.Quit();
            releaseObject(ExcelApp);
            releaseObject(workbook);
            releaseObject(worksheet);
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

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
        }

        private void dateTimePicker2_DropDown(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value.AddDays(1);
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(1);
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex == 1)
            {
                cmbLocation.Enabled = true;
                cmbLocation.SelectedIndex = 0;
            }

            if (cmbProduct.SelectedIndex == 0)
            {

                cmbLocation.Text = "KTPP ASH POND";
                cmbLocation.Enabled = false;
            }


            if (cmbProduct.SelectedIndex == 2)
            {

                cmbLocation.Text = "All Mine Locations";
                cmbLocation.Enabled = false;
            }

        }

        private void cmbProduct_Leave(object sender, EventArgs e)
        {

        }



    }
}
