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
   public class EmployeeDAL
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SMConnectionString"].ConnectionString);

        public Int32 SaveEmployee(EmployeeModel _ObjMOdel)
        {
            int result = 0;
            try
            {
                cmd = new SqlCommand("usp_Employee_Insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", _ObjMOdel._Code);
                cmd.Parameters.AddWithValue("@FirstName",Common.CheckString( _ObjMOdel._FirstName));
                cmd.Parameters.AddWithValue("@LastName",Common.CheckString( _ObjMOdel._LastName));
                cmd.Parameters.AddWithValue("@FatherName", Common.CheckString( _ObjMOdel._FatherName));
                cmd.Parameters.AddWithValue("@DOB",Common.CheckDateTime( _ObjMOdel._DOB));
                cmd.Parameters.AddWithValue("@MobileNo",Common.CheckString( _ObjMOdel._MobileNo));
                cmd.Parameters.AddWithValue("@CNIC",Common.CheckString( _ObjMOdel._CNIC));
                cmd.Parameters.AddWithValue("@Address",Common.CheckString( _ObjMOdel._Address));
                cmd.Parameters.AddWithValue("@IsMarried", _ObjMOdel._IsMarried);
                cmd.Parameters.AddWithValue("@IsActive", _ObjMOdel._IsActive);
                cmd.Parameters.AddWithValue("@HireDate",Common.CheckDateTime( _ObjMOdel._DOJ));
                cmd.Parameters.AddWithValue("@Salary", Common.CheckDouble( _ObjMOdel._Salary));
                cmd.Parameters.AddWithValue("@DesignationID",Common.CheckInt32( _ObjMOdel._DesignationID));
                cmd.Parameters.AddWithValue("@DepartmentID",Common.CheckInt32( _ObjMOdel._DepartmentID));
                cmd.Parameters.AddWithValue("@ShiftID",Common.CheckInt32( _ObjMOdel._ShiftID));
                cmd.Parameters.AddWithValue("@AL",Common.CheckInt32( _ObjMOdel._AL));
                cmd.Parameters.AddWithValue("@CL",Common.CheckInt32( _ObjMOdel._CL));
                cmd.Parameters.AddWithValue("@SL",Common.CheckInt32( _ObjMOdel._SL));
                cmd.Parameters.AddWithValue("@ModifiedDate",Common.CheckDateTime( _ObjMOdel._ModifiedDate));
                cmd.Parameters.AddWithValue("@Description",Common.CheckString( _ObjMOdel._Descripition));
                cmd.Parameters.AddWithValue("@ImageUrl",Common.CheckString( _ObjMOdel._ImageUrl));

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

        public Int32 UpdateEmployee(EmployeeModel _ObjMOdel)
        {
            int result;
            try
            {
                cmd = new SqlCommand("usp_Employee_Update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", _ObjMOdel._EmployeeID);
                cmd.Parameters.AddWithValue("@Code", _ObjMOdel._Code);
                cmd.Parameters.AddWithValue("@FirstName", _ObjMOdel._FirstName);
                cmd.Parameters.AddWithValue("@LastName", _ObjMOdel._LastName);
                cmd.Parameters.AddWithValue("@FatherName", _ObjMOdel._FatherName);
                cmd.Parameters.AddWithValue("@DOB", _ObjMOdel._DOB);
                cmd.Parameters.AddWithValue("@MobileNo", _ObjMOdel._MobileNo);
                cmd.Parameters.AddWithValue("@CNIC", _ObjMOdel._CNIC);
                cmd.Parameters.AddWithValue("@Address", _ObjMOdel._Address);
                cmd.Parameters.AddWithValue("@IsMarried", _ObjMOdel._IsMarried);
                cmd.Parameters.AddWithValue("@IsActive", _ObjMOdel._IsActive);
                cmd.Parameters.AddWithValue("@HireDate", _ObjMOdel._DOJ);
                cmd.Parameters.AddWithValue("@Salary", _ObjMOdel._Salary);
                cmd.Parameters.AddWithValue("@DesignationID", _ObjMOdel._DesignationID);
                cmd.Parameters.AddWithValue("@DepartmentID", _ObjMOdel._DepartmentID);
                cmd.Parameters.AddWithValue("@ShiftID", _ObjMOdel._ShiftID);
                cmd.Parameters.AddWithValue("@AL", _ObjMOdel._AL);
                cmd.Parameters.AddWithValue("@CL", _ObjMOdel._CL);
                cmd.Parameters.AddWithValue("@SL", _ObjMOdel._SL);
                cmd.Parameters.AddWithValue("@ModifiedDate", _ObjMOdel._ModifiedDate);
                cmd.Parameters.AddWithValue("@Description", _ObjMOdel._Descripition);
                cmd.Parameters.AddWithValue("@ImageUrl", _ObjMOdel._ImageUrl);
                
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

        public DataTable SearchEmployee(Int32 _EmployeeID)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("usp_Employee_SearchEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", _EmployeeID);
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

        public SqlDataReader GetEmployees()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand("usp_Employee_GetEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            //cmd.Dispose();
            return dr;


        }

        public Int32 DeleteEmoployee(Int32 _EmployeeID)
        {
            int result;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_Employee_Delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", _EmployeeID);
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

        public Int32 GetMaxCode() 
        {
            int newcode = 1;
            try 
            {
                SqlCommand cmd = new SqlCommand("usp_Employee_MaxCode", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int ? code =Convert.ToInt32( cmd.ExecuteScalar());
                cmd.Dispose();
                if (code.Value!=-1)
                {
                    newcode = code.Value + 1;
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            return newcode;

        }
   }

}
