using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class EmployerBranchMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public String employer_cd { get; set; }
        public String employer_branch { get; set; }
        public String employer_br_name { get; set; }
        public String branch_add1 { get; set; }
        public String branch_add2 { get; set; }
        public String branch_city { get; set; }
        public String branch_dist { get; set; }
        public String branch_state { get; set; }
        public String branch_pin { get; set; }
        public String branch_phone { get; set; }
        public String branch_telex { get; set; }
        public String branch_defa { get; set; }
        public String recovery_ac_hd { get; set; }


       
    }
}