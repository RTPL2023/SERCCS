using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class Constituency_Buno
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string constituency { get; set; }
        public string buno { get; set; }
        public string msg { get; set; }


      
    }
}
