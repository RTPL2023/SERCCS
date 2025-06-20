using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LoanSurity
    {
        DBConfig config = new DBConfig();
        string sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_id { get; set; }
        public string smember_id { get; set; }
        public string smember_id2 { get; set; }
        public DateTime loan_date { get; set; }
        public string scust_id { get; set; }
        public string surity_name { get; set; }
        public string surity_name2 { get; set; }
        public string dr_cr { get; set; }
        public decimal prin_amt { get; set; }
        public decimal bal { get; set; }
        public string status { get; set; }
        public DateTime loan_clos_dt { get; set; }
        public string xln_type { get; set; }
        public string xloan_id { get; set; }
        public string lcontno { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string Old_Ac_No { get; set; }
        public string s1_BD { get; set; }
        public string tag { get; set; }
        public string msg { get; set; }
        public decimal prin_bal { get; set; }
        public string member_name { get; set; }
      
    }
}













