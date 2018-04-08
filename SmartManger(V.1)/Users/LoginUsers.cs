using SmartManager.Models;
using SmartManger.BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartManger_V._1_
{
    public partial class LoginUsers : Form
    {
        Int32 selecteRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public LoginUsers()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoginUsers_Load(object sender, EventArgs e)
        {
            FillRoleList();
            FillGrid();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            tbxModifiedDate.Text = (DateTime.Now).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            MakeEmpty();
        }

        private void FillRoleList()
        {

            cmbRole.Items.Insert(0, "");
            cmbRole.Items.Insert(1, "Admin");
            cmbRole.Items.Insert(2, "Accountant");
            cmbRole.Items.Insert(3, "HR Manager");
            cmbRole.Items.Insert(4, "Time Officer");
        }

        private void FillGrid()
        {
            LoginBAL _objBAL = new LoginBAL();
            SqlDataReader dr = _objBAL.GetUsers();
            grdLoginUsers.AutoGenerateColumns = false;
            grdLoginUsers.Rows.Clear();
            int count = 0;
            while (dr.Read() == true)
            {
                count++;
                grdLoginUsers.Rows.Add(dr[0].ToString(), dr[1], "*****", dr[3], dr[4], Convert.ToDateTime(dr[5]).ToString("dd,MMMM,yyyy"));
            }
            tbxCount.Text = count.ToString();
        }

        private void grdLoginUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MakeEmpty()
        {
            tbxEmail.Text = "";
            tbxModifiedDate.Text = "";
            tbxPassword.Text = "";
            tbxUsername.Text = "";
            selecteRecordId = 0;
            cmbRole.SelectedIndex = 0;
        }

        private void FillForm(Int32 _userID)
        {
            try
            {
                LoginBAL _objBAL = new LoginBAL();
                LoginModel _objModel = _objBAL.SearchUser(_userID);
                tbxUsername.Text = _objModel._Username;
                tbxPassword.Text = _objModel._Password;
                tbxModifiedDate.Text = _objModel._ModifiedDate.ToString("dd,MMM,yyyy");
                tbxEmail.Text = _objModel._EmailAddress;
                cmbRole.SelectedIndex = _objModel._UserRole;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void grdLoginUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (grdLoginUsers.CurrentCell.RowIndex < Convert.ToInt32(tbxCount.Text))
                {
                    DataGridViewRow dr = grdLoginUsers.SelectedRows[0];
                    selecteRecordId = Convert.ToInt32(dr.Cells["LoginID"].Value.ToString());
                    FillForm(selecteRecordId);
                }
                else 
                {
                    MakeEmpty();
                }
                Cursor = Cursors.Default;
            }
              
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (validate())
                {
                    LoginBAL _objBAL = new LoginBAL();
                    LoginModel _objModel = new LoginModel();
                    _objModel._LoginID = selecteRecordId;
                    _objModel._Username = tbxUsername.Text;
                    _objModel._Password = tbxPassword.Text;
                    _objModel._EmailAddress = tbxEmail.Text;
                    _objModel._ModifiedDate = DateTime.Now;
                    _objModel._UserRole = Convert.ToInt32(cmbRole.SelectedIndex);
                    if (selecteRecordId == 0)
                    {
                        _objBAL.SaveUser(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateUser(_objModel);
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
            if (selecteRecordId != 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    LoginBAL _objBAL = new LoginBAL();
                    _objBAL.DeleteUser(selecteRecordId);
                    MessageBox.Show("Record has been deleted successfully!");
                    FillGrid();
                    Cursor = Cursors.Default;
                    MakeEmpty();
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


            }
        }

        private void tbxUsername_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsUsernameValid(tbxUsername.Text);
            //if (bTest == false)
            //{
            //    this.errorProvider1.SetError(tbxUsername, "Username must be alphanumaric");
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxUsername, "");
            //}
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsEmailValid(tbxEmail.Text);
            //if (bTest == false)
            //{
            //    btnSave.Enabled = false;
            //    this.errorProvider1.SetError(tbxEmail, "Enter correct Email Address");
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxEmail, "");
            //    btnSave.Enabled = true;
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validate()
        {
            errors = new StringBuilder();
            //Validate First Name and Last Name
            validator = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!validator.Match(tbxEmail.Text.Trim()).Success)
                errors.AppendLine("Email is not in the proper format.");
            if (tbxUsername.Text=="")
                errors.AppendLine("Username cannot be empty");
            if (tbxPassword.Text == "")
                errors.AppendLine("Password cannot be empty");
            if (cmbRole.SelectedIndex==-1)
                errors.AppendLine("Select role from list");


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

