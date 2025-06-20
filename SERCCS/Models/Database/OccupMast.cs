using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{

    public class OccupMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public string occup_id { get; set; }
        public string occup_name { get; set; }

       
    }
}