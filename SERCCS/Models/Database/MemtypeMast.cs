using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{

    public class MemtypeMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string member_type { get; set; }
        public string type_desc { get; set; }

        
    }
}