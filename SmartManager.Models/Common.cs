using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
   public class Common
    {
       
      
        public static System.Int32 CheckIntegerNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }
        public static System.Int16 CheckShortNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToInt16(obj);
            }
            else
            {
                return 0;
            }
        }

        public static System.Boolean CheckBooleanNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToBoolean(obj);
            }
            else
            {
                return false;
            }
        }
        public static System.String CheckStringNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToString(obj);
            }
            else
            {
                return "";
            }
        }
        public static System.DateTime CheckDateTimeNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToDateTime(obj);
            }
            else
            {
                return System.DateTime.Now;
            }
        }
        public static System.Decimal CheckDecimalNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToDecimal(obj);
            }
            else
            {
                return 0;
            }
        }
        public static System.Double CheckDoubleNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToDouble(obj);
            }
            else
            {
                return 0;
            }
        }

        public static Byte CheckByteNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToByte(obj);
            }
            else
            {
                return 0;
            }
        }

        public static Byte[] CheckAByteNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return (byte[])obj;
            }
            else
            {
                return null;
            }
        }

        public static long CheckLongNull(object obj)
        {
            if (Convert.IsDBNull(obj) == false)
            {
                return Convert.ToInt64(obj);
            }
            else
            {
                return 0;
            }
        }
     
    }
}
