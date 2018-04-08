using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using SmartManager.Models;
namespace SmartManger.DAL
{
    public class LoginDAL
    {
        SqlCommand cmd = new SqlCommand();
        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);
        public Int32 SaveUser(LoginModel _Objlogin) 
        {
            int result=0;
            try
            {
                cmd = new SqlCommand("usp_UserLogin_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName",_Objlogin._Username);
                cmd.Parameters.AddWithValue("@Password",_Objlogin._Password);
                cmd.Parameters.AddWithValue("@EmailAddress", _Objlogin._EmailAddress);
                cmd.Parameters.AddWithValue("@UserRole", _Objlogin._UserRole);
                cmd.Parameters.AddWithValue("@ModifiedDate", _Objlogin._ModifiedDate);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                    result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return 0;
                    }         
                
            }
            catch(Exception ex)
            {
                throw (ex);
            }
            finally 
            {
                if (con.State != ConnectionState.Closed) 
                {
                    con.Close();
                }
            }
            
        }

        public Int32 UpdateUser(LoginModel _Objlogin)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_UserLogin_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", _Objlogin._Username);
                cmd.Parameters.AddWithValue("@Password", _Objlogin._Password);
                cmd.Parameters.AddWithValue("@EmailAddress", _Objlogin._EmailAddress);
                cmd.Parameters.AddWithValue("@UserRole", _Objlogin._UserRole);
                cmd.Parameters.AddWithValue("@ModifiedDate", _Objlogin._ModifiedDate);
                cmd.Parameters.AddWithValue("@LoginID",_Objlogin._LoginID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                } 
                    result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    if (result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        return 0;
                    }
                
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }

        public DataTable SearchUser(Int32 _userid)
        {
            DataTable dt = new DataTable();
            try
            {
                 cmd = new SqlCommand("usp_UserLogin_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", _userid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                cmd.Dispose();
            }

            catch(Exception ex)
            {
                throw ex;
            }
            finally 
            {
                dt.Dispose();
            }
            return dt;
        }

        public DataTable SearchByUsername(string _Username) 
        {
            DataTable dt = new DataTable();
            try
            {
                 cmd = new SqlCommand("usp_UserLogin_GetByUsername", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", _Username);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
               adp.Fill(dt);
               cmd.Dispose();
            }
            catch
            {
            }
            finally 
            {
                dt.Dispose();
            }
            return dt;
        }

        public SqlDataReader GetUsers() 
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }    
                 cmd = new SqlCommand("usp_UserLogin_GetUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
               SqlDataReader dr = cmd.ExecuteReader();
                //cmd.Dispose();
               return dr;
                           
                       
        }

        public Int32 DeleteUser(Int32 _LoginID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_UserLogin_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoginID",_LoginID);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                if (result > 0)
                {
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }


        public DataTable FillRoleList() 
        {
            string query = "Select * from UserRole";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
