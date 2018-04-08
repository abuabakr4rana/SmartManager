using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
   public  class HolidayModel
    {
       public Int32 _HolidayID { get; set; }
       public string _Description { get; set; }
       public DateTime _HolidayDate { get; set; }
       public DateTime _ModifiedDate { get; set; }


    }
}
