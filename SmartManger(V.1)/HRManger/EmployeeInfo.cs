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
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace SmartManger_V._1_.HRManger
{
    public partial class EmployeeInfo : Form
    {
        public int selectedRecordId = 0;
        private StringBuilder errors;
        private Regex validator;

        public EmployeeInfo(int Value)
        {
            InitializeComponent();
            selectedRecordId = Value;
        }

        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private Int32 GetMaxCode()
        {
            EmployeeBAL _ObjBAL = new EmployeeBAL();
            return (_ObjBAL.GetMaxCode());
        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            FillDesignationList();
            FillDepartmentList();
            FillShiftList();
            if (selectedRecordId != 0)
            {
                FillForm(selectedRecordId);
            }
            else 
            {
                MakeEmpty();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxAL_TextChanged(object sender, EventArgs e)
        {

        }

        private void MakeEmpty()
        {
            tbxAL.Text = "15";
            tbxCL.Text = "10";
            tbxCNIC.Text = "";
            tbxEmployeeCode.Text = "";
            tbxFatherName.Text = "";
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxMobileNo.Text = "";
            tbxSalary.Text = "";
            tbxSL.Text = "8";
            dtpDOB.Text = "";
            dtpDOJ.Text = "";
            tbxResignDate.Text = "";
            cmbDepartment.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;
            cbxIsActive.Checked = true;
            cbxMarried.Checked = false;
            richTextBox1.Text = "";

            selectedRecordId = 0;
        }

        public void FillForm(Int32 _EmployeeId)
        {
            try
            {
                EmployeeBAL _objBAL = new EmployeeBAL();
                EmployeeModel _objModel = _objBAL.SearchEmployee(_EmployeeId);
                tbxAL.Text = _objModel._AL.ToString();
                tbxCL.Text = _objModel._CL.ToString();
                tbxCNIC.Text = _objModel._CNIC;
                tbxEmployeeCode.Text = _objModel._Code.ToString();
                tbxFatherName.Text = _objModel._FatherName;
                tbxFirstName.Text = _objModel._FirstName;
                tbxLastName.Text = _objModel._LastName;
                tbxMobileNo.Text = _objModel._MobileNo;
                tbxSalary.Text = _objModel._Salary.ToString();
                tbxSL.Text = _objModel._SL.ToString();
                dtpDOB.Text = _objModel._DOB.ToString();
                dtpDOJ.Text = _objModel._DOJ.ToString();
                cmbDepartment.SelectedValue = _objModel._DepartmentID;
                cmbDesignation.SelectedValue = _objModel._DesignationID;
                cmbShift.SelectedValue = _objModel._ShiftID;
                cbxIsActive.Checked = _objModel._IsActive;
                cbxMarried.Checked = _objModel._IsMarried;
                richTextBox1.Text = _objModel._Address;
                tbxResignDate.Text = _objModel._ResignDate;
                pictureBox1.ImageLocation = string.IsNullOrEmpty(_objModel._ImageUrl) ? "F:\\Final Year Project\\Final\\SmartManger(V.1)\\SmartManger(V.1)\\Resources\\User_Avatar-128.png" : _objModel._ImageUrl;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog open = new OpenFileDialog();
            //    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            //    if (open.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image = new Bitmap(open.FileName);
            //    }
            //    string iname = open.FileName;

            //}
            //catch (Exception)
            //{
            //    throw new ApplicationException("Failed loading image");
            //}
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\TempImages\";
            if (Directory.Exists(appPath) == false)
            {
                Directory.CreateDirectory(appPath);
            }
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;
                    string filepath = opFile.FileName;

                    File.Copy(filepath, appPath + iName);
                    pictureBox1.Image = new Bitmap(opFile.OpenFile());
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MakeEmpty();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRecordId != 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    EmployeeBAL _objBAL = new EmployeeBAL();
                    _objBAL.DeleteEmployee(selectedRecordId);
                    MessageBox.Show("Record has been deleted successfully!");
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

                MakeEmpty();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {bool save=false;
            Cursor = Cursors.WaitCursor;
            try
            {
                if (validate())
                {  save=true;
                    EmployeeBAL _objBAL = new EmployeeBAL();
                    EmployeeModel _objModel = new EmployeeModel();

                    _objModel._Address = richTextBox1.Text;
                    _objModel._AL = Convert.ToInt32(tbxAL.Text);
                    _objModel._CL = Convert.ToInt32(tbxCL.Text);
                    _objModel._SL = Convert.ToInt32(tbxSL.Text);
                    _objModel._CNIC = tbxCNIC.Text;
                    _objModel._Code = GetMaxCode();
                    _objModel._DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                    _objModel._DesignationID = Convert.ToInt32(cmbDesignation.SelectedValue);
                    _objModel._DOB = Convert.ToDateTime(dtpDOB.Text);
                    _objModel._DOJ = Convert.ToDateTime(dtpDOJ.Text);
                    _objModel._EmployeeID = selectedRecordId;
                    _objModel._FatherName = tbxFatherName.Text;
                    _objModel._FirstName = tbxFirstName.Text;
                    _objModel._IsActive = cbxIsActive.Checked;
                    _objModel._IsMarried = cbxMarried.Checked;
                    _objModel._LastName = tbxLastName.Text;
                    _objModel._MobileNo = tbxMobileNo.Text;
                    _objModel._Descripition = "";
                    _objModel._Salary = Convert.ToDouble((tbxSalary.Text == "") ? "0" : tbxSalary.Text);
                    _objModel._ShiftID = Convert.ToInt32(cmbShift.SelectedValue);

                    string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Images\";
                    if (Directory.Exists(appPath) == false)
                    {
                        Directory.CreateDirectory(appPath);
                    }
                    pictureBox1.Image.Save(appPath + _objModel._EmployeeID + ".png", ImageFormat.Png);

                    _objModel._ImageUrl = appPath + _objModel._EmployeeID + ".png";
                    _objModel._ModifiedDate = SmartManger.BAL.Common.DateNow();
                    if (selectedRecordId == 0)
                    {
                        _objBAL.SaveEmployee(_objModel);
                    }
                    else
                    {
                        _objBAL.UpdateEmployee(_objModel);
                    }
                    MakeEmpty();

                    MessageBox.Show("Record Saved Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
                if (save)
                {
                    this.Close();
                }
            }
        }

        private void cmbDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        //private void DayLoad()
        //{
        //    cmbRestDay.Items.Add("Monday");
        //    cmbRestDay.Items.Add("Tuseday");
        //    cmbRestDay.Items.Add("Wednesday");
        //    cmbRestDay.Items.Add("Thursday");
        //    cmbRestDay.Items.Add("Friday");
        //    cmbRestDay.Items.Add("Saturday");
        //    cmbRestDay.Items.Add("Sunday");
        //}

        private void FillDesignationList()
        {

            DesignationBAL _objBAL = new DesignationBAL();
            List<DesignationModel> DesignationList = new List<DesignationModel>();
            DesignationList = _objBAL.GetDesignationList();
            cmbDesignation.DataSource = DesignationList;
            cmbDesignation.DisplayMember = "_DesgName";
            cmbDesignation.ValueMember = "_DesgID";
            cmbDesignation.SelectedIndex = -1;
            cmbDesignation.Text = "Select Designation";
        }

        private void FillDepartmentList()
        {
            DepartmentBAL _objBAL = new DepartmentBAL();
            List<DepartmentModel> DepartmentList = new List<DepartmentModel>();
            DepartmentList = _objBAL.GetDepartmentList();
            cmbDepartment.DataSource = DepartmentList;
            cmbDepartment.DisplayMember = "_DeptName";
            cmbDepartment.ValueMember = "_DeptID";
            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "Select Department";
        }

        private void FillShiftList()
        {
            ShiftBAL _objBAL = new ShiftBAL();
            List<ShiftModel> ShiftList = new List<ShiftModel>();
            ShiftList = _objBAL.GetShiftList();
            cmbShift.DataSource = ShiftList;
            cmbShift.DisplayMember = "_ShiftName";
            cmbShift.ValueMember = "_ShiftID";
            cmbShift.SelectedIndex = -1;
            cmbShift.Text = "Select Shift";
        }

        private void cbxIsActive_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "F:\\Final Year Project\\Final\\SmartManger(V.1)\\SmartManger(V.1)\\Resources\\User_Avatar-128.png";
        }

        private void tbxFirstName_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsName(tbxFirstName.Text);
            //if (bTest == false)
            //{
            //    this.errorProvider1.SetError(tbxFirstName, "Enter alphabets only");
            //    btnSave.Enabled = false;
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxFirstName, "");
            //    btnSave.Enabled = true;
            //}
        }

        private void tbxLastName_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsName(tbxLastName.Text);
            //if (bTest == false)
            //{
            //    this.errorProvider1.SetError(tbxLastName, "Enter alphabets only");
            //    btnSave.Enabled = false;
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxLastName, "");
            //    btnSave.Enabled = true;
            //}
        }

        private void tbxFatherName_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsName(tbxFatherName.Text);
            //if (bTest == false)
            //{
            //    this.errorProvider1.SetError(tbxFatherName, "Enter alphabets only");
            //    btnSave.Enabled = false;
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxFatherName, "");
            //    btnSave.Enabled = true;
            //}
        }

        private void tbxMobileNo_Validated(object sender, EventArgs e)
        {
            //bool bTest = Validations.IsMobileNo(tbxMobileNo.Text);
            //if (bTest == false)
            //{
            //    this.errorProvider1.SetError(tbxMobileNo, "+923001234567 or 0092 3001234567");
            //    btnSave.Enabled = false;
            //}
            //else
            //{
            //    this.errorProvider1.SetError(tbxMobileNo, "");
            //    btnSave.Enabled = true;
            //}
        }

        private void tbxCNIC_TextChanged(object sender, EventArgs e)
        {
            ////bool bTest = Validations.IsCNIC(tbxCNIC.Text);
            ////if (bTest == false)
            ////{
            ////    this.errorProvider1.SetError(tbxCNIC, "12345-1234567-1");
            ////    btnSave.Enabled = false;
            ////}
            ////else
            ////{
            ////    this.errorProvider1.SetError(tbxCNIC, "");
            ////    btnSave.Enabled = true;
            ////}
        }
        private bool validate()
        {
            errors = new StringBuilder();
            //Validate First Name and Last Name
            validator = new Regex(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$");
            if (!validator.Match(tbxFirstName.Text.Trim()).Success)
                errors.AppendLine("First name is not in the proper format.");
            if (!validator.Match(tbxLastName.Text.Trim()).Success)
                errors.AppendLine("Last name is not in the proper format.");
            if (!validator.Match(tbxFatherName.Text.Trim()).Success)
                errors.AppendLine("Father name is not in the proper format.");
            validator = new Regex(@"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$");
            if (!validator.Match(tbxMobileNo.Text.Trim()).Success)
                errors.AppendLine("CNIC No must be like 0092-312-234567");
            validator = new Regex(@"^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$");
            if (!validator.Match(tbxCNIC.Text.Trim()).Success)
                errors.AppendLine("Mobile No must be like 12345-1234567-1");
            if(cmbDepartment.SelectedIndex==-1)
                errors.AppendLine("Select Department from List");
            if (cmbDesignation.SelectedIndex==-1)
                errors.AppendLine("Select Designation from List");
            if (cmbShift.SelectedIndex == -1)
                errors.AppendLine("Select Shift from List");
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

