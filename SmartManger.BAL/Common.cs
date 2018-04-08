using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManger.BAL
{
  public  class Common
    {
      public static DateTime DateNow()
      {
          DateTime utcTime = DateTime.UtcNow;
          //TimeZoneInfo myZone = TimeZoneInfo.CreateCustomTimeZone("COLOMBIA", new TimeSpan(-5, 0, 0), "Colombia", "Colombia");
          TimeZoneInfo myZone = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
          DateTime custDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone);
          return custDateTime;
      }

      public static Int32 CheckInteger(object obj)
      {
          if (obj == DBNull.Value)
          {
              return 0;
          }
          else
          {
              return Convert.ToInt32(obj);
          }
      }
      public static double CheckDouble(object obj)
      {
          if (obj ==DBNull.Value)
          {
              return 0.0;
          }
          else
          {
              return Convert.ToDouble(obj);
          }

      }
      public static DateTime CheckDateTime(object obj)
      {
          if (obj == DBNull.Value)
          {
              return Convert.ToDateTime("1/1/0001");
          }
          else
          {
              return Convert.ToDateTime(obj);
          }
      }
      public static String CheckString(object obj)
      {
          if (obj == null)
          {
              return "";
          }
          else 
          {
              return obj.ToString();
          }
      }
      public static DateTime FirstOfMonth()
      {
          DateTime Now = Common.DateNow();
          DateTime b = new DateTime(Now.Year, Now.Month, 1);
          return b;
      }

      public static DateTime LastOfMonth()
      {
          DateTime Now = Common.DateNow();
          DateTime a= new DateTime(Now.Year, Now.Month, DateTime.DaysInMonth(Now.Year, Now.Month));
          return a;
      }
    }
}
