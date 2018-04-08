using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
  public  class DesignationModel
    {
        public Int32 _DesgID { get; set; }
        public string _DesgName { get; set; }
        public bool _IsActive { get; set; }
        public DateTime _ModifiedDate { get; set;}
        public string _Description { get; set; }

    }
}
