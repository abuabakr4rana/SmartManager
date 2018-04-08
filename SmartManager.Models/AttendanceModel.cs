using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
   public class AttendanceModel
    {
       public Int32 _AttendanceID { get; set; }
       public Int32 _EmployeeID { get; set; }
       public DateTime _AttendanceDate { get; set; }
       public DateTime _CreatedOn { get; set; }
       public Int32 _CreatedBy { get; set; }
    }
}
