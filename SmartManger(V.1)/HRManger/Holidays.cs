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
    public partial class Holidays : Form
    {
        public int selectedRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public Holidays()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            HolidaysBAL _objBAL = new HolidaysBAL();
            List<HolidayModel> DepartmentList = new List<HolidayModel>();
            grdHolidays.DataSource = null;
            grdHolidays.Rows.Clear();
            DepartmentList = _objBAL.GetHolidayList();
            grdHolidays.AutoGenerateColumns = false;
            int count = 0;
            foreach (var item in DepartmentList)
            {
                count++;
                grdHolidays.Rows.Add(item._HolidayID, item._HolidayDate, item._ModifiedDate.ToShortDateString(), item._Description);
            }
            tbxCount.Text = count.ToString();

        }

        private void MakeEmpty()
        {
            tbxDescription.Text = "";
            tbxModifiedDate.Text = "";
            dtpHolidayDate.Text = "";
            selectedRecordId = 0;
        }

        private void FillForm(Int32 _HolidayId)
        {
            try
            {
                HolidaysBAL _objBAL = new HolidaysBAL();
                HolidayModel _objModel = _objBAL.SearchHoliday(_HolidayId);
                dtpHolidayDate.Text = _objModel._HolidayDate.ToString();
                tbxDescription.Text = _objModel._Description;
                tbxModifiedDate.Text = _objModel._ModifiedDate.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void gbxHolidaysDetail_Enter(object sender, EventArgs e)
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
                if (validate())
                {
                    HolidaysBAL _objBAL = new HolidaysBAL();
                    HolidayModel _objModel = new HolidayModel();
                    _objModel._HolidayID = selectedRecordId;
                    _objModel._HolidayDate = Convert.ToDateTime(dtpHolidayDate.Text);
                    _objModel._Description = tbxDescription.Text;
                    _objModel._ModifiedDate = DateTime.Now;
                    if (selectedRecordId == 0)
                    {
                        _objBAL.SaveHoliday(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateHoliday(_objModel);
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
                    HolidaysBAL _objBAL = new HolidaysBAL();
                    _objBAL.DeleteHoliday(selectedRecordId);
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

        private void grdHolidays_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Cursor = Cursors.WaitCursor;
            if (grdHolidays.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
            {
                DataGridViewRow dr = grdHolidays.SelectedRows[0];
                selectedRecordId = Convert.ToInt32(dr.Cells["HolidayId"].Value.ToString());
                FillForm(selectedRecordId);
            }
            else
            {
                MakeEmpty();
            }
            Cursor = Cursors.Default;
        }

        private void Holidays_Load(object sender, EventArgs e)
        {
            FillGrid();
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
            if (!validator.Match(tbxDescription.Text.Trim()).Success)
                errors.AppendLine("Holiday Description is not in the proper format.");
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
