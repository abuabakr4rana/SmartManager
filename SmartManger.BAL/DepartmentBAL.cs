using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmartManager.Models;
using SmartManger.DAL;
namespace SmartManger.BAL
{
   public class DepartmentBAL
    {
       public Int32 SaveDepartment(DepartmentModel _objModel)
       {
           DepartmentDAL _objDAL = new DepartmentDAL();
           try
           {
               return _objDAL.SaveDepartment(_objModel);
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

       public Int32 UpdateDepartment(DepartmentModel _objModel)
       {
           DepartmentDAL _objDAL = new DepartmentDAL();
           try
           {
               return _objDAL.UpdateDepartment(_objModel);
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

       public Int32 DeleteUser(Int32 _DeptID)
       {
           DepartmentDAL _objDAL = new DepartmentDAL();
           try
           {
               return _objDAL.DeleteDepartment(_DeptID);
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

       public DepartmentModel SearchDepartment(Int32 _LoginID)
       {
           DepartmentModel _objModel = new DepartmentModel();
           DepartmentDAL _objDAL = new DepartmentDAL();
           try
           {
               DataTable dt = _objDAL.SearchDepartmet(_LoginID);
               foreach (DataRow item in dt.Rows)
               {
                   _objModel._DeptName = item["DeptName"].ToString();
                   _objModel._Description = item["Description"].ToString();
                   _objModel._IsActive = Convert.ToBoolean(item["IsActive"].ToString());
                   _objModel._ModifiedDate = Convert.ToDateTime(item["ModifiedDate"].ToString());
                  
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

       public List<DepartmentModel> GetDepartmentList() 
       {
           DepartmentDAL _objDAL = new DepartmentDAL();
           try
           {
               List<DepartmentModel> DepartmentList = new List<DepartmentModel>();
              
               SqlDataReader dr=_objDAL.GetDepartments();
               while (dr.Read() == true)
               {
                   DepartmentModel department = new DepartmentModel();
                   department._DeptID = Convert.ToInt32(dr[0]);
                   department._DeptName = dr[1].ToString();
                   department._IsActive =Convert.ToBoolean( dr[2]);
                   department._ModifiedDate = (Convert.ToDateTime(dr[3].ToString()));
                   department._Description = dr[4].ToString();
                   DepartmentList.Add(department);
               }
               return DepartmentList;

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

    }
}
