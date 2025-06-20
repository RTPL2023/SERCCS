using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class CounterOne
    {
        DBConfig config = new DBConfig();
        string sql;
        public String branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public String po_no { get; set; }
        public String dr_cr { get; set; }
        public String n_1000 { get; set; }
        public String n_500 { get; set; }
        public String n_100 { get; set; }
        public String n_50 { get; set; }
        public String n_10 { get; set; }
        public String n_5 { get; set; }
        public String n_2 { get; set; }
        public String n_1 { get; set; }
        public Decimal s_coin { get; set; }
        public Decimal total { get; set; }
        public Decimal bal { get; set; }
        public String chq_no { get; set; }
        public Decimal chq_amt { get; set; }
        public String contno { get; set; }
        public string MSG { get; set; }

   
     
    }
}