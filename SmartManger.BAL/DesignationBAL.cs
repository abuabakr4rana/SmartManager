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
  public class DesignationBAL
    {
      public Int32 SaveDesignation(DesignationModel _objModel)
      {
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              return _objDAL.SaveDesignation(_objModel);
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

      public SqlDataReader GetDesignations()
      {
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              return _objDAL.GetDesignations();
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

      public Int32 UpdateDesignation(DesignationModel _objModel)
      {
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              return _objDAL.UpdateDesignation(_objModel);
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

      public Int32 DeleteDesignation(Int32 _DesgId)
      {
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              return _objDAL.DeleteDesignations(_DesgId);
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

      public DesignationModel SearchDesignation(Int32 _DesgID)
      {
          DesignationModel _objModel = new DesignationModel();
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              DataTable dt = _objDAL.SearchDesignation(_DesgID);
              foreach (DataRow item in dt.Rows)
              {
                  _objModel._DesgName = item["DesgName"].ToString();
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

      public List<DesignationModel> GetDesignationList()
      {
          DesignationDAL _objDAL = new DesignationDAL();
          try
          {
              List<DesignationModel> DesignationList = new List<DesignationModel>();

              SqlDataReader dr = _objDAL.GetDesignations();
              while (dr.Read() == true)
              {
                  DesignationModel designation = new DesignationModel();
                  designation._DesgID = Convert.ToInt32(dr[0]);
                  designation._DesgName = dr[1].ToString();
                  designation._IsActive = Convert.ToBoolean(dr[2]);
                  designation._ModifiedDate = (Convert.ToDateTime(dr[3].ToString()));
                  designation._Description = dr[4].ToString();
                  DesignationList.Add(designation);
              }
              return DesignationList;

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
