namespace SmartManger_V._1_.HRManger
{
    partial class Shift
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdShifts = new System.Windows.Forms.DataGridView();
            this.ShiftId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxShiftDetail = new System.Windows.Forms.GroupBox();
            this.txtModifiedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShiftName = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.tbxModifiedDate = new System.Windows.Forms.TextBox();
            this.tbxShiftName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShifts)).BeginInit();
            this.gbxShiftDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdShifts);
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shifts";
            // 
            // grdShifts
            // 
            this.grdShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdShifts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShiftId,
            this.ShiftName,
            this.StartTime,
            this.EndTime,
            this.ModifiedDate});
            this.grdShifts.Location = new System.Drawing.Point(17, 36);
            this.grdShifts.Name = "grdShifts";
            this.grdShifts.Size = new System.Drawing.Size(530, 305);
            this.grdShifts.TabIndex = 0;
            this.grdShifts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdShifts_RowHeaderMouseClick);
            // 
            // ShiftId
            // 
            this.ShiftId.HeaderText = "ShiftId";
            this.ShiftId.Name = "ShiftId";
            this.ShiftId.Visible = false;
            // 
            // ShiftName
            // 
            this.ShiftName.HeaderText = "Shift Name";
            this.ShiftName.Name = "ShiftName";
            this.ShiftName.Width = 120;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 130;
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "End Time";
            this.EndTime.Name = "EndTime";
            this.EndTime.Width = 130;
            // 
            // ModifiedDate
            // 
            this.ModifiedDate.HeaderText = "Modified Date";
            this.ModifiedDate.Name = "ModifiedDate";
            this.ModifiedDate.Width = 130;
            // 
            // gbxShiftDetail
            // 
            this.gbxShiftDetail.Controls.Add(this.txtModifiedDate);
            this.gbxShiftDetail.Controls.Add(this.label3);
            this.gbxShiftDetail.Controls.Add(this.label2);
            this.gbxShiftDetail.Controls.Add(this.txtShiftName);
            this.gbxShiftDetail.Controls.Add(this.dtpEndTime);
            this.gbxShiftDetail.Controls.Add(this.dtpStartTime);
            this.gbxShiftDetail.Controls.Add(this.tbxModifiedDate);
            this.gbxShiftDetail.Controls.Add(this.tbxShiftName);
            this.gbxShiftDetail.Location = new System.Drawing.Point(672, 48);
            this.gbxShiftDetail.Name = "gbxShiftDetail";
            this.gbxShiftDetail.Size = new System.Drawing.Size(372, 187);
            this.gbxShiftDetail.TabIndex = 1;
            this.gbxShiftDetail.TabStop = false;
            this.gbxShiftDetail.Text = "Shift Detail";
            // 
            // txtModifiedDate
            // 
            this.txtModifiedDate.AutoSize = true;
            this.txtModifiedDate.Location = new System.Drawing.Point(69, 156);
            this.txtModifiedDate.Name = "txtModifiedDate";
            this.txtModifiedDate.Size = new System.Drawing.Size(73, 13);
            this.txtModifiedDate.TabIndex = 7;
            this.txtModifiedDate.Text = "Modified Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Time";
            // 
            // txtShiftName
            // 
            this.txtShiftName.AutoSize = true;
            this.txtShiftName.Location = new System.Drawing.Point(69, 45);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(59, 13);
            this.txtShiftName.TabIndex = 4;
            this.txtShiftName.Text = "Shift Name";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(231, 109);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(120, 20);
            this.dtpEndTime.TabIndex = 3;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(231, 77);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(120, 20);
            this.dtpStartTime.TabIndex = 2;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tbxModifiedDate
            // 
            this.tbxModifiedDate.Enabled = false;
            this.tbxModifiedDate.Location = new System.Drawing.Point(231, 149);
            this.tbxModifiedDate.Name = "tbxModifiedDate";
            this.tbxModifiedDate.Size = new System.Drawing.Size(120, 20);
            this.tbxModifiedDate.TabIndex = 1;
            this.tbxModifiedDate.TextChanged += new System.EventHandler(this.tbxModifiedDate_TextChanged);
            // 
            // tbxShiftName
            // 
            this.tbxShiftName.Location = new System.Drawing.Point(231, 42);
            this.tbxShiftName.Name = "tbxShiftName";
            this.tbxShiftName.Size = new System.Drawing.Size(120, 20);
            this.tbxShiftName.TabIndex = 0;
            this.tbxShiftName.Validated += new System.EventHandler(this.tbxShiftName_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(672, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Information";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SmartManger_V._1_.Properties.Resources.add_icon;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(672, 435);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 40);
            this.btnNew.TabIndex = 0;
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
            this.btnSave.Location = new System.Drawing.Point(784, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 1;
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
            this.btnDelete.Location = new System.Drawing.Point(888, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::SmartManger_V._1_.Properties.Resources._1447785234_Log_Out;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(981, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Records:";
            // 
            // tbxCount
            // 
            this.tbxCount.Enabled = false;
            this.tbxCount.Location = new System.Drawing.Point(121, 449);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxCount.TabIndex = 5;
            // 
            // Shift
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 479);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxShiftDetail);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Shift";
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.Shift_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdShifts)).EndInit();
            this.gbxShiftDetail.ResumeLayout(false);
            this.gbxShiftDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxShiftDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdShifts;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.TextBox tbxModifiedDate;
        private System.Windows.Forms.TextBox tbxShiftName;
        private System.Windows.Forms.Label txtModifiedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtShiftName;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Label label1;
    }
}