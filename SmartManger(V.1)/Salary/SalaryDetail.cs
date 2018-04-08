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
    public partial class SalaryDetail : Form
    {
        public Int32 selectedRecordId = 0;
        private DateTime CurrntDate = SmartManger.BAL.Common.DateNow();
        private DateTime First = SalaryList.FirstOfMonth(DateTime.Now);
        private DateTime Last = SalaryList.LastOfMonth(DateTime.Now);

        public SalaryDetail(Int32 value)
        {
            InitializeComponent();
            selectedRecordId = value;
        }



        public SalaryDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalaryForm slForm = new SalaryForm();
            slForm.Show();
        }
        private void FillGrid(int recordId, DateTime First, DateTime Last)
        {
            dsSalary ds = new dsSalary();
            dsSalaryTableAdapters.vSalaryFormTableAdapter taSalryDetail = new dsSalaryTableAdapters.vSalaryFormTableAdapter();
            DataTable dt = taSalryDetail.GetData4Grid(recordId, First.ToString(), Last.ToString());
            grdSalaryDetail.Rows.Clear();
            grdSalaryDetail.AutoGenerateColumns = false;
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
                count++;
                grdSalaryDetail.Rows.Add(item[4], count, item[1], Convert.ToDateTime(item[2]).ToString("dd,MMMM,yyyy"), item[7], item[8], item[9], Math.Round(Convert.ToDouble(item[10]), 2), item[12], Math.Round(Convert.ToDouble(item[13]), 2));
            }
            tbxCount.Text = count.ToString();
        }

        private void grdSalaryDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalaryDetail_Load(object sender, EventArgs e)
        {
            FillGrid(selectedRecordId, First, Last);
        }

        private void grdSalaryDetail_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (grdSalaryDetail.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    DataGridViewRow dr = grdSalaryDetail.SelectedRows[0];
                    int recordid = Convert.ToInt32(dr.Cells["SalarydetailId"].Value.ToString());
                    SalaryForm SalaryDetailForm = new SalaryForm(recordid);
                    SalaryDetailForm.ShowDialog();
                }
                FillGrid(selectedRecordId, First, Last);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
