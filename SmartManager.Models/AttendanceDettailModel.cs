using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
  public  class AttendanceDettailModel
  {
      public Int32 _AttendanceDetailId;
      public Int32 _AttendanceId;
      public Int32 _EmployeeId;
      public Int32 _Status { get; set; }
      public DateTime _TimeIn { get; set; }
      public DateTime _TImeOut { get; set; }
      public DateTime _ModifiedDate { get; set; }
      public string _SystemNotes { get; set; }

  }
}
