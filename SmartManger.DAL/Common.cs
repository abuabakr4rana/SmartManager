using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManger.DAL
{
 public  class Common
    {
     public static object CheckInt32(int value) 
     {
         if (value == 0)
         {
             return DBNull.Value;
         }
         else
             return value;
     }
     public static Object CheckString(string str) 
     {
         if (str == "")
         {
             return DBNull.Value;
         }
         else
             return str;
     }
     public static Object CheckDateTime(DateTime date) 
     {
         if (date == Convert.ToDateTime("1/1/0001"))
         {
             return DBNull.Value;
         }
         else
         {
             return date;
         }

     }
     public static Object CheckDouble(double value) 
     {
         if (value == 0)
         {
             return DBNull.Value;
         }
         else
             return value;
     }
    }
}
