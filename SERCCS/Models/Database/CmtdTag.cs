using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class CmtdTag
    {
        DBConfig config = new DBConfig();
        string sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_no { get; set; }
        public string contno { get; set; }
        public decimal inst_amt { get; set; }
        public DateTime eff_date { get; set; }
        public string ac_no { get; set; }
        public string ref_ac_hd { get; set; }

      
    }
}