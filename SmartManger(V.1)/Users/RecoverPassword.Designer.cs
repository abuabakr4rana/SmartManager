namespace SmartManger_V._1_.Users
{
    partial class RecoverPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.gbxResult = new System.Windows.Forms.GroupBox();
            this.tbxMesage = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Username Below:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(84, 63);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(166, 60);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(179, 20);
            this.tbxUsername.TabIndex = 2;
            this.tbxUsername.Validated += new System.EventHandler(this.tbxUsername_Validated);
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(222, 91);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(123, 23);
            this.btnRecover.TabIndex = 3;
            this.btnRecover.Text = "Recover Password";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // gbxResult
            // 
            this.gbxResult.Controls.Add(this.tbxMesage);
            this.gbxResult.Enabled = false;
            this.gbxResult.Location = new System.Drawing.Point(84, 129);
            this.gbxResult.Name = "gbxResult";
            this.gbxResult.Size = new System.Drawing.Size(261, 118);
            this.gbxResult.TabIndex = 4;
            this.gbxResult.TabStop = false;
            this.gbxResult.Text = "Notification";
            // 
            // tbxMesage
            // 
            this.tbxMesage.Location = new System.Drawing.Point(6, 19);
            this.tbxMesage.Name = "tbxMesage";
            this.tbxMesage.Size = new System.Drawing.Size(249, 93);
            this.tbxMesage.TabIndex = 0;
            this.tbxMesage.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RecoverPassword
            // 
            this.AcceptButton = this.btnRecover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 259);
            this.Controls.Add(this.gbxResult);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "RecoverPassword";
            this.Text = "RecoverPassword";
            this.gbxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.GroupBox gbxResult;
        private System.Windows.Forms.RichTextBox tbxMesage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}