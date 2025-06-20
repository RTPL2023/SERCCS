using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class VchType
    {
        DBConfig config = new DBConfig();
        string sql;
        public string vch_type_cd { get; set; }
        public string vch_type_des { get; set; }

       
    }
}