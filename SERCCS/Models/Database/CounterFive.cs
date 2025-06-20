using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class CounterFive
    {
        DBConfig config = new DBConfig();
        string sql;
        public string branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public string po_no { get; set; }
        public string dr_cr { get; set; }
        public string n_1000 { get; set; }
        public string n_500 { get; set; }
        public string n_100 { get; set; }
        public string n_50 { get; set; }
        public string n_20 { get; set; }
        public string n_10 { get; set; }
        public string n_5 { get; set; }
        public string n_2 { get; set; }
        public string n_1 { get; set; }
        public decimal s_coin { get; set; }
        public decimal total { get; set; }
        public decimal bal { get; set; }
        public string chq_no { get; set; }
        public decimal chq_amt { get; set; }
        public string contno { get; set; }

    
    }
}