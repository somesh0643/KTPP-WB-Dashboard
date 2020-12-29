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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

       

       

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports fobj = new frmReports();
            fobj.ShowDialog();
        }

        private void btnSummaryDashboard_Click(object sender, EventArgs e)
        {
            Form1 fobj = new Form1();
            fobj.ShowDialog();
        }

        private void btnLiveDashboard_Click(object sender, EventArgs e)
        {
            frmLiveDataDashboard fobj = new frmLiveDataDashboard();
            fobj.ShowDialog();
        }
    }
}
