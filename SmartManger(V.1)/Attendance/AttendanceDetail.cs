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
    public partial class AttendanceDetail : Form
    {
        public Int32 selectedRecordId = 0;
        Int32 roleId = 1;

        public AttendanceDetail(Int32 value,Int32 Role)
        {
            InitializeComponent();
            selectedRecordId = value;
            roleId = Role;
        }
       

        public AttendanceDetail()
        {
            InitializeComponent();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            AttendanceForm attendance = new AttendanceForm();
            attendance.Show();
        }

        private void AttendanceDetail_Load(object sender, EventArgs e)
        {
            FillGrid(selectedRecordId);
            dtpFrom.CustomFormat = "dd,MMMM,yyyy";
            dtpTo.CustomFormat = "dd,MMMM,yyyy";
            dtpFrom.Text=(Salary.SalaryList.FirstOfMonth(DateTime.Now)).ToString();
            dtpTo.Text = (Salary.SalaryList.LastOfMonth(DateTime.Now)).ToString();
            FillEmployeeList();
            btnMark.Enabled = false;
        }

        private void FillGrid(Int32 recordId)
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
            DataTable dt = taAttendanceDetail.GetDataByAttendanceId(selectedRecordId);
            grdAttendanceDetail.Rows.Clear();
            grdAttendanceDetail.AutoGenerateColumns = false;
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
                count++;
                string _status = FindStatus(item[3]);
                grdAttendanceDetail.Rows.Add(item[0], count,Convert.ToDateTime(item[9]).ToString("dd,MMMM,yyyy"), item[10], item[11], item[12], item[7], item[8], _status);
            }
            tbxCount.Text = count.ToString();
        }

        private string FindStatus(object obj)
        {
            int St = Convert.ToInt32(obj);
            if (St == 0)
                return "Absent";
            else if (St == 1)
                return "Present";
            else if (St == 2)
                return "Annual Leave";
            else if (St == 3)
                return "Casual Leave";
            else if (St == 4)
                return "Sick Leave";
            else
                return "Holiday";
        }

        private void grdAttendanceDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (roleId != 3)
                {
                    if (grdAttendanceDetail.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                    {
                        DataGridViewRow dr = grdAttendanceDetail.SelectedRows[0];
                        int recordid = Convert.ToInt32(dr.Cells["AttendanceDetailId"].Value.ToString());
                        AttendanceForm attendanceDetailForm = new AttendanceForm(recordid);
                        attendanceDetailForm.ShowDialog();
                    }
                    FillGrid(selectedRecordId);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchGrid(int empid, DateTime From, DateTime To)
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.AttendanceDetailTableAdapter taAttendanceDetail = new dsAttendanceTableAdapters.AttendanceDetailTableAdapter();
            DataTable dt = taAttendanceDetail.GetDataForSearch(empid, From.ToString(), To.ToString());
            grdAttendanceDetail.Rows.Clear();
            grdAttendanceDetail.AutoGenerateColumns = false;
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
                count++;
                string _status = FindStatus(item[3]);
                grdAttendanceDetail.Rows.Add(item[0], count, item[9], item[10], item[11], item[12], item[7], item[8], _status);
            }
            tbxCount.Text = count.ToString();
        }
        private void FillEmployeeList()
        {
            dsAttendance ds = new dsAttendance();
            dsAttendanceTableAdapters.vEmployeeComboTableAdapter taAttendance = new dsAttendanceTableAdapters.vEmployeeComboTableAdapter();
            taAttendance.Fill(ds.vEmployeeCombo);
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.DisplayMember = "EmployeeName";
            cmbEmployee.DataSource = ds.vEmployeeCombo.DefaultView;
            cmbEmployee.SelectedIndex = -1;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex == -1)
            {
                SearchGrid(0, dtpFrom.Value, dtpTo.Value);
            }
            else
                SearchGrid(Convert.ToInt32(cmbEmployee.SelectedValue), dtpFrom.Value, dtpTo.Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchGrid(0, DateTime.Now, DateTime.Now);
            cmbEmployee.SelectedIndex = -1;
        }
    }
}
