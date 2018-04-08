using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
  public class SalaryDetailModel
    {
      public Int32 _SalaryDetailId { get; set; }
      public Int32 _EmployeeId { get; set; }
      public Int32 _Present { get; set; }
      public Int32 _Absents { get; set; }
      public Int32 _Leaves { get; set; }
      public Double _Salary { get; set; }
      public double _Deductions { get; set; }
      public double _Totol { get; set; }
    }
}
