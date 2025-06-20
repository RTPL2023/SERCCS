using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class RelnMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string reln_id { get; set; }
        public string reln_name { get; set; }

        
    }
}
    
