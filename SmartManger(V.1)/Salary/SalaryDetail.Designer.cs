namespace SmartManger_V._1_.Salary
{
    partial class SalaryDetail
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
            this.grdSalaryDetail = new System.Windows.Forms.DataGridView();
            this.SalarydetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSalaryDetail
            // 
            this.grdSalaryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalaryDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalarydetailId,
            this.SrNo,
            this.EmployeeName,
            this.Date,
            this.Presents,
            this.Absents,
            this.Leaves,
            this.Salary,
            this.Deduction,
            this.Total});
            this.grdSalaryDetail.Location = new System.Drawing.Point(13, 56);
            this.grdSalaryDetail.Name = "grdSalaryDetail";
            this.grdSalaryDetail.Size = new System.Drawing.Size(1048, 380);
            this.grdSalaryDetail.TabIndex = 0;
            this.grdSalaryDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSalaryDetail_CellContentClick);
            this.grdSalaryDetail.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdSalaryDetail_RowHeaderMouseClick);
            // 
            // SalarydetailId
            // 
            this.SalarydetailId.HeaderText = "SalarydetailId";
            this.SalarydetailId.Name = "SalarydetailId";
            this.SalarydetailId.Visible = false;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "SrNo";
            this.SrNo.Name = "SrNo";
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 180;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Presents
            // 
            this.Presents.HeaderText = "Presents";
            this.Presents.Name = "Presents";
            // 
            // Absents
            // 
            this.Absents.HeaderText = "Absents";
            this.Absents.Name = "Absents";
            // 
            // Leaves
            // 
            this.Leaves.HeaderText = "Leaves";
            this.Leaves.Name = "Leaves";
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // Deduction
            // 
            this.Deduction.HeaderText = "Deduction";
            this.Deduction.Name = "Deduction";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Records:";
            // 
            // tbxCount
            // 
            this.tbxCount.Enabled = false;
            this.tbxCount.Location = new System.Drawing.Point(96, 451);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(100, 20);
            this.tbxCount.TabIndex = 3;
            // 
            // SalaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 479);
            this.Controls.Add(this.tbxCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdSalaryDetail);
            this.Name = "SalaryDetail";
            this.Text = "SalaryDetail";
            this.Load += new System.EventHandler(this.SalaryDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalaryDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSalaryDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarydetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Absents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCount;
    }
}