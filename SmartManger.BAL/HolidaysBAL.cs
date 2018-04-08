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
   public class HolidaysBAL
    {
       public Int32 SaveHoliday(HolidayModel _objModel)
       {
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               return _objDAL.SaveHoliday(_objModel);
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

       public SqlDataReader GetHolidays()
       {
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               return _objDAL.GetHolidays();
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

       public Int32 UpdateHoliday(HolidayModel _objModel)
       {
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               return _objDAL.UpdateHoliday(_objModel);
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

       public Int32 DeleteHoliday(Int32 _HolidayId)
       {
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               return _objDAL.DeleteHoliday(_HolidayId);
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

       public HolidayModel SearchHoliday(Int32 _HolidayID)
       {
           HolidayModel _objModel = new HolidayModel();
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               DataTable dt = _objDAL.SearchHoliday(_HolidayID);
               foreach (DataRow item in dt.Rows)
               {
                   _objModel._HolidayDate = Convert.ToDateTime(item["HolidayDate"].ToString());
                   _objModel._Description = item["Description"].ToString();
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

       public List<HolidayModel> GetHolidayList()
       {
           HolidaysDAL _objDAL = new HolidaysDAL();
           try
           {
               List<HolidayModel> HolidayList = new List<HolidayModel>();

               SqlDataReader dr = _objDAL.GetHolidays();
               while (dr.Read() == true)
               {
                   HolidayModel holiday = new HolidayModel();
                   holiday._HolidayID = Convert.ToInt32(dr[0]);
                   holiday._HolidayDate=Convert.ToDateTime(dr[1]);
                   holiday._ModifiedDate = string.IsNullOrEmpty(dr[3].ToString())?Convert.ToDateTime("") : Convert.ToDateTime(dr[3]);
                   holiday._Description = dr[2].ToString();
                   HolidayList.Add(holiday);
               }
               return HolidayList;

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
