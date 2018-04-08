namespace SmartManger_V._1_.HRManger
{
    partial class Holidays
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
            this.gbxHolidays = new System.Windows.Forms.GroupBox();
            this.grdHolidays = new System.Windows.Forms.DataGridView();
            this.HolidayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolidayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxHolidaysDetail = new System.Windows.Forms.GroupBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxModifiedDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHolidayDate = new System.Windows.Forms.DateTimePicker();
            this.gbxOtherInformation = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.gbxHolidays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHolidays)).BeginInit();
            this.gbxHolidaysDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHolidays
            // 
            this.gbxHolidays.Controls.Add(this.grdHolidays);
            this.gbxHolidays.Location = new System.Drawing.Point(34, 55);
            this.gbxHolidays.Name = "gbxHolidays";
            this.gbxHolidays.Size = new System.Drawing.Size(566, 363);
            this.gbxHolidays.TabIndex = 0;
            this.gbxHolidays.TabStop = false;
            this.gbxHolidays.Text = "Holidays";
            // 
            // grdHolidays
            // 
            this.grdHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHolidays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HolidayId,
            this.HolidayDate,
            this.ModifiedDate,
            this.Description});
            this.grdHolidays.Location = new System.Drawing.Point(19, 34);
            this.grdHolidays.Name = "grdHolidays";
            this.grdHolidays.Size = new System.Drawing.Size(530, 305);
            this.grdHolidays.TabIndex = 0;
            this.grdHolidays.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdHolidays_RowHeaderMouseClick);
            // 
            // HolidayId
            // 
            this.HolidayId.HeaderText = "HolidayId";
            this.HolidayId.Name = "HolidayId";
            this.HolidayId.Visible = false;
            // 
            // HolidayDate
            // 
            this.HolidayDate.HeaderText = "Hoiliday Date";
            this.HolidayDate.Name = "HolidayDate";
            this.HolidayDate.Width = 150;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.HeaderText = "Modified Date";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Width = 160;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 190;
            // 
            // gbxHolidaysDetail
            // 
            this.gbxHolidaysDetail.Controls.Add(this.tbxDescription);
            this.gbxHolidaysDetail.Controls.Add(this.label3);
            this.gbxHolidaysDetail.Controls.Add(this.tbxModifiedDate);
            this.gbxHolidaysDetail.Controls.Add(this.label2);
            this.gbxHolidaysDetail.Controls.Add(this.label1);
            this.gbxHolidaysDetail.Controls.Add(this.dtpHolidayDate);
            this.gbxHolidaysDetail.Location = new System.Drawing.Point(669, 53);
            this.gbxHolidaysDetail.Name = "gbxHolidaysDetail";
            this.gbxHolidaysDetail.Size = new System.Drawing.Size(372, 187);
            this.gbxHolidaysDetail.TabIndex = 1;
            this.gbxHolidaysDetail.TabStop = false;
            this.gbxHolidaysDetail.Text = "Holidays Detail";
            this.gbxHolidaysDetail.Enter += new System.EventHandler(this.gbxHolidaysDetail_Enter);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(208, 135);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(127, 20);
            this.tbxDescription.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discription";
            // 
            // tbxModifiedDate
            // 
            this.tbxModifiedDate.Enabled = false;
            this.tbxModifiedDate.Location = new System.Drawing.Point(208, 79);
            this.tbxModifiedDate.Name = "tbxModifiedDate";
            this.tbxModifiedDate.Size = new System.Drawing.Size(127, 20);
            this.tbxModifiedDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modified Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Holiday Date";
            // 
            // dtpHolidayDate
            // 
            this.dtpHolidayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHolidayDate.Location = new System.Drawing.Point(208, 24);
            this.dtpHolidayDate.Name = "dtpHolidayDate";
            this.dtpHolidayDate.Size = new System.Drawing.Size(127, 20);
            this.dtpHolidayDate.TabIndex = 0;
            // 
            // gbxOtherInformation
            // 
            this.gbxOtherInformation.Location = new System.Drawing.Point(669, 268);
            this.gbxOtherInformation.Name = "gbxOtherInformation";
            this.gbxOtherInformation.Size = new System.Drawing.Size(372, 143);
            this.gbxOtherInformation.TabIndex = 2;
            this.gbxOtherInformation.TabStop = false;
            this.gbxOtherInformation.Text = "Other Information";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SmartManger_V._1_.Properties.Resources.add_icon;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(673, 431);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 40);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SmartManger_V._1_.Properties.Resources._1447781857_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(773, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SmartManger_V._1_.Properties.Resources._1447781937_Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(867, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SmartManger_V._1_.Properties.Resources._1447785234_Log_Out;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(959, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TotalRecords:";
            // 
            // tbxCount
            // 
            this.tbxCount.Enabled = false;
            this.tbxCount.Location = new System.Drawing.Point(111, 442);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxCount.TabIndex = 8;
            // 
            // Holidays
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 479);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbxOtherInformation);
            this.Controls.Add(this.gbxHolidaysDetail);
            this.Controls.Add(this.gbxHolidays);
            this.Name = "Holidays";
            this.Text = "Holidays";
            this.Load += new System.EventHandler(this.Holidays_Load);
            this.gbxHolidays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHolidays)).EndInit();
            this.gbxHolidaysDetail.ResumeLayout(false);
            this.gbxHolidaysDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHolidays;
        private System.Windows.Forms.GroupBox gbxHolidaysDetail;
        private System.Windows.Forms.GroupBox gbxOtherInformation;
        private System.Windows.Forms.DataGridView grdHolidays;
        private System.Windows.Forms.DateTimePicker dtpHolidayDate;
        private System.Windows.Forms.TextBox tbxModifiedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolidayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCount;
    }
}