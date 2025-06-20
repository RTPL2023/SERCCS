using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class MemcategoryMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public string mem_category { get; set; }
        public string category_desc { get; set; }


        
    }
}
