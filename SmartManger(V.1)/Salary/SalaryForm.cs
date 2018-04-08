using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartManger_V._1_.Salary
{
    public partial class SalaryForm : Form
    {
        public Int32 detailId = 0;
        string present, absent, leaves, deduction;

        public SalaryForm(Int32 value)
        {
            InitializeComponent();
            detailId = value;
        }

        public SalaryForm()
        {
            InitializeComponent();
        }

        public static int GetNumberOfWorkingDays(DateTime start, DateTime stop)
        {
            TimeSpan interval = stop - start;

            int totalWeek = interval.Days / 7;
            int totalWorkingDays = 5 * totalWeek;

            int remainingDays = interval.Days % 7;


            for (int i = 0; i <= remainingDays; i++)
            {
                DayOfWeek test = (DayOfWeek)(((int)start.DayOfWeek + i) % 7);
                if (test >= DayOfWeek.Monday && test <= DayOfWeek.Friday)
                    totalWorkingDays++;
            }

            return totalWorkingDays;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            FillForm(detailId);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void FillForm(int detailId)
        {
            if (detailId != 0)
            {
                dsSalary ds = new dsSalary();
                dsSalaryTableAdapters.vSalaryFormTableAdapter taSalaryDetail = new dsSalaryTableAdapters.vSalaryFormTableAdapter();
                taSalaryDetail.FillByDetailId(ds.vSalaryForm, detailId);
                var salaryDetail = ds.vSalaryForm.NewvSalaryFormRow();
                if (ds.vSalaryForm.Rows.Count > 0)
                {
                    salaryDetail = ds.vSalaryForm[0];
                    DateTime date = salaryDetail.SalaryDate;
                    tbxSalaryMonth.Text = salaryDetail.SalaryDate.ToString("MMMM") + " " + salaryDetail.SalaryDate.Year.ToString();
                    int workingDays = GetNumberOfWorkingDays(SalaryList.FirstOfMonth(date), SalaryList.LastOfMonth(date));
                    salaryDetail = ds.vSalaryForm[0];
                    tbxName.Text = salaryDetail.EmployeeName;
                    tbxCode.Text = salaryDetail.Code.ToString();
                    tbxSalary.Text = (Math.Round(salaryDetail.Salary, 2)).ToString();
                    tbxJoiningDate.Text = salaryDetail.HireDate.ToShortDateString();
                    tbxWorkingDays.Text = workingDays.ToString();
                    tbxPresent.Text = salaryDetail.Presents.ToString();
                    tbxAbsents.Text = salaryDetail.Absents.ToString();
                    tbxLeaves.Text = salaryDetail.Leaves.ToString();
                    tbxAbsentDeduction.Text = (Math.Round((salaryDetail.Salary / workingDays) * Convert.ToInt32(tbxAbsents.Text), 2)).ToString();
                    tbxTotalSalary.Text = Math.Round(salaryDetail.Total, 2).ToString();
                    tbxOtherDeductions.Text = salaryDetail.IsDeductionsNull() ? "0" : salaryDetail.Deductions.ToString();
                    saveValues();
                }
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsSalary ds = new dsSalary();
            dsSalaryTableAdapters.vSalaryFormTableAdapter tasalaryDetail = new dsSalaryTableAdapters.vSalaryFormTableAdapter();
            tasalaryDetail.FillByDetailId(ds.vSalaryForm, detailId);
            var salaryDetail = ds.vSalaryForm.NewvSalaryFormRow();
            if (ds.vSalaryForm.Rows.Count > 0)
            {
                int leaves;
                salaryDetail = ds.vSalaryForm[0];
                leaves = salaryDetail.Leaves;
                tbxPresent.Text = tasalaryDetail.GetPresents(salaryDetail.EmployeeId, SalaryList.FirstOfMonth(salaryDetail.SalaryDate).ToString(), SalaryList.LastOfMonth(salaryDetail.SalaryDate).ToString()).ToString();
                tbxAbsents.Text = tasalaryDetail.GetAbsents(salaryDetail.EmployeeId, SalaryList.FirstOfMonth(salaryDetail.SalaryDate).ToString(), SalaryList.LastOfMonth(salaryDetail.SalaryDate).ToString()).ToString();
                leaves = Convert.ToInt32(tasalaryDetail.GetAL(salaryDetail.EmployeeId, SalaryList.FirstOfMonth(salaryDetail.SalaryDate).ToString(), SalaryList.LastOfMonth(salaryDetail.SalaryDate).ToString()));
                leaves = leaves + Convert.ToInt32(tasalaryDetail.GetCL(salaryDetail.EmployeeId, SalaryList.FirstOfMonth(salaryDetail.SalaryDate).ToString(), SalaryList.LastOfMonth(salaryDetail.SalaryDate).ToString()));
                leaves = leaves + Convert.ToInt32(tasalaryDetail.GetSL(salaryDetail.EmployeeId, SalaryList.FirstOfMonth(salaryDetail.SalaryDate).ToString(), SalaryList.LastOfMonth(salaryDetail.SalaryDate).ToString()));
                tbxLeaves.Text = leaves.ToString();
                saveValues();
            }


        }

        private void tbxAbsents_TextChanged(object sender, EventArgs e)
        {
            if (tbxAbsents.Text != "")
            {
                if ((Convert.ToInt32(tbxLeaves.Text) + Convert.ToInt32(tbxAbsents.Text) + Convert.ToInt32(tbxPresent.Text)) <= Convert.ToInt32(tbxWorkingDays.Text))
                {
                    double salary;
                    int workingDays, absents = 0;
                    salary = Convert.ToDouble(tbxSalary.Text);
                    workingDays = Convert.ToInt32(tbxWorkingDays.Text);
                    absents = Convert.ToInt32(tbxAbsents.Text);
                    tbxAbsentDeduction.Text =Math.Round(((salary / workingDays) * absents),2).ToString();
                    saveValues();
                }
                else
                {
                    tbxAbsents.Text = absent;
                }
            }
           

        }

        private void tbxPresent_TextChanged(object sender, EventArgs e)
        {
            if (tbxPresent.Text != "" && tbxLeaves.Text != "" && tbxOtherDeductions.Text != "")
            {
                if (Convert.ToDouble(tbxOtherDeductions.Text) <= Convert.ToDouble(tbxTotalSalary.Text))
                {
                    double presentAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxPresent.Text)), 2);
                    double LeavesAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxLeaves.Text)), 2);
                    tbxTotalSalary.Text = Math.Round(((presentAmount + LeavesAmount) - Convert.ToDouble(tbxOtherDeductions.Text)), 2).ToString();
                    saveValues();
                }

                else
                {
                    tbxPresent.Text = present;
                }
            }
        }

        private void tbxLeaves_TextChanged(object sender, EventArgs e)
        {
            if (tbxPresent.Text != "" && tbxLeaves.Text != "" && tbxOtherDeductions.Text != "")
            {
                if (Convert.ToDouble(tbxOtherDeductions.Text) <= Convert.ToDouble(tbxTotalSalary.Text))
                {
                    double presentAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxPresent.Text)), 2);
                    double LeavesAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxLeaves.Text)), 2);
                    tbxTotalSalary.Text = Math.Round(((presentAmount + LeavesAmount) - Convert.ToDouble(tbxOtherDeductions.Text)), 2).ToString();
                    saveValues();
                }

                else
                {
                    tbxLeaves.Text = leaves;
                }
            }
        }

        private void tbxOtherDeductions_TextChanged(object sender, EventArgs e)
        {
            if (tbxPresent.Text != "" && tbxLeaves.Text != "" && tbxOtherDeductions.Text != "")
            {
                if (Convert.ToDouble(tbxOtherDeductions.Text) <= Convert.ToDouble(tbxTotalSalary.Text))
                {
                    double presentAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxPresent.Text)), 2);
                    double LeavesAmount = Math.Round(((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxLeaves.Text)),2);
                    tbxTotalSalary.Text = Math.Round(((presentAmount + LeavesAmount) - Convert.ToDouble(tbxOtherDeductions.Text)),2).ToString();
                    saveValues();
                }
                else
                {
                    tbxOtherDeductions.Text = deduction;
                }
            }
        }

        private void tbxOtherDeductions_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void tbxAbsents_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void tbxLeaves_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void tbxPresent_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (tbxPresent.Text != "" && tbxLeaves.Text != "" && tbxOtherDeductions.Text != "")
            {
                if ((Convert.ToInt32(tbxLeaves.Text) + Convert.ToInt32(tbxAbsents.Text) + Convert.ToInt32(tbxPresent.Text)) > Convert.ToInt32(tbxWorkingDays.Text))
                {
                    double presentAmount = ((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxPresent.Text));
                    double LeavesAmount = ((Convert.ToDouble(tbxSalary.Text) / Convert.ToInt32(tbxWorkingDays.Text)) * Convert.ToInt32(tbxAbsents.Text));
                    tbxTotalSalary.Text = ((presentAmount + LeavesAmount) - Convert.ToDouble(tbxOtherDeductions.Text)).ToString();
                }
                else
                {

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dsSalary ds = new dsSalary();
            dsSalaryTableAdapters.SalaryDetailTableAdapter taSalryDetail = new dsSalaryTableAdapters.SalaryDetailTableAdapter();
            taSalryDetail.FillById(ds.SalaryDetail, detailId);
            var salarydetail = ds.SalaryDetail.NewSalaryDetailRow();
            if (ds.SalaryDetail.Rows.Count > 0)
            {
                salarydetail = ds.SalaryDetail[0];
                salarydetail.Presents = Convert.ToInt32(tbxPresent.Text);
                salarydetail.Absents = Convert.ToInt32(tbxAbsents.Text);
                salarydetail.Leaves = Convert.ToInt32(tbxLeaves.Text);
                salarydetail.Deductions = Convert.ToDouble(tbxOtherDeductions.Text);
                salarydetail.Total = Convert.ToDouble(tbxTotalSalary.Text);

                taSalryDetail.Update(salarydetail);
            }
            MessageBox.Show("Record Updated Successfully!");
            this.Close();
        }

        private void saveValues()
        {
            present = tbxPresent.Text;
            absent = tbxAbsents.Text;
            leaves = tbxLeaves.Text;
            deduction = tbxOtherDeductions.Text;
        }
    }
}
