using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using SmartManger_V._1_.HRManger;

namespace SmartManger_V._1_.Reports
{
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeList EmployeReport = new EmployeeList();
                dsReport ds = new dsReport();
                dsReportTableAdapters.rEmployeeListTableAdapter taEmployee = new dsReportTableAdapters.rEmployeeListTableAdapter();
                taEmployee.Fill(ds.rEmployeeList);
                EmployeReport.SetDataSource(ds);
                Cursor = Cursors.WaitCursor;
                this.crystalReportViewer1.ReportSource = EmployeReport;
                this.crystalReportViewer1.RefreshReport();
                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
