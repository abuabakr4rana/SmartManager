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
    public partial class Designation : Form
    {
        public Int32 selectedRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public Designation()
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
            DesignationBAL _objBAL = new DesignationBAL();
            List<DesignationModel> DesignationList = new List<DesignationModel>();
            grdDesignation.DataSource = null;
            grdDesignation.Rows.Clear();
            DesignationList = _objBAL.GetDesignationList();
            grdDesignation.AutoGenerateColumns = false;
            int count = 0;
            foreach (var item in DesignationList)
            {
                count++;
                grdDesignation.Rows.Add(item._DesgID, item._DesgName, (item._IsActive == true) ? "Active" : "Deactive", item._ModifiedDate.ToShortDateString(), item._Description);
            }
            tbxCount.Text = count.ToString();

        }

        private void MakeEmpty()
        {
            tbxDesignationName.Text = "";
            tbxModifiedDate.Text = "";
            tbxDescription.Text = "";
            selectedRecordId = 0;
            cmbIsActive.SelectedIndex = 0;
        }

        private void FillForm(Int32 _DesgID)
        {
            try
            {
                DesignationBAL _objBAL = new DesignationBAL();
                DesignationModel _objModel = _objBAL.SearchDesignation(_DesgID);
                tbxDesignationName.Text = _objModel._DesgName;
                tbxDescription.Text = _objModel._Description;
                tbxModifiedDate.Text = _objModel._ModifiedDate.ToString();
                cmbIsActive.SelectedIndex = (_objModel._IsActive == true) ? 0 : 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MakeEmpty();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                if (validate() == true)
                {
                    DesignationBAL _objBAL = new DesignationBAL();
                    DesignationModel _objModel = new DesignationModel();
                    _objModel._DesgID = selectedRecordId;
                    _objModel._DesgName = tbxDesignationName.Text;
                    _objModel._Description = tbxDescription.Text;
                    _objModel._ModifiedDate = DateTime.Now;
                    _objModel._IsActive = (cmbIsActive.SelectedIndex == 0) ? true : false;

                    if (selectedRecordId == 0)
                    {
                        _objBAL.SaveDesignation(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateDesignation(_objModel);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRecordId != 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    DesignationBAL _objBAL = new DesignationBAL();
                    _objBAL.DeleteDesignation(selectedRecordId);
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

        private void grdDesignation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (grdDesignation.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
            {
                DataGridViewRow dr = grdDesignation.SelectedRows[0];
                selectedRecordId = Convert.ToInt32(dr.Cells["DesgId"].Value.ToString());
                FillForm(selectedRecordId);
            }
            else 
            {
                MakeEmpty();
            }
            Cursor = Cursors.Default;
        }

        private void Designation_Load(object sender, EventArgs e)
        {
            FillGrid();
            FillStatus();
        }

        private void tbxDesignationName_Validated(object sender, EventArgs e)
        {
            bool bTest = Validations.IsName(tbxDesignationName.Text);
            if (bTest == false)
            {
                this.errorProvider1.SetError(tbxDesignationName, "Enter alphabets only");
            }
            else
            {
                this.errorProvider1.SetError(tbxDesignationName, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validate()
        {
            errors = new StringBuilder();
            //Validate First Name and Last Name
            validator = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
            if (!validator.Match(tbxDesignationName.Text.Trim()).Success)
                errors.AppendLine("Designation name is not in the proper format.");
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



    }
}
