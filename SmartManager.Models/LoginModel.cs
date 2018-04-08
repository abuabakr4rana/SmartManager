using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartManager.Models
{
    public class LoginModel
    {
      public Int32 _LoginID { get; set; }
      public  string _Username { get; set; }
      public  string _Password { get; set; }
      public  string _EmailAddress { get; set; }
      public int _UserRole { get; set; }
      public DateTime _ModifiedDate { get; set; }

       
    }

}
