using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
   public class EmployeeModel
    {
       public Int32 _EmployeeID { get; set; }
       public Int32 _Code { get; set; }
       public String _FirstName { get; set; }
       public String _LastName { get; set; }
       public String _FatherName { get; set; }
       public DateTime _DOB { get; set; }
       public DateTime _DOJ { get; set; }
       public String _MobileNo { get; set; }
       public String _CNIC { get; set; }
       public String _Address { get; set; }
       public bool _IsMarried { get; set; }
       public bool _IsActive { get; set; }
       public double _Salary { get; set; }
       public String _ResignDate { get; set; }
       public Int32 _DesignationID { get; set; }
       public Int32 _DepartmentID { get; set; }
       public Int32 _ShiftID { get; set; }
       public String _RestDay { get; set; }
       public Int32 _AL { get; set; }
       public Int32 _CL { get; set; }
       public Int32 _SL { get; set; }
       public DateTime _ModifiedDate { get; set; }
       public String _Descripition { get; set; }
       public String _ImageUrl { get; set; }
    }

}
