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

namespace SmartManger_V._1_.Salary
{
    public partial class SalaryList : Form
    {
        public Int32 RecordId;
        Int32 currenrtMonth = DateTime.Now.Month;
        Int32 currentYear = DateTime.Now.Year;
        DateTime CurrentDate = SmartManger.BAL.Common.DateNow();
        string First = new DateTime((DateTime.Now.Year), (DateTime.Now.Month), 1).ToShortDateString();
        string Last = new DateTime((DateTime.Now.Year), (DateTime.Now.Month), DateTime.DaysInMonth((DateTime.Now.Year), (DateTime.Now.Month))).ToShortDateString();
        public static DateTime FirstOfMonth(DateTime date)
        {

            DateTime b = new DateTime(date.Year, date.Month, 1);
            return b;
        }

        public static DateTime LastOfMonth(DateTime date)
        {
            DateTime a = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
            return a;
        }

        public SalaryList()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                dsSalary ds = new dsSalary();
                dsSalaryTableAdapters.SalaryTableAdapter taSalary = new dsSalaryTableAdapters.SalaryTableAdapter();
                dsSalaryTableAdapters.SalaryDetailTableAdapter taSalaryDetail = new dsSalaryTableAdapters.SalaryDetailTableAdapter();
                dsSalaryTableAdapters.EmployeeTableAdapter taEmployee = new dsSalaryTableAdapters.EmployeeTableAdapter();
                dsSalaryTableAdapters.vSalaryFormTableAdapter tavSalary = new dsSalaryTableAdapters.vSalaryFormTableAdapter();
                var salary = ds.Salary.NewSalaryRow();
                taSalary.FillByDate(ds.Salary, currenrtMonth, currentYear);
                if (ds.Salary.Rows.Count > 0)
                {
                    MessageBox.Show("Salary Sheet for this Month Already Exist!");
                }
                else
                {
                    salary.SalaryDate = SmartManger.BAL.Common.DateNow();
                    salary.CreatedOn = SmartManger.BAL.Common.DateNow();
                    ds.Salary.AddSalaryRow(salary);
                    taSalary.Update(salary);
                    RecordId = salary.SalaryId;
                    DataTable dt = taEmployee.GetData();
                    int empid = 0;
                    foreach (DataRow item in dt.Rows)
                    {
                        empid = Convert.ToInt32(item[0]);
                        var salaryDetail = ds.SalaryDetail.NewSalaryDetailRow();
                        salaryDetail.SalaryId = RecordId;
                        salaryDetail.EmployeeId = Convert.ToInt32(item[0]);
                        salaryDetail.Salary = Convert.ToDouble(item[1]);
                        salaryDetail.Absents = Convert.ToInt32(tavSalary.GetAbsents(empid, First, Last));
                        salaryDetail.Presents = Convert.ToInt32(tavSalary.GetPresents(empid, First, Last));
                        int workingdays = SalaryForm.GetNumberOfWorkingDays(Convert.ToDateTime(First), Convert.ToDateTime(Last));
                        salaryDetail.Leaves = Convert.ToInt32(tavSalary.GetAL(empid, First, Last)) + Convert.ToInt32(tavSalary.GetCL(empid, First, Last)) + Convert.ToInt32(tavSalary.GetSL(empid, First, Last));
                        salaryDetail.AbsentDeduction = ((salaryDetail.Salary / workingdays) * salaryDetail.Absents);
                        salaryDetail.Total = ((salaryDetail.Salary / workingdays) * salaryDetail.Presents) + ((salaryDetail.Salary / workingdays) * salaryDetail.Leaves);

                        ds.SalaryDetail.AddSalaryDetailRow(salaryDetail);
                        taSalaryDetail.Update(salaryDetail);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void FillGrid(DateTime Start, DateTime End)
        {
            dsSalary ds = new dsSalary();
            dsSalaryTableAdapters.SalaryTableAdapter taSalary = new dsSalaryTableAdapters.SalaryTableAdapter();
            DataTable dt = taSalary.GetDataByDates(Start.ToString(), End.ToString());
            grdSalary.Rows.Clear();
            grdSalary.AutoGenerateColumns = false;
            int SrNo = 0;
            foreach (DataRow item in dt.Rows)
            {
                SrNo++;
                DateTime date = Convert.ToDateTime(item[1].ToString());
                string Year = date.Year.ToString();
                string Month = date.ToString("MMMM");
                grdSalary.Rows.Add(item[0], SrNo, Month, Year, item[2].ToString());
            }
            tbxCount.Text = SrNo.ToString();

        }

        private void SalaryList_Load(object sender, EventArgs e)
        {
            FillGrid(FirstOfMonth(CurrentDate), LastOfMonth(CurrentDate));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid(FirstOfMonth(CurrentDate), LastOfMonth(CurrentDate));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid(dtpStart.Value, dtpEnd.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillGrid(dtpStart.Value, dtpEnd.Value);
        }

        public static double GenerateAbsentDeduction(Int32 workingdays, double salary, int absents)
        {

            return ((salary / workingdays) * absents);
        }

        private void grdSalary_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (grdSalary.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    Cursor = Cursors.WaitCursor;
                    DataGridViewRow dr = grdSalary.SelectedRows[0];
                    int recordid = Convert.ToInt32(dr.Cells["SlaryId"].Value.ToString());
                    SalaryDetail salaryDetailForm = new SalaryDetail(recordid);
                    salaryDetailForm.Show();
                }
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
    }
}
