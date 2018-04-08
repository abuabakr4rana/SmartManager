using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartManger_V._1_.Attendance;

namespace SmartManger_V._1_.Reports
{
    public partial class RepportViewer1 : Form
    {
        int index = 1;
        public RepportViewer1(int selection)
        {
            InitializeComponent();
            index = selection;
        }

        public RepportViewer1()
        {
            InitializeComponent();
        }

        private void RepportViewer1_Load(object sender, EventArgs e)
        {
            FillEmployeeList();
            dtpStart.CustomFormat = dtpEnd.CustomFormat = "dd,MMMM,yyyy";
            dtpStart.Text = (Salary.SalaryList.FirstOfMonth(DateTime.Now)).ToString();
            dtpEnd.Text = (Salary.SalaryList.LastOfMonth(DateTime.Now)).ToString();
            if (index == 1)
            {
                rdbAttendance.Checked = true;
                rdbSalary.Enabled = false;
            }
            else
            {
                rdbSalary.Checked = true;
                rdbAttendance.Enabled = false;
            }
        }
        private void FillEmployeeList()
        {
            dsAttendance ds = new dsAttendance();
            Attendance.dsAttendanceTableAdapters.vEmployeeComboTableAdapter taAttendance = new Attendance.dsAttendanceTableAdapters.vEmployeeComboTableAdapter();
            taAttendance.Fill(ds.vEmployeeCombo);
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.DataSource = ds.vEmployeeCombo.DefaultView;
            cmbEmployee.SelectedIndex = -1;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (rdbAttendance.Checked)
            {
                try
                {
                    rptAttendance AttendanceReport = new rptAttendance();
                    dsReport ds = new dsReport();
                    dsReportTableAdapters.vAttendanceListTableAdapter taEmployee = new dsReportTableAdapters.vAttendanceListTableAdapter();
                    if (cmbEmployee.SelectedIndex == -1)
                    {
                        taEmployee.Fill(ds.vAttendanceList, 0, dtpStart.Text, dtpEnd.Text);
                    }
                    else
                        taEmployee.Fill(ds.vAttendanceList, Convert.ToInt32(cmbEmployee.SelectedValue), dtpStart.Text, dtpEnd.Text);

                    AttendanceReport.SetDataSource(ds);
                    Cursor = Cursors.WaitCursor;
                    this.crystalReportViewer1.ReportSource = AttendanceReport;
                    this.crystalReportViewer1.RefreshReport();
                    Cursor = Cursors.Default;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    
                    rptSalaryList SalaryReport = new rptSalaryList();
                    dsReport ds = new dsReport();
                    dsReportTableAdapters.rSalaryListTableAdapter taSalary = new dsReportTableAdapters.rSalaryListTableAdapter();
                    if (cmbEmployee.SelectedIndex == -1)
                    {
                        taSalary.Fill(ds.rSalaryList,dtpStart.Text,dtpEnd.Text,0);
                    }
                    else
                        taSalary.Fill(ds.rSalaryList,dtpStart.Text,dtpEnd.Text,Convert.ToInt32(cmbEmployee.SelectedValue));
                    SalaryReport.SetDataSource(ds);
                    Cursor = Cursors.WaitCursor;
                    this.crystalReportViewer1.ReportSource = SalaryReport;
                    this.crystalReportViewer1.RefreshReport();
                    Cursor = Cursors.Default;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
