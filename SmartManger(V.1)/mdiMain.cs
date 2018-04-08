using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartManger_V._1_.HRManger;
using SmartManger_V._1_.AutoAttendance;
using SmartManger_V._1_.Salary;
using System.Configuration;
using System.Data.SqlClient;

namespace SmartManger_V._1_
{
    public partial class mdiMain : Form
    {
        int RoleId = 1;
        SqlConnection con = new SqlConnection();
        SqlCommand _cmd;
        SqlDataAdapter _sda;
        string _connectionString = ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString;

        public mdiMain(int Role)
        {
            InitializeComponent();
            RoleId = Role;
        }
        public mdiMain()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsers _loginform = new LoginUsers();
            _loginform.Show();
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(_connectionString);
                con.Open();
                _cmd = new SqlCommand("select UserName from LoginUser  where UserRole='" + RoleId +  "'", con);
                _sda = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                _sda.Fill(dt);
                label6.Text = dt.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            AssignRoles();
            label3.Text = System.DateTime.Now.ToString();
            ToolTip ttAttendance = new ToolTip();
            ttAttendance.ShowAlways = true;
            ttAttendance.SetToolTip(button1, "Attendance");
          
            ToolTip ttDepartment = new ToolTip();
            ttDepartment.ShowAlways = true;
            ttDepartment.SetToolTip(button2, "Department");

            ToolTip ttDesignation = new ToolTip();
            ttDesignation.ShowAlways = true;
            ttDesignation.SetToolTip(button4, "Designation");

            ToolTip ttEmployee = new ToolTip();
            ttEmployee.ShowAlways = true;
            ttEmployee.SetToolTip(button3, "Employee");

            ToolTip ttHoliday = new ToolTip();
            ttHoliday.ShowAlways = true;
            ttHoliday.SetToolTip(button8, "Holiday");

            ToolTip ttShift = new ToolTip();
            ttShift.ShowAlways = true;
            ttShift.SetToolTip(button7, "Shift");
            
            ToolTip ttSalary = new ToolTip();
            ttSalary.ShowAlways = true;
            ttSalary.SetToolTip(button6, "Salary");

            ToolTip ttReports = new ToolTip();
            ttReports.ShowAlways = true;
            ttReports.SetToolTip(button5, "Reports");
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department deptForm = new Department();
            deptForm.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation desgForm = new Designation();
            desgForm.Show();
        }

        private void holidaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Holidays HolidayForm = new Holidays();
            HolidayForm.Show();
        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shift ShiftForm = new Shift();
            ShiftForm.Show();
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees empForm = new Employees();
            empForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendance.AttendanceList attendanceListForm = new Attendance.AttendanceList(RoleId);
            attendanceListForm.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Department deptForm = new Department();
            deptForm.Show();
        }
      
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime currentTime = SmartManger.BAL.Common.DateNow();
            if (currentTime.ToString("HH:mm:ss") == "8:00:00")
            {
                Attendance.AttendanceList.GenerateAttendanceSheet(currentTime);
            }
            label3.Text = currentTime.ToString("HH:mm:ss");
            label1.Text = currentTime.ToString("HH");
            label2.Text = currentTime.ToString("mm");
            label5.Text = currentTime.ToString("ss");
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Designation desgForm = new Designation();
            desgForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employees empForm = new Employees();
            empForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Holidays HolidayForm = new Holidays();
            HolidayForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Shift ShiftForm = new Shift();
            ShiftForm.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryList slForm = new SalaryList();
            slForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports.ReportViewer rpt = new Reports.ReportViewer();
            rpt.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance.AttendanceForm attendanceForm = new Attendance.AttendanceForm();
            attendanceForm.Show();
            

            
        }

        private void withCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoAttendance.AutoAttendance autoForm = new AutoAttendance.AutoAttendance();
            autoForm.Show();
        }

        private void trainImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainImages trainingForm = new TrainImages();
            trainingForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SalaryList slForm = new SalaryList();
            slForm.Show();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.ReportViewer rpt = new Reports.ReportViewer();
            rpt.Show();
        }

        private void attendanceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.RepportViewer1 rptViewer = new Reports.RepportViewer1(1);
            rptViewer.Show();
        }

        private void salaryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports.RepportViewer1 rptViewer = new Reports.RepportViewer1(2);
            rptViewer.Show();
        }
        private void AssignRoles() 
        {
            if (RoleId == 2)
            {
                usersToolStripMenuItem.Enabled = false;
                attendanceToolStripMenuItem.Enabled = false;
                departmentToolStripMenuItem.Enabled = false;
                designationToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
                holidaysToolStripMenuItem.Enabled = false;
                shiftsToolStripMenuItem.Enabled = false;
                employeeListToolStripMenuItem.Enabled = false;
                attendanceListToolStripMenuItem.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                button3.Enabled = false;
                button8.Enabled = false;
                button7.Enabled = false;
                button5.Enabled = false;
            }
            else if(RoleId==3)
            {
                usersToolStripMenuItem.Enabled = false;
                button6.Enabled = false;
                salaryToolStripMenuItem.Enabled = false;
                salaryListToolStripMenuItem.Enabled = false;
                attendanceToolStripMenuItem.Enabled = false;
                
            }
            else if(RoleId==4)
            {
                usersToolStripMenuItem.Enabled = false;
            }
        }
    }
}
