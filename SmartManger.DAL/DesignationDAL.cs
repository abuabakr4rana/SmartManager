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
   public class DesignationDAL
    {
        SqlCommand cmd = new SqlCommand();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);
        public Int32 SaveDesignation(DesignationModel _ObjDesignation)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("usp_Designation_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesgName", _ObjDesignation._DesgName);
                cmd.Parameters.AddWithValue("@IsActive", _ObjDesignation._IsActive);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjDesignation._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjDesignation._Description);

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

        public Int32 UpdateDesignation(DesignationModel _ObjDesignation)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_Designation_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesgName", _ObjDesignation._DesgName);
                cmd.Parameters.AddWithValue("@IsActive", _ObjDesignation._IsActive);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjDesignation._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjDesignation._Description);
                cmd.Parameters.AddWithValue("@DesgId", _ObjDesignation._DesgID);
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

        public DataTable SearchDesignation(Int32 _Desgid)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("usp_Designation_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesgID",_Desgid);
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

        public SqlDataReader GetDesignations()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("usp_Designation_GetDesignations", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Dispose();
            return dr;


        }

        public Int32 DeleteDesignations(Int32 _DesgID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Designation_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DesgID", _DesgID);
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
