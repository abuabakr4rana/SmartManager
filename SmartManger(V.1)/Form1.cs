using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartManger_V._1_.Users;

namespace SmartManger_V._1_
{
    public partial class Form1 : Form
    {
       public Int32 hdfselectedrecord=0;
       SqlConnection con = new SqlConnection();
       SqlCommand _cmd;
       SqlDataAdapter _sda;
       string _connectionString = ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString;
        public Form1()
        {
                       
           InitializeComponent();
               
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                 con = new SqlConnection(_connectionString);
                con.Open();
                _cmd = new SqlCommand("select * from LoginUser  where username='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", con);
                _sda = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                _sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    int role=Convert.ToInt32( dt.Rows[0]["UserRole"]);
                    mdiMain mdiform = new mdiMain(role);
                    this.Hide();
                    mdiform.ShowDialog();
                    this.MakeEmpty();
                    this.Show();

                }
                else
                    if (dt.Rows.Count > 1)
                    {
                        MessageBox.Show("Username and password duplicate exist");
                    }
                    else
                    {
                        MessageBox.Show("Username or Password not Matched!");
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                con.Close(); 
            }
           
        }

        private void MakeEmpty()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecoverPassword recForm = new RecoverPassword();
            recForm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
