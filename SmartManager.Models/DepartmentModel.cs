using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
  public  class DepartmentModel
    {
      public Int32 _DeptID { get; set; }
      public string _DeptName { get; set; }
      public bool _IsActive { get; set; }
      public DateTime _ModifiedDate { get; set; }
      public string _Description { get; set; }
    }
}
