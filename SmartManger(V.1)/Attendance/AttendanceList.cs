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
    public partial class AttendanceList : Form
    {
        public Int32 selectedRecordId = 0;
        public Int32 roleId = 1;

        public static DateTime FirstOfMonth()
        {
            DateTime Now = SmartManger.BAL.Common.DateNow();
            DateTime b = new DateTime(Now.Year, Now.Month, 1);
            return b;
        }

        public static DateTime LastOfMonth()
        {
            DateTime Now = SmartManger.BAL.Common.DateNow();
            DateTime a = new DateTime(Now.Year, Now.Month, DateTime.DaysInMonth(Now.Year, Now.Month));
            return a;
        }
        public AttendanceList(Int32 Role)
        {
            InitializeComponent();
            roleId = Role;
        }

        public AttendanceList()
        {
            InitializeComponent();
        }

        private void FillGrid(DateTime Start, DateTime End)
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.AttendanceTableAdapter taAttendance = new dsAttendanceTableAdapters.AttendanceTableAdapter();
            DataTable dt = taAttendance.GetDataByGivenDates(Start.ToString(), End.ToString());
            grdAttendanceList.Rows.Clear();
            grdAttendanceList.AutoGenerateColumns = false;
            int SrNo = 0;
            foreach (DataRow item in dt.Rows)
            {
                SrNo++;
                DateTime date = Convert.ToDateTime(item[1].ToString());
                string Day = date.ToString("dddd");
                string Month = date.ToString("MMMM");

                grdAttendanceList.Rows.Add(item[0], SrNo, date.ToString("dd,MMMM,yyyy"), Day, Month);
            }
            tbxCount.Text = SrNo.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FillGrid(FirstOfMonth(), LastOfMonth());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateAttendanceSheet(SmartManger.BAL.Common.DateNow());
                FillGrid(FirstOfMonth(), LastOfMonth());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AttendanceList_Load(object sender, EventArgs e)
        {
             dtpTo.CustomFormat=dtpFrom.CustomFormat = "dd,MMMM,yyyy";
            dtpFrom.Text = FirstOfMonth().ToString();
            dtpTo.Text = LastOfMonth().ToString();
            FillGrid(FirstOfMonth(), LastOfMonth());
            if(roleId==3)
            {
                btnGenerate.Enabled = false;
            }
        }

        private void grdAttendanceList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (grdAttendanceList.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    DataGridViewRow dr = grdAttendanceList.SelectedRows[0];
                    int recordid = Convert.ToInt32(dr.Cells["AttendanceId"].Value.ToString());
                    AttendanceDetail attendanceDetailForm = new AttendanceDetail(recordid,roleId);
                    attendanceDetailForm.Show();
                }
                FillGrid(FirstOfMonth(), LastOfMonth());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        public static void GenerateAttendanceSheet(DateTime Date)
        {
            int RecordId;
            int Status;

            try
            {
                dsAttendance ds = new dsAttendance();
                dsAttendanceTableAdapters.AttendanceTableAdapter taAttendance = new dsAttendanceTableAdapters.AttendanceTableAdapter();
                dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
                var attendance = ds.Attendance.NewAttendanceRow();
                taAttendance.FillByDate(ds.Attendance, Date.ToString());
                if (ds.Attendance.Rows.Count > 0)
                {
                    MessageBox.Show("Attendance Sheet for this date Already Exist!");
                }
                else
                {
                    attendance.AttendanceDate = Date;
                    attendance.CreatedOn = SmartManger.BAL.Common.DateNow();
                    attendance.SystemNotes = "Created by:Admin on" + SmartManger.BAL.Common.DateNow();
                    ds.Attendance.AddAttendanceRow(attendance);

                    taAttendance.Update(attendance);
                    RecordId = attendance.AttendanceId;
                    dsAttendanceTableAdapters.EmployeeIDsTableAdapter taEmpId = new dsAttendanceTableAdapters.EmployeeIDsTableAdapter();
                    DataTable dt = taEmpId.GetData();
                    Status = GetAttendanceStatus(Date);
                    foreach (DataRow item in dt.Rows)
                    {
                        var attendanceDetail = ds.AttendanceDetail.NewAttendanceDetailRow();
                        attendanceDetail.AttendanceId = RecordId;
                        attendanceDetail.EmployeeId = Convert.ToInt32(item[0].ToString());
                        attendanceDetail.Status = Status;
                        attendanceDetail.ModifiedDate = SmartManger.BAL.Common.DateNow();
                        attendanceDetail.IsByCamera = false;
                        ds.AttendanceDetail.AddAttendanceDetailRow(attendanceDetail);
                        taAttendanceDetail.Update(attendanceDetail);
                    }

                    MessageBox.Show("Attendance Sheet Generated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static int GetAttendanceStatus(DateTime Date)
        {
            int status = 0;
            string Day = Date.ToString("dddd");
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.HolidaysTableAdapter taHoliday = new dsAttendanceTableAdapters.HolidaysTableAdapter();
            taHoliday.FillByDate(ds.Holidays, Date);
            if (ds.Holidays.Rows.Count > 0)
            {
                status = 5;
            }
            if (Day == "Sunday" || Day == "Saturday")
            {
                status = 5;
            }

            return status;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillGrid(dtpFrom.Value, dtpTo.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxSearch_Enter(object sender, EventArgs e)
        {

        }

    }
}
