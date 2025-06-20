using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class logindetails
    {
        public string user_id { get; set; }
        public int logged_in {get;set;}
        public DateTime login_datetime { get; set; }
        public DateTime logout_datetime { get; set; }
    }
}
