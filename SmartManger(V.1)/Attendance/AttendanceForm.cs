using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartManger_V._1_.Attendance
{
    public partial class AttendanceForm : Form
    {
        public Int32 selectedRecordId = 0;
        public Int32 detailId = 0;

        public AttendanceForm(Int32 value)
        {
            InitializeComponent();
            detailId = value;
        }

        public AttendanceForm()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            Int32 rec = detailId;
            FillEmployeeList();
            gbxLeaves.Enabled = false;
            FillForm(rec);

        }

        private void FillEmployeeList()
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.vEmployeeComboTableAdapter taAttendance = new dsAttendanceTableAdapters.vEmployeeComboTableAdapter();
            taAttendance.Fill(ds.vEmployeeCombo);
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.DataSource = ds.vEmployeeCombo.DefaultView;

        }

        private void MakeEmpty()
        {
            selectedRecordId = 0;
            cmbEmployee.SelectedIndex = 0;
            dtpAttendanceDate.Value = SmartManger.BAL.Common.DateNow();
            dtpTimeIN.Value = Convert.ToDateTime("8:0:0"); ;
            dtpTimeOut.Value = Convert.ToDateTime("16:0:0");
            rdbPresent.Checked = true;
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbEmployee.SelectedValue) > 0)
            {
                detailId = Convert.ToInt32(cmbEmployee.SelectedValue);
            }


            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.vEmployeeFormTableAdapter taAttendance = new dsAttendanceTableAdapters.vEmployeeFormTableAdapter();
            taAttendance.FillByEmpId(ds.vEmployeeForm, detailId);

            var employee = ds.vEmployeeForm.NewvEmployeeFormRow();

            if (ds.vEmployeeForm.Rows.Count > 0)
            {
                employee = ds.vEmployeeForm[0];
                tbxEmployeeCode.Text = String.Format(" {0:0000}", employee.Code);
                tbxDesignation.Text = employee.DesgName;
                tbxDepartment.Text = employee.DeptName;
                tbxAnnualLeave.Text = employee.AL.ToString();
                tbxCasualLeave.Text = employee.CL.ToString();
                tbxSickLeave.Text = employee.SL.ToString();
                if (Convert.ToInt32(tbxSickLeave.Text) > 0 || Convert.ToInt32(tbxCasualLeave.Text) > 0 || Convert.ToInt32(tbxAnnualLeave.Text) > 0)
                    rdbLeave.Enabled = true;
                else
                    rdbLeave.Enabled = false;
                rdbPresent.Checked = true;
                rdbAnnual.Checked = rdbCasual.Checked = rdbSickLeave.Checked = false;


            }
        }

        private void rdbLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLeave.Checked == false)
            {
                gbxLeaves.Enabled = false;
                rdbAnnual.Checked = rdbCasual.Checked = rdbSickLeave.Checked = false;
            }
            else if (Convert.ToInt32(tbxSickLeave.Text) > 0 || Convert.ToInt32(tbxCasualLeave.Text) > 0 || Convert.ToInt32(tbxAnnualLeave.Text) > 0)
            {
                gbxLeaves.Enabled = true;
                if (Convert.ToInt32(tbxAnnualLeave.Text) > 0)
                    rdbAnnual.Enabled = true;
                if (Convert.ToInt32(tbxCasualLeave.Text) > 0)
                    rdbCasual.Enabled = true;
                if (Convert.ToInt32(tbxSickLeave.Text) > 0)
                    rdbSickLeave.Enabled = true;
                if (rdbAnnual.Enabled)
                    rdbAnnual.Checked = true;
                else if (rdbCasual.Enabled)
                    rdbCasual.Checked = true;
                else
                    rdbSickLeave.Checked = true;

            }
            else
            {
                gbxLeaves.Enabled = false;
                rdbLeave.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MakeEmpty();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MarkAttendance(detailId,Convert.ToDateTime(dtpAttendanceDate.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillForm(Int32 recordid)
        {
            if (recordid == 0)
                MakeEmpty();
            else
            {
                dsAttendance ds = new dsAttendance();
                dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
                taAttendanceDetail.FillById(ds.AttendanceDetail, recordid);
                var attendaceDetail = ds.AttendanceDetail.NewAttendanceDetailRow();

                if (ds.AttendanceDetail.Rows.Count > 0)
                {
                    attendaceDetail = ds.AttendanceDetail[0];
                    dtpAttendanceDate.Enabled = false;
                    cmbEmployee.Enabled = false;
                    cmbEmployee.SelectedValue = attendaceDetail.EmployeeId;
                    if (attendaceDetail.Status == 0)
                        rdbAbsent.Checked = true;
                    else if (attendaceDetail.Status == 1)
                        rdbPresent.Checked = true;
                    else if (attendaceDetail.Status == 2)
                    {
                        rdbLeave.Checked = true;
                        rdbAnnual.Checked = true;
                    }
                    else if (attendaceDetail.Status == 3)
                    {
                        rdbLeave.Checked = true;
                        rdbCasual.Checked = true;
                    }
                    else if (attendaceDetail.Status == 4)
                    {
                        rdbLeave.Checked = true;
                        rdbSickLeave.Checked = true;
                    }
                    else
                    {
                        rdbHoliday.Checked = true;
                    }

                }
            }
        }

        private void rdbPresent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPresent.Checked == true)
            {
                dtpTimeIN.Enabled = true;
                dtpTimeOut.Enabled = true;
            }

            else
            {
                dtpTimeIN.Enabled = false;
                dtpTimeOut.Enabled = false;
            }
        }

        private void rdbAbsent_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAbsent.Checked == true)
            {
                dtpTimeIN.Enabled = false;
                dtpTimeOut.Enabled = false;
            }

        }

        private Int32 GetStatus()
        {
            if (rdbAbsent.Checked == true)
                return 0;
            else if (rdbPresent.Checked == true)
                return 1;
            else if (rdbAnnual.Checked == true)
                return 2;
            else if (rdbCasual.Checked == true)
                return 3;
            else if (rdbSickLeave.Checked == true)
                return 4;
            else
                return 5;

        }

        private void rdbHoliday_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHoliday.Checked == true)
            {
                dtpTimeIN.Enabled = false;
                dtpTimeOut.Enabled = false;
            }
        }

        public static void MarkAttendanceByCamera(int empId, DateTime attendanceDate, bool isCamera)
        {
            try
            {
                dsAttendance ds = new dsAttendance();
                dsAttendanceTableAdapters.AttendanceTableAdapter taAttendance = new dsAttendanceTableAdapters.AttendanceTableAdapter();
                taAttendance.FillByDate(ds.Attendance, attendanceDate.ToString());
                if (ds.Attendance.Rows.Count <= 0)
                {
                    AttendanceList.GenerateAttendanceSheet(attendanceDate);
                }
                else
                {
                }
                dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
                taAttendanceDetail.FillbyEmployeeDate(ds.AttendanceDetail, empId, attendanceDate.ToString());
                var attendanceDetail = ds.AttendanceDetail.NewAttendanceDetailRow();
                if (ds.AttendanceDetail.Rows.Count > 0)
                {
                    attendanceDetail = ds.AttendanceDetail[0];
                    if (attendanceDetail.IsTimeInNull() && isCamera == true)
                    {
                        attendanceDetail.TimeIn = (SmartManger.BAL.Common.DateNow()).TimeOfDay;
                        attendanceDetail.TimeOut = TimeSpan.Parse("16:00:00");
                        attendanceDetail.IsByCamera = true;
                        attendanceDetail.Status = 1;
                        attendanceDetail.ModifiedDate = SmartManger.BAL.Common.DateNow();
                        if (!attendanceDetail.IsSystemNotesNull())
                        {
                            attendanceDetail.SystemNotes += "Marked by camerea on " + SmartManger.BAL.Common.DateNow();
                        }
                        else
                        {
                            attendanceDetail.SystemNotes = "Marked by camerea on " + SmartManger.BAL.Common.DateNow();
                        }
                    }
                    taAttendanceDetail.Update(attendanceDetail);
                   
                   
                }
                else
                {
                   
                    //MessageBox.Show("Record not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MarkAttendance(int empId, DateTime attendanceDate)
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.AttendanceTableAdapter taAttendance = new dsAttendanceTableAdapters.AttendanceTableAdapter();
            dsAttendanceTableAdapters.EmployeeTableAdapter taEmployee = new dsAttendanceTableAdapters.EmployeeTableAdapter();
            
            taAttendance.FillByDate(ds.Attendance,attendanceDate.ToString());
            if (ds.Attendance.Rows.Count <= 0)
            {
                AttendanceList.GenerateAttendanceSheet(attendanceDate);
            }
            dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
            taAttendanceDetail.FillbyEmployeeDate(ds.AttendanceDetail, empId, attendanceDate.ToString());
            taEmployee.FillById(ds.Employee,empId);
            var employee = ds.Employee.NewEmployeeRow();
            var attendanceDetail = ds.AttendanceDetail.NewAttendanceDetailRow();
            
            if (ds.AttendanceDetail.Rows.Count > 0)
            {
                attendanceDetail = ds.AttendanceDetail[0];
                attendanceDetail.Status = GetStatus();
                if (ds.Employee.Rows.Count > 0)
                {
                    employee = ds.Employee[0];
                }
                if(attendanceDetail.Status==2)
                {
                    employee.AL = employee.AL-1;
                }
                else if(attendanceDetail.Status==3)
                {
                    employee.CL = employee.CL-1;
                }
                else if (attendanceDetail.Status== 4) 
                {
                    employee.SL = employee.SL-1;
                }
                if (attendanceDetail.Status == 1)
                {
                    attendanceDetail.TimeIn = Convert.ToDateTime(dtpTimeIN.Text).TimeOfDay;
                    attendanceDetail.TimeOut = Convert.ToDateTime(dtpTimeOut.Text).TimeOfDay;
                }
                attendanceDetail.ModifiedDate = SmartManger.BAL.Common.DateNow();
                if (!attendanceDetail.IsSystemNotesNull())
                {
                    attendanceDetail.SystemNotes += "Marked by admin " + SmartManger.BAL.Common.DateNow();
                }
                else
                {
                    attendanceDetail.SystemNotes = "Modified by admin " + SmartManger.BAL.Common.DateNow();
                }
            }
            taAttendanceDetail.Update(attendanceDetail);
            taEmployee.Update(employee);

        }


    }
}

