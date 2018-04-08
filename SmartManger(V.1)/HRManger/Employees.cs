using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartManger_V._1_.HRManger
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EmployeeInfo empInfoForm = new EmployeeInfo();
            empInfoForm.Show();
        }

        private void FillGrid()
        {
            dsView ds = new dsView();
            dsViewTableAdapters.vEmployeeGridTableAdapter taEmployeeGrid = new dsViewTableAdapters.vEmployeeGridTableAdapter();
            DataTable dt = taEmployeeGrid.GetData();
            grdEmployee.AutoGenerateColumns = false;
            grdEmployee.Rows.Clear();
            int count = 0;
            foreach (DataRow item in dt.Rows)
            {
                count++;
                grdEmployee.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
            }
            tbxCount.Text = count.ToString();

        }

        private void grdEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Employees_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (grdEmployee.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    DataGridViewRow dr = grdEmployee.SelectedRows[0];
                    int recordid = Convert.ToInt32(dr.Cells["EmployeeID"].Value.ToString());
                    EmployeeInfo empInfoForm = new EmployeeInfo(recordid);
                    empInfoForm.ShowDialog();
                }

                FillGrid();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbxSearch.Text!="")
                {
                    string parameter = tbxSearch.Text;
                    dsView ds = new dsView();
                    dsViewTableAdapters.vEmployeeGridTableAdapter taEmployee = new dsViewTableAdapters.vEmployeeGridTableAdapter();
                    DataTable dt = taEmployee.GetDataByString(parameter);
                    grdEmployee.AutoGenerateColumns = false;
                    grdEmployee.Rows.Clear();
                    int count = 0;
                    foreach (DataRow item in dt.Rows)
                    {
                        count++;
                        grdEmployee.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
                    }
                    tbxCount.Text = count.ToString();

                }
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxSearch.Text != "")
                {
                    string parameter = tbxSearch.Text;
                    dsView ds = new dsView();
                    dsViewTableAdapters.vEmployeeGridTableAdapter taEmployee = new dsViewTableAdapters.vEmployeeGridTableAdapter();
                    DataTable dt = taEmployee.GetDataByString(parameter);
                    grdEmployee.AutoGenerateColumns = false;
                    grdEmployee.Rows.Clear();
                    int count = 0;
                    foreach (DataRow item in dt.Rows)
                    {
                        count++;
                        grdEmployee.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
                    }
                    tbxCount.Text = count.ToString();

                }
                else 
                {
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
