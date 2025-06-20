using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DesigMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public String desig_cd { get; set; }
        public String desig_desc { get; set; }

       
    }
}