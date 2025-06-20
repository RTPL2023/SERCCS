using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class BranchMast
    {
        DBConfig config = new DBConfig();
        //string sql;
        public String branch_id { get; set; }
        public String branch_name { get; set; }
        public String branch_add1 { get; set; }
        public String branch_add2 { get; set; }
        public String branch_sname { get; set; }
        public String branch_defa { get; set; }

        
    }
}