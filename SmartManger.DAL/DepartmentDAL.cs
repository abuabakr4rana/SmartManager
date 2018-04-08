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
  public  class DepartmentDAL
    {
        SqlCommand cmd = new SqlCommand();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);
        public Int32 SaveDepartment(DepartmentModel _ObjDepartment)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("usp_Department_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptName", _ObjDepartment._DeptName);
                cmd.Parameters.AddWithValue("@IsActive", _ObjDepartment._IsActive);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjDepartment._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjDepartment._Description);
                
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

        public Int32 UpdateDepartment(DepartmentModel _ObjDepartment)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_Department_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptName", _ObjDepartment._DeptName);
                cmd.Parameters.AddWithValue("@IsActive", _ObjDepartment._IsActive);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjDepartment._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjDepartment._Description);
                cmd.Parameters.AddWithValue("@DeptID ", _ObjDepartment._DeptID);
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

        public DataTable SearchDepartmet(Int32 _Deptid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("usp_Department_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptID", _Deptid);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                cmd.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dt.Dispose();
            }
            return dt;
        }

        public SqlDataReader GetDepartments()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("usp_Department_GetUsers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Dispose();
            return dr;


        }

        public Int32 DeleteDepartment(Int32 _DeptID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Department_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptId", _DeptID);
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



    }
    
}
