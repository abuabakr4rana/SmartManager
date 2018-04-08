using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmartManager.Models;
using SmartManger.DAL;
using SmartManger.BAL;

namespace SmartManger.BAL
{
 public   class EmployeeBAL
    {
     public Int32 SaveEmployee(EmployeeModel _objModel)
     {
         EmployeeDAL _objDAL = new EmployeeDAL();
         try
         {
             return _objDAL.SaveEmployee(_objModel);
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             _objDAL = null;
         }
     }

     public SqlDataReader GetEmployees()
     {
         EmployeeDAL _objDAL = new EmployeeDAL();
         try
         {
             return _objDAL.GetEmployees();
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             //_objDAL = null;
         }
     }

     public Int32 UpdateEmployee(EmployeeModel _objModel)
     {
         EmployeeDAL _objDAL = new EmployeeDAL();
         try
         {
             return _objDAL.UpdateEmployee(_objModel);
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             _objDAL = null;
         }

     }

     public Int32 DeleteEmployee(Int32 _EmployeeId)
     {
         EmployeeDAL _objDAL = new EmployeeDAL();
         try
         {
             return _objDAL.DeleteEmoployee(_EmployeeId);
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             _objDAL = null;
         }
     }

     public EmployeeModel SearchEmployee(Int32 _EmployeeId)
     {
         EmployeeModel _objModel = new EmployeeModel();
         EmployeeDAL _objDAL = new EmployeeDAL();
         try
         {
             DataTable dt = _objDAL.SearchEmployee(_EmployeeId);
             foreach (DataRow item in dt.Rows)
             {

                 _objModel._Code = Common.CheckInteger(item["Code"]);
                 _objModel._FirstName =Common.CheckString( item["FirstName"]);
                 _objModel._LastName =Common.CheckString (item["LastName"]);
                 _objModel._FatherName = Common.CheckString(item["FatherName"]);
                 _objModel._DOB =Common.CheckDateTime (item["DOB"]);
                 _objModel._MobileNo = Common.CheckString(item["MobileNo"]);
                 _objModel._CNIC = Common.CheckString(item["CNIC"]);
                 _objModel._Address = Common.CheckString(item["Address"]);
                 _objModel._IsMarried =Convert.ToBoolean( item["IsMarried"].ToString());
                 _objModel._IsActive = Convert.ToBoolean(item["IsActive"].ToString());
                 _objModel._DOJ =Common.CheckDateTime(item["HireDate"]) ;
                 _objModel._Salary =Common.CheckDouble(item["Salary"]) ;
                 _objModel._ResignDate = string.IsNullOrEmpty(item["ResignDate"].ToString()) ? "" : (item["ResignDate"].ToString());
                 _objModel._DesignationID = Common.CheckInteger(item["DesignationID"]);
                 _objModel._DepartmentID = Common.CheckInteger(item["DepartmentID"]);
                 _objModel._ShiftID =Common.CheckInteger (item["ShiftID"]) ;
                 _objModel._RestDay = Common.CheckString(item["RestDay"]);
                 _objModel._AL = Common.CheckInteger(item["AL"]);
                 _objModel._CL = Common.CheckInteger(item["CL"]) ;
                 _objModel._SL = Common.CheckInteger(item["SL"]);
                 _objModel._ModifiedDate = Common.CheckDateTime(item["ModifiedDate"]);
                 _objModel._Descripition = Common.CheckString(item["Description"]);
                 _objModel._ImageUrl = Common.CheckString(item["ImageUrl"]) ;
             }
             return _objModel;
         }
         catch (Exception ex)
         {
             throw ex;
         }
         finally
         {
             _objDAL = null;
         }
     }

     public Int32 GetMaxCode() 
     {
         EmployeeDAL _objDAL = new EmployeeDAL();
         return (_objDAL.GetMaxCode());
     }

    }
}
