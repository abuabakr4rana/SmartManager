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
    public partial class Shift : Form
    {
        public int selectedRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public Shift()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void FillGrid()
        {
            ShiftBAL _objBAL = new ShiftBAL();
            List<ShiftModel> ShiftList = new List<ShiftModel>();
            grdShifts.DataSource = null;
            grdShifts.Rows.Clear();
            ShiftList = _objBAL.GetShiftList();
            grdShifts.AutoGenerateColumns = false;
            int count = 0;
            foreach (var item in ShiftList)
            {
                count++;
                grdShifts.Rows.Add(item._ShiftID, item._ShiftName, item._StartTime.TimeOfDay, item._EndTime.TimeOfDay, item._ModifiedDate);
            }

            tbxCount.Text = count.ToString();
        }

        private void MakeEmpty()
        {
            tbxShiftName.Text = "";
            tbxModifiedDate.Text = "";
            dtpStartTime.Text = "";
            dtpEndTime.Text = "";
            selectedRecordId = 0;
        }

        private void FillForm(Int32 _ShiftId)
        {
            try
            {
                ShiftBAL _objBAL = new ShiftBAL();
                ShiftModel _objModel = _objBAL.SearchShift(_ShiftId);
                dtpStartTime.Text = _objModel._StartTime.ToString();
                tbxShiftName.Text = _objModel._ShiftName;
                dtpEndTime.Text = _objModel._EndTime.ToString();
                tbxModifiedDate.Text = _objModel._ModifiedDate.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                    ShiftBAL _objBAL = new ShiftBAL();
                    ShiftModel _objModel = new ShiftModel();
                    _objModel._ShiftID = selectedRecordId;
                    _objModel._StartTime = Convert.ToDateTime(dtpStartTime.Text);
                    _objModel._EndTime = Convert.ToDateTime(dtpEndTime.Text);
                    _objModel._ShiftName = tbxShiftName.Text;
                    _objModel._ModifiedDate = DateTime.Now;
                    if (selectedRecordId == 0)
                    {
                        _objBAL.SaveShift(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateShift(_objModel);
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
                    ShiftBAL _objBAL = new ShiftBAL();
                    _objBAL.DeleteShift(selectedRecordId);
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
                }

                MakeEmpty();
            }
        }

        private void grdShifts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (grdShifts.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    DataGridViewRow dr = grdShifts.SelectedRows[0];
                    selectedRecordId = Convert.ToInt32(dr.Cells["ShiftId"].Value.ToString());
                    FillForm(selectedRecordId);
                }
                else
                {
                    MakeEmpty();
                }
                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void tbxShiftName_Validated(object sender, EventArgs e)
        {
            bool bTest = Validations.IsTextOnly(tbxShiftName.Text);
            if (bTest == false)
            {
                this.errorProvider1.SetError(tbxShiftName, "Only alphabets are allowed");
            }
            else
            {
                this.errorProvider1.SetError(tbxShiftName, "");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validate()
        {
            errors = new StringBuilder();
            //Validate First Name and Last Name
            validator = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
            if (!validator.Match(tbxShiftName.Text.Trim()).Success)
                errors.AppendLine("Shift name is not in the proper format.");
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

        private void tbxModifiedDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
