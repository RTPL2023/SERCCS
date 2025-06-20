using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LnpurposeMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string ln_purpose { get; set; }
        public string purpose_desc { get; set; }

        
    }
}