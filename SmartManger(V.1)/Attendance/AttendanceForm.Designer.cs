namespace SmartManger_V._1_.Attendance
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeIN = new System.Windows.Forms.DateTimePicker();
            this.dtpAttendanceDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.tbxDesignation = new System.Windows.Forms.TextBox();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxEmployeeCode = new System.Windows.Forms.TextBox();
            this.gbxLeaves = new System.Windows.Forms.GroupBox();
            this.tbxSickLeave = new System.Windows.Forms.TextBox();
            this.tbxCasualLeave = new System.Windows.Forms.TextBox();
            this.tbxAnnualLeave = new System.Windows.Forms.TextBox();
            this.rdbSickLeave = new System.Windows.Forms.RadioButton();
            this.rdbCasual = new System.Windows.Forms.RadioButton();
            this.rdbAnnual = new System.Windows.Forms.RadioButton();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.rdbHoliday = new System.Windows.Forms.RadioButton();
            this.rdbLeave = new System.Windows.Forms.RadioButton();
            this.rdbAbsent = new System.Windows.Forms.RadioButton();
            this.rdbPresent = new System.Windows.Forms.RadioButton();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxLeaves.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTimeOut);
            this.groupBox1.Controls.Add(this.dtpTimeIN);
            this.groupBox1.Controls.Add(this.dtpAttendanceDate);
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.tbxDesignation);
            this.groupBox1.Controls.Add(this.tbxDepartment);
            this.groupBox1.Controls.Add(this.tbxEmployeeCode);
            this.groupBox1.Controls.Add(this.gbxLeaves);
            this.groupBox1.Controls.Add(this.gbxStatus);
            this.groupBox1.Controls.Add(this.lblTimeOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Controls.Add(this.lblEmployeeCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mark Attendance";
            // 
            // dtpTimeOut
            // 
            this.dtpTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeOut.Location = new System.Drawing.Point(180, 257);
            this.dtpTimeOut.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpTimeOut.Name = "dtpTimeOut";
            this.dtpTimeOut.Size = new System.Drawing.Size(213, 20);
            this.dtpTimeOut.TabIndex = 15;
            this.dtpTimeOut.Value = new System.DateTime(2015, 11, 10, 0, 0, 0, 0);
            // 
            // dtpTimeIN
            // 
            this.dtpTimeIN.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeIN.Location = new System.Drawing.Point(180, 226);
            this.dtpTimeIN.Name = "dtpTimeIN";
            this.dtpTimeIN.Size = new System.Drawing.Size(213, 20);
            this.dtpTimeIN.TabIndex = 14;
            // 
            // dtpAttendanceDate
            // 
            this.dtpAttendanceDate.Location = new System.Drawing.Point(180, 190);
            this.dtpAttendanceDate.Name = "dtpAttendanceDate";
            this.dtpAttendanceDate.Size = new System.Drawing.Size(213, 20);
            this.dtpAttendanceDate.TabIndex = 13;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(180, 77);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(213, 21);
            this.cmbEmployee.TabIndex = 12;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // tbxDesignation
            // 
            this.tbxDesignation.Enabled = false;
            this.tbxDesignation.Location = new System.Drawing.Point(178, 159);
            this.tbxDesignation.Name = "tbxDesignation";
            this.tbxDesignation.Size = new System.Drawing.Size(215, 20);
            this.tbxDesignation.TabIndex = 11;
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Enabled = false;
            this.tbxDepartment.Location = new System.Drawing.Point(178, 115);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(215, 20);
            this.tbxDepartment.TabIndex = 10;
            // 
            // tbxEmployeeCode
            // 
            this.tbxEmployeeCode.Enabled = false;
            this.tbxEmployeeCode.Location = new System.Drawing.Point(178, 43);
            this.tbxEmployeeCode.Name = "tbxEmployeeCode";
            this.tbxEmployeeCode.Size = new System.Drawing.Size(215, 20);
            this.tbxEmployeeCode.TabIndex = 9;
            // 
            // gbxLeaves
            // 
            this.gbxLeaves.Controls.Add(this.tbxSickLeave);
            this.gbxLeaves.Controls.Add(this.tbxCasualLeave);
            this.gbxLeaves.Controls.Add(this.tbxAnnualLeave);
            this.gbxLeaves.Controls.Add(this.rdbSickLeave);
            this.gbxLeaves.Controls.Add(this.rdbCasual);
            this.gbxLeaves.Controls.Add(this.rdbAnnual);
            this.gbxLeaves.Location = new System.Drawing.Point(22, 344);
            this.gbxLeaves.Name = "gbxLeaves";
            this.gbxLeaves.Size = new System.Drawing.Size(402, 95);
            this.gbxLeaves.TabIndex = 8;
            this.gbxLeaves.TabStop = false;
            this.gbxLeaves.Text = "Leaves";
            // 
            // tbxSickLeave
            // 
            this.tbxSickLeave.Enabled = false;
            this.tbxSickLeave.Location = new System.Drawing.Point(285, 54);
            this.tbxSickLeave.Name = "tbxSickLeave";
            this.tbxSickLeave.Size = new System.Drawing.Size(86, 20);
            this.tbxSickLeave.TabIndex = 5;
            // 
            // tbxCasualLeave
            // 
            this.tbxCasualLeave.Enabled = false;
            this.tbxCasualLeave.Location = new System.Drawing.Point(156, 54);
            this.tbxCasualLeave.Name = "tbxCasualLeave";
            this.tbxCasualLeave.Size = new System.Drawing.Size(86, 20);
            this.tbxCasualLeave.TabIndex = 4;
            // 
            // tbxAnnualLeave
            // 
            this.tbxAnnualLeave.Enabled = false;
            this.tbxAnnualLeave.Location = new System.Drawing.Point(26, 54);
            this.tbxAnnualLeave.Name = "tbxAnnualLeave";
            this.tbxAnnualLeave.Size = new System.Drawing.Size(86, 20);
            this.tbxAnnualLeave.TabIndex = 3;
            // 
            // rdbSickLeave
            // 
            this.rdbSickLeave.AutoSize = true;
            this.rdbSickLeave.Enabled = false;
            this.rdbSickLeave.Location = new System.Drawing.Point(292, 19);
            this.rdbSickLeave.Name = "rdbSickLeave";
            this.rdbSickLeave.Size = new System.Drawing.Size(79, 17);
            this.rdbSickLeave.TabIndex = 2;
            this.rdbSickLeave.TabStop = true;
            this.rdbSickLeave.Text = "Sick Leave";
            this.rdbSickLeave.UseVisualStyleBackColor = true;
            // 
            // rdbCasual
            // 
            this.rdbCasual.AutoSize = true;
            this.rdbCasual.Enabled = false;
            this.rdbCasual.Location = new System.Drawing.Point(156, 20);
            this.rdbCasual.Name = "rdbCasual";
            this.rdbCasual.Size = new System.Drawing.Size(90, 17);
            this.rdbCasual.TabIndex = 1;
            this.rdbCasual.TabStop = true;
            this.rdbCasual.Text = "Casual Leave";
            this.rdbCasual.UseVisualStyleBackColor = true;
            // 
            // rdbAnnual
            // 
            this.rdbAnnual.AutoSize = true;
            this.rdbAnnual.Enabled = false;
            this.rdbAnnual.Location = new System.Drawing.Point(27, 20);
            this.rdbAnnual.Name = "rdbAnnual";
            this.rdbAnnual.Size = new System.Drawing.Size(91, 17);
            this.rdbAnnual.TabIndex = 0;
            this.rdbAnnual.TabStop = true;
            this.rdbAnnual.Text = "Annual Leave";
            this.rdbAnnual.UseVisualStyleBackColor = true;
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.rdbHoliday);
            this.gbxStatus.Controls.Add(this.rdbLeave);
            this.gbxStatus.Controls.Add(this.rdbAbsent);
            this.gbxStatus.Controls.Add(this.rdbPresent);
            this.gbxStatus.Location = new System.Drawing.Point(22, 283);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(402, 55);
            this.gbxStatus.TabIndex = 7;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status";
            // 
            // rdbHoliday
            // 
            this.rdbHoliday.AutoSize = true;
            this.rdbHoliday.Location = new System.Drawing.Point(307, 22);
            this.rdbHoliday.Name = "rdbHoliday";
            this.rdbHoliday.Size = new System.Drawing.Size(60, 17);
            this.rdbHoliday.TabIndex = 3;
            this.rdbHoliday.TabStop = true;
            this.rdbHoliday.Text = "Holiday";
            this.rdbHoliday.UseVisualStyleBackColor = true;
            this.rdbHoliday.CheckedChanged += new System.EventHandler(this.rdbHoliday_CheckedChanged);
            // 
            // rdbLeave
            // 
            this.rdbLeave.AutoSize = true;
            this.rdbLeave.Enabled = false;
            this.rdbLeave.Location = new System.Drawing.Point(230, 22);
            this.rdbLeave.Name = "rdbLeave";
            this.rdbLeave.Size = new System.Drawing.Size(55, 17);
            this.rdbLeave.TabIndex = 2;
            this.rdbLeave.TabStop = true;
            this.rdbLeave.Text = "Leave";
            this.rdbLeave.UseVisualStyleBackColor = true;
            this.rdbLeave.CheckedChanged += new System.EventHandler(this.rdbLeave_CheckedChanged);
            // 
            // rdbAbsent
            // 
            this.rdbAbsent.AutoSize = true;
            this.rdbAbsent.Location = new System.Drawing.Point(130, 22);
            this.rdbAbsent.Name = "rdbAbsent";
            this.rdbAbsent.Size = new System.Drawing.Size(58, 17);
            this.rdbAbsent.TabIndex = 1;
            this.rdbAbsent.TabStop = true;
            this.rdbAbsent.Text = "Absent";
            this.rdbAbsent.UseVisualStyleBackColor = true;
            this.rdbAbsent.CheckedChanged += new System.EventHandler(this.rdbAbsent_CheckedChanged);
            // 
            // rdbPresent
            // 
            this.rdbPresent.AutoSize = true;
            this.rdbPresent.Location = new System.Drawing.Point(26, 22);
            this.rdbPresent.Name = "rdbPresent";
            this.rdbPresent.Size = new System.Drawing.Size(61, 17);
            this.rdbPresent.TabIndex = 0;
            this.rdbPresent.TabStop = true;
            this.rdbPresent.Text = "Present";
            this.rdbPresent.UseVisualStyleBackColor = true;
            this.rdbPresent.CheckedChanged += new System.EventHandler(this.rdbPresent_CheckedChanged);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(78, 263);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(56, 13);
            this.lblTimeOut.TabIndex = 6;
            this.lblTimeOut.Text = "Time OUT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time IN";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(78, 198);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(78, 159);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(63, 13);
            this.lblDesignation.TabIndex = 3;
            this.lblDesignation.Text = "Designation";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(78, 122);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(78, 84);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(78, 43);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::SmartManger_V._1_.Properties.Resources._1447781857_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(264, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::SmartManger_V._1_.Properties.Resources._1447785234_Log_Out;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(356, 465);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AttendanceForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxLeaves.ResumeLayout(false);
            this.gbxLeaves.PerformLayout();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxStatus;
        private System.Windows.Forms.RadioButton rdbLeave;
        private System.Windows.Forms.RadioButton rdbAbsent;
        private System.Windows.Forms.RadioButton rdbPresent;
        private System.Windows.Forms.GroupBox gbxLeaves;
        private System.Windows.Forms.RadioButton rdbSickLeave;
        private System.Windows.Forms.RadioButton rdbCasual;
        private System.Windows.Forms.RadioButton rdbAnnual;
        private System.Windows.Forms.TextBox tbxDesignation;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.TextBox tbxEmployeeCode;
        private System.Windows.Forms.DateTimePicker dtpTimeOut;
        private System.Windows.Forms.DateTimePicker dtpTimeIN;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbHoliday;
        private System.Windows.Forms.TextBox tbxSickLeave;
        private System.Windows.Forms.TextBox tbxCasualLeave;
        private System.Windows.Forms.TextBox tbxAnnualLeave;
    }
}