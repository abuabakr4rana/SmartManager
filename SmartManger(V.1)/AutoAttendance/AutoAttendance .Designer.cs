namespace SmartManger_V._1_.AutoAttendance
{
    partial class AutoAttendance
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
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxLastCheckedIn = new System.Windows.Forms.GroupBox();
            this.tbxDesignation = new System.Windows.Forms.TextBox();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxEmployeeName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.pbxEmployee = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.gbxLastCheckedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(143, 360);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(184, 21);
            this.cmbDevices.TabIndex = 7;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Device";
            // 
            // gbxLastCheckedIn
            // 
            this.gbxLastCheckedIn.Controls.Add(this.tbxDesignation);
            this.gbxLastCheckedIn.Controls.Add(this.tbxDepartment);
            this.gbxLastCheckedIn.Controls.Add(this.tbxCode);
            this.gbxLastCheckedIn.Controls.Add(this.tbxEmployeeName);
            this.gbxLastCheckedIn.Controls.Add(this.lblDesignation);
            this.gbxLastCheckedIn.Controls.Add(this.lblDepartment);
            this.gbxLastCheckedIn.Controls.Add(this.lblCode);
            this.gbxLastCheckedIn.Controls.Add(this.lblEmployeeName);
            this.gbxLastCheckedIn.Controls.Add(this.pbxEmployee);
            this.gbxLastCheckedIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxLastCheckedIn.Location = new System.Drawing.Point(477, 77);
            this.gbxLastCheckedIn.Name = "gbxLastCheckedIn";
            this.gbxLastCheckedIn.Size = new System.Drawing.Size(584, 375);
            this.gbxLastCheckedIn.TabIndex = 9;
            this.gbxLastCheckedIn.TabStop = false;
            this.gbxLastCheckedIn.Text = "Last Check In";
            // 
            // tbxDesignation
            // 
            this.tbxDesignation.Enabled = false;
            this.tbxDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesignation.Location = new System.Drawing.Point(148, 252);
            this.tbxDesignation.Name = "tbxDesignation";
            this.tbxDesignation.Size = new System.Drawing.Size(159, 22);
            this.tbxDesignation.TabIndex = 9;
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Enabled = false;
            this.tbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDepartment.Location = new System.Drawing.Point(148, 197);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(159, 22);
            this.tbxDepartment.TabIndex = 8;
            // 
            // tbxCode
            // 
            this.tbxCode.Enabled = false;
            this.tbxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.Location = new System.Drawing.Point(148, 144);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(159, 22);
            this.tbxCode.TabIndex = 7;
            // 
            // tbxEmployeeName
            // 
            this.tbxEmployeeName.Enabled = false;
            this.tbxEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmployeeName.Location = new System.Drawing.Point(148, 91);
            this.tbxEmployeeName.Name = "tbxEmployeeName";
            this.tbxEmployeeName.Size = new System.Drawing.Size(159, 22);
            this.tbxEmployeeName.TabIndex = 6;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(18, 258);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(91, 16);
            this.lblDesignation.TabIndex = 4;
            this.lblDesignation.Text = "Designation";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(18, 201);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(88, 16);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(18, 148);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 16);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(18, 96);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(123, 16);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.Image = global::SmartManger_V._1_.Properties.Resources.User_Avatar_128;
            this.pbxEmployee.Location = new System.Drawing.Point(369, 107);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(200, 200);
            this.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmployee.TabIndex = 0;
            this.pbxEmployee.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Image = global::SmartManger_V._1_.Properties.Resources._1447781937_Delete1;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.Location = new System.Drawing.Point(167, 402);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(120, 50);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::SmartManger_V._1_.Properties.Resources._1447781912_Play;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(23, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackgroundImage = global::SmartManger_V._1_.Properties.Resources.online_screen_recording4;
            this.imageBoxFrameGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(23, 12);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(440, 330);
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // AutoAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1073, 479);
            this.Controls.Add(this.gbxLastCheckedIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDevices);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Name = "AutoAttendance";
            this.Text = "AutoAttendance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoAttendance_FormClosing);
            this.Load += new System.EventHandler(this.AutoAttendance_Load);
            this.gbxLastCheckedIn.ResumeLayout(false);
            this.gbxLastCheckedIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxLastCheckedIn;
        private System.Windows.Forms.PictureBox pbxEmployee;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.TextBox tbxDesignation;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxEmployeeName;
    }
}