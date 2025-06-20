using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DeptMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public String employer_cd { get; set; }
        public String dept_cd { get; set; }
        public String dept_desc { get; set; }

      
    }
}