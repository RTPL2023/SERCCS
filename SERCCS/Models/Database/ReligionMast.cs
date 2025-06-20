using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class ReligionMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string relgn_id { get; set; }
        public string relgn_name { get; set; }

        
    }
}