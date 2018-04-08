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
   public class ShiftDAL
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);
        public Int32 SaveShift(ShiftModel _ObjShift)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("usp_Shift_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftName", _ObjShift._ShiftName);
                cmd.Parameters.AddWithValue("@StartTime", _ObjShift._StartTime);
                cmd.Parameters.AddWithValue("@EndTime", _ObjShift._EndTime);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjShift._ModifiedDate);
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

        public Int32 UpdateShift(ShiftModel _ObjShift)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_Shift_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftName", _ObjShift._ShiftName);
                cmd.Parameters.AddWithValue("@StartTime", _ObjShift._StartTime);
                cmd.Parameters.AddWithValue("@EndTime", _ObjShift._EndTime);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjShift._ModifiedDate);
                cmd.Parameters.AddWithValue("@ShiftId", _ObjShift._ShiftID);
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

        public DataTable SearchShift(Int32 _ShiftID)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("usp_Shift_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftId", _ShiftID);
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

        public SqlDataReader GetShifts()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("usp_Shift_GetShifts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Dispose();
            return dr;


        }

        public Int32 DeleteShift(Int32 _ShiftID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Shift_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ShiftId", _ShiftID);
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
