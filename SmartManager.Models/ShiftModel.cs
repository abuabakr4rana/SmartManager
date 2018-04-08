using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
   public class ShiftModel
    {
       public Int32 _ShiftID { get; set; }
       public string _ShiftName { get; set; }
       public DateTime _StartTime { get; set; }
       public DateTime _EndTime { get; set; }
       public DateTime _ModifiedDate { get; set; }

    }
}
