using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Includes;
using System.Data;
namespace SERCCS.Models.Database
{
    public class MemberDetails
    {
        DBConfig config = new DBConfig();
        public string member_name { get; set; }
        public string employee_id { get; set; }

        public string book_no { get; set; }
        public string t_no { get; set; }
        public string ac_no { get; set; }
        
    }
}
