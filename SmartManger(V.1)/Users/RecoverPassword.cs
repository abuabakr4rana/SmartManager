using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartManger.BAL;
using System.Net.Mail;
using System.Net;
using SmartManager.Models;

namespace SmartManger_V._1_.Users
{
    public partial class RecoverPassword : Form
    {
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {   Cursor = Cursors.WaitCursor;   
            string emailaddress;
            string password;
            if (tbxUsername.Text == "")
            {
                gbxResult.Enabled = true;
                tbxMesage.Text = "Please enter a username!";
            }
            else 
            {
                LoginBAL _objBAL = new LoginBAL();
                DataTable dt = new DataTable();
                LoginModel _objModel = new LoginModel();
                     _objModel   =_objBAL.SearchByUserNme(tbxUsername.Text);
                if (_objModel!=null)
                {
                    if (tbxUsername.Text == _objModel._Username)
                    {

                        try
                        {
                           
                            emailaddress = _objModel._EmailAddress;
                            password = _objModel._Password;
                            SmtpClient client = new SmtpClient("smtp.gmail.com");
                            client.Port = 587;

                            client.EnableSsl = true;
                            client.Timeout = 100000;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential(
                              "smartmanager1122@gmail.com", "abubakar123");
                            MailMessage msg = new MailMessage();
                            msg.To.Add(emailaddress);
                            msg.From = new MailAddress("smartmanager1122@gmail.com");
                            msg.Subject = "Password Recovery ";
                            msg.Body = string.Format("Dear user your password of Smart Manager against username "+tbxUsername.Text+" is '" + password) + "'\n  Regards Admin Smart Manager.";
                            //Attachment data = new Attachment(textBox_Attachment.Text);
                            //msg.Attachments.Add(data);
                            client.Send(msg);
                            MessageBox.Show("Your Password has been sent to "+ emailaddress);
                            this.Close();
                        }
                        catch
                        {

                        }
                        finally 
                        {
                            Cursor = Cursors.Default;
                        }

                    }
                    else
                    {
                        gbxResult.Enabled = true;
                        tbxMesage.Text = "Please enter a valid usename!";
                    }
                }
                else 
                {
                    gbxResult.Enabled = true;
                    tbxMesage.Text = "Please enter a valid usename!";
                    Cursor = Cursors.Default;
                }
            }
        }

        private void tbxUsername_Validated(object sender, EventArgs e)
        {
           
        }
    }
}
