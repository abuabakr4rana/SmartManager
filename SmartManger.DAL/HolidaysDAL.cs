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
  public  class HolidaysDAL
    {
        SqlCommand cmd = new SqlCommand();

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);
        public Int32 SaveHoliday(HolidayModel _ObjHoliday)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("usp_Holidays_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HolidayDate", _ObjHoliday._HolidayDate);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjHoliday._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjHoliday._Description);

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

        public Int32 UpdateHoliday(HolidayModel _ObjHoliday)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_Holidays_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HolidayDate", _ObjHoliday._HolidayDate);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjHoliday._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjHoliday._Description);
                cmd.Parameters.AddWithValue("@HolidayId", _ObjHoliday._HolidayID);
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

        public DataTable SearchHoliday(Int32 _HolidayID)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("usp_Holidays_Search", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HolidayId", _HolidayID);
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

        public SqlDataReader GetHolidays()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("usp_Holidays_GetHolidays", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Dispose();
            return dr;


        }

        public Int32 DeleteHoliday(Int32 _HolidayID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Holidays_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HolidayId", _HolidayID);
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
