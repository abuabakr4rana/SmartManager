using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartManger.BAL;
using SmartManager.Models;
using System.Text.RegularExpressions;

namespace SmartManger_V._1_.HRManger
{
    public partial class Department : Form
    {
        public Int32 selectedRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public Department()
        {
            InitializeComponent();
        }

        private void FillStatus()
        {
            cmbIsActive.Items.Add("Active");
            cmbIsActive.Items.Add("Deactive");
            cmbIsActive.SelectedIndex = 0;
        }

        private void FillGrid()
        {
            DepartmentBAL _objBAL = new DepartmentBAL();
            List<DepartmentModel> DepartmentList = new List<DepartmentModel>();
            grdDepartment.DataSource = null;
            grdDepartment.Rows.Clear();
            DepartmentList = _objBAL.GetDepartmentList();
            grdDepartment.AutoGenerateColumns = false;
            int count = 0;
            foreach (var item in DepartmentList)
            {
                count++;
                grdDepartment.Rows.Add(item._DeptID, item._DeptName, item._Description, item._ModifiedDate.ToShortDateString());
            }
            tbxCount.Text = count.ToString(); ;

        }

        private void MakeEmpty()
        {
            tbxDeptName.Text = "";
            tbxModifiedDate.Text = "";
            tbxDescription.Text = "";
            selectedRecordId = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (validate() == true)
                {

                    DepartmentBAL _objBAL = new DepartmentBAL();
                    DepartmentModel _objModel = new DepartmentModel();
                    _objModel._DeptID = selectedRecordId;
                    _objModel._DeptName = tbxDeptName.Text;
                    _objModel._Description = tbxDescription.Text;
                    _objModel._ModifiedDate = DateTime.Now;
                    _objModel._IsActive = (cmbIsActive.SelectedIndex == 0) ? true : false;
                    if (selectedRecordId == 0)
                    {
                        _objBAL.SaveDepartment(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateDepartment(_objModel);
                    }
                    MakeEmpty();
                    MessageBox.Show("Record Saved Successfully!");
                    FillGrid();
                }
            }
            catch
            { }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void Department_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Application.StartupPath);
            FillGrid();
            FillStatus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRecordId != 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    DepartmentBAL _objBAL = new DepartmentBAL();
                    _objBAL.DeleteUser(selectedRecordId);
                    MessageBox.Show("Record has been deleted successfully!");
                    FillGrid();


                }
                catch (System.Data.SqlClient.SqlException sqlEx)
                {
                    if (sqlEx.Number == 547)
                    {

                        MessageBox.Show("You cannot delete this record. Its refference exists in other documents.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Cursor = Cursors.Default;
                    MakeEmpty();
                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MakeEmpty();
        }

        private void FillForm(Int32 _DeptID)
        {
            try
            {
                DepartmentBAL _objBAL = new DepartmentBAL();
                DepartmentModel _objModel = _objBAL.SearchDepartment(_DeptID);
                tbxDeptName.Text = _objModel._DeptName;
                tbxDescription.Text = _objModel._Description;
                tbxModifiedDate.Text = _objModel._ModifiedDate.ToShortDateString();
                cmbIsActive.SelectedIndex = (_objModel._IsActive == true) ? 0 : 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdDepartment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (grdDepartment.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
            {
                DataGridViewRow dr = grdDepartment.SelectedRows[0];
                selectedRecordId = Convert.ToInt32(dr.Cells["DeptID"].Value.ToString());
                FillForm(selectedRecordId);
            }
            else 
            {
                MakeEmpty();
                    
            }
            Cursor = Cursors.Default;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbxDeptName_Validated(object sender, EventArgs e)
        {
            bool bTest = Validations.IsName(tbxDeptName.Text);
            if (bTest == false || tbxDeptName.Text == "")
            {
                this.errorProvider1.SetError(tbxDeptName, "Enter alphabets only");
            }
            else
            {
                this.errorProvider1.SetError(tbxDeptName, "");
            }
        }
        private bool validate()
        {
            errors = new StringBuilder();
            //Validate First Name and Last Name
            validator = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
            if (!validator.Match(tbxDeptName.Text.Trim()).Success)
                errors.AppendLine("Department name is not in the proper format.");
            if (errors.ToString() == String.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(errors.ToString(), "Validation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
