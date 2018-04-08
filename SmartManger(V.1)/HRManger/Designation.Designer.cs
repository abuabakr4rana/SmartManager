namespace SmartManger_V._1_.HRManger
{
    partial class Designation
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
            this.grdDesignation = new System.Windows.Forms.DataGridView();
            this.DesgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOdifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationDetail = new System.Windows.Forms.GroupBox();
            this.cmbIsActive = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxModifiedDate = new System.Windows.Forms.TextBox();
            this.tbxDesignationName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxOtherInformation = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDesignation)).BeginInit();
            this.DesignationDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdDesignation);
            this.groupBox1.Location = new System.Drawing.Point(36, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Designations";
            // 
            // grdDesignation
            // 
            this.grdDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesgId,
            this.DesgName,
            this.IsActive,
            this.MOdifiedDate,
            this.Description});
            this.grdDesignation.Location = new System.Drawing.Point(22, 35);
            this.grdDesignation.Name = "grdDesignation";
            this.grdDesignation.Size = new System.Drawing.Size(530, 305);
            this.grdDesignation.TabIndex = 0;
            this.grdDesignation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdDesignation_RowHeaderMouseClick);
            // 
            // DesgId
            // 
            this.DesgId.HeaderText = "DesigId";
            this.DesgId.Name = "DesgId";
            this.DesgId.Visible = false;
            // 
            // DesgName
            // 
            this.DesgName.HeaderText = "Designation Name";
            this.DesgName.Name = "DesgName";
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            // 
            // MOdifiedDate
            // 
            this.MOdifiedDate.HeaderText = "Modified Date";
            this.MOdifiedDate.Name = "MOdifiedDate";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 190;
            // 
            // DesignationDetail
            // 
            this.DesignationDetail.Controls.Add(this.cmbIsActive);
            this.DesignationDetail.Controls.Add(this.label4);
            this.DesignationDetail.Controls.Add(this.label3);
            this.DesignationDetail.Controls.Add(this.label2);
            this.DesignationDetail.Controls.Add(this.label1);
            this.DesignationDetail.Controls.Add(this.tbxDescription);
            this.DesignationDetail.Controls.Add(this.tbxModifiedDate);
            this.DesignationDetail.Controls.Add(this.tbxDesignationName);
            this.DesignationDetail.Location = new System.Drawing.Point(653, 58);
            this.DesignationDetail.Name = "DesignationDetail";
            this.DesignationDetail.Size = new System.Drawing.Size(372, 187);
            this.DesignationDetail.TabIndex = 0;
            this.DesignationDetail.TabStop = false;
            this.DesignationDetail.Text = "Desgnation Detail";
            // 
            // cmbIsActive
            // 
            this.cmbIsActive.FormattingEnabled = true;
            this.cmbIsActive.Location = new System.Drawing.Point(189, 149);
            this.cmbIsActive.Name = "cmbIsActive";
            this.cmbIsActive.Size = new System.Drawing.Size(165, 21);
            this.cmbIsActive.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modified Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designation Name";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(189, 113);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(165, 20);
            this.tbxDescription.TabIndex = 2;
            // 
            // tbxModifiedDate
            // 
            this.tbxModifiedDate.Enabled = false;
            this.tbxModifiedDate.Location = new System.Drawing.Point(189, 74);
            this.tbxModifiedDate.Name = "tbxModifiedDate";
            this.tbxModifiedDate.Size = new System.Drawing.Size(165, 20);
            this.tbxModifiedDate.TabIndex = 1;
            // 
            // tbxDesignationName
            // 
            this.tbxDesignationName.Location = new System.Drawing.Point(189, 30);
            this.tbxDesignationName.Name = "tbxDesignationName";
            this.tbxDesignationName.Size = new System.Drawing.Size(165, 20);
            this.tbxDesignationName.TabIndex = 0;
            this.tbxDesignationName.Validated += new System.EventHandler(this.tbxDesignationName_Validated);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxOtherInformation);
            this.groupBox3.Location = new System.Drawing.Point(654, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Information";
            // 
            // tbxOtherInformation
            // 
            this.tbxOtherInformation.Enabled = false;
            this.tbxOtherInformation.Location = new System.Drawing.Point(7, 20);
            this.tbxOtherInformation.Name = "tbxOtherInformation";
            this.tbxOtherInformation.Size = new System.Drawing.Size(359, 117);
            this.tbxOtherInformation.TabIndex = 0;
            this.tbxOtherInformation.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SmartManger_V._1_.Properties.Resources.add_icon;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(654, 429);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 40);
            this.btnNew.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(762, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 40);
            this.btnSave.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(848, 429);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SmartManger_V._1_.Properties.Resources._1447785234_Log_Out;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(945, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Records:";
            // 
            // tbxCount
            // 
            this.tbxCount.Enabled = false;
            this.tbxCount.Location = new System.Drawing.Point(116, 438);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxCount.TabIndex = 7;
            // 
            // Designation
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1073, 479);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DesignationDetail);
            this.Controls.Add(this.groupBox1);
            this.Name = "Designation";
            this.Text = "Designation";
            this.Load += new System.EventHandler(this.Designation_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDesignation)).EndInit();
            this.DesignationDetail.ResumeLayout(false);
            this.DesignationDetail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DesignationDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdDesignation;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxModifiedDate;
        private System.Windows.Forms.TextBox tbxDesignationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbxOtherInformation;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOdifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCount;
    }
}