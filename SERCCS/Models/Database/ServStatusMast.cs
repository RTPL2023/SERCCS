using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    
    
    public class ServStatusMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string serv_status { get; set; }
        public string serv_status_desc { get; set; }

       
    }
}