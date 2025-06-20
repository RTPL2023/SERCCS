using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class EmployerMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public String employer_cd { get; set; }
        public String employer_name { get; set; }
        public String employer_add1 { get; set; }
        public String employer_add2 { get; set; }
        public String employer_pin { get; set; }
        public String employer_phone { get; set; }
        public String employer_telex { get; set; }
        public String employer_defa { get; set; }


      
    }
}
