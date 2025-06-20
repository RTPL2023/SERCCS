using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositIntroducer
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public Int64 int_srl { get; set; }
        public String intr_type { get; set; }
        public String int_ac_hd { get; set; }
        public String int_ac_no { get; set; }
        public String int_mem_no { get; set; }
        public String int_name { get; set; }
        public String int_cust_id { get; set; }
        public String witness { get; set; }
        public string introducer_tag { get;set;}



    }
}