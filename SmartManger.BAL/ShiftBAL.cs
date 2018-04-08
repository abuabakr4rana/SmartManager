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

  public  class ShiftBAL
    {
      public Int32 SaveShift(ShiftModel _objModel)
      {
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              return _objDAL.SaveShift(_objModel);
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

      public SqlDataReader GetShifts()
      {
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              return _objDAL.GetShifts();
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

      public Int32 UpdateShift(ShiftModel _objModel)
      {
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              return _objDAL.UpdateShift(_objModel);
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

      public Int32 DeleteShift(Int32 _ShiftId)
      {
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              return _objDAL.DeleteShift(_ShiftId);
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

      public ShiftModel SearchShift(Int32 _ShiftId)
      {
          ShiftModel _objModel = new ShiftModel();
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              DataTable dt = _objDAL.SearchShift(_ShiftId);
              foreach (DataRow item in dt.Rows)
              {
                  _objModel._ShiftName = item["ShiftName"].ToString();
                  _objModel._StartTime =Convert.ToDateTime (item["StartTime"].ToString());
                  _objModel._EndTime = Convert.ToDateTime(item["EndTime"].ToString());
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

      public List<ShiftModel> GetShiftList()
      {
          ShiftDAL _objDAL = new ShiftDAL();
          try
          {
              List<ShiftModel> ShiftList = new List<ShiftModel>();

              SqlDataReader dr = _objDAL.GetShifts();
              while (dr.Read() == true)
              {
                  ShiftModel shift = new ShiftModel();
                  shift._ShiftID = Convert.ToInt32(dr[0]);
                  shift._ShiftName = dr[1].ToString();
                  shift._StartTime = Convert.ToDateTime(dr[2].ToString());
                  shift._EndTime = Convert.ToDateTime(dr[3].ToString());
                  shift._ModifiedDate = string.IsNullOrEmpty(dr[4].ToString()) ? Convert.ToDateTime("") : Convert.ToDateTime(dr[4]);
                  
                  ShiftList.Add(shift);
              }
              return ShiftList;

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
