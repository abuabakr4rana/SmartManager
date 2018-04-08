using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
  public  class SalaryModel
    {
      public Int32 _SalaryId { get; set;}
      public DateTime _SalaryDate { get; set; }
      public DateTime _CreatedOn { get; set; }
      public Int32 _CreteBy { get; set; }
      public string _SysytemNotes { get; set; }
    }
}
