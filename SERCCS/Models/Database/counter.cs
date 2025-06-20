using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SERCCS.Models.Database
{
    public class counter
    {

        public String branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public String po_no { get; set; }
        public String dr_cr { get; set; }
        public String n_1000 { get; set; }
        public String n_500 { get; set; }
        public String n_100 { get; set; }
        public String n_50 { get; set; }
        public String n_20 { get; set; }
        public String n_10 { get; set; }
        public String n_5 { get; set; }
        public String n_1 { get; set; }
        public decimal s_coin { get; set; }
        public decimal total { get; set; }
        public decimal bal { get; set; }
        public String chq_no { get; set; }
        public decimal chq_amt { get; set; }
        public String contno { get; set; }
  
    }
}