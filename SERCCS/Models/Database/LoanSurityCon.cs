using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LoanSurityCon
    {
        DBConfig config = new DBConfig();
        string sql;
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String loan_id { get; set; }
        public String smember_id { get; set; }
        public String smember_id2 { get; set; } 
        public DateTime loan_date { get; set; }
        public String scust_id { get; set; }
        public String surity_name { get; set; }
        public String surity_name2 { get; set; }
        public String dr_cr { get; set; }
        public Decimal prin_amt { get; set; }
        public Decimal bal { get; set; }
        public String status { get; set; }
        public string loan_clos_dt { get; set; }
        public String xln_type { get; set; }
        public String xloan_id { get; set; }
        public String lcontno { get; set; }
        public String created_by { get; set; }
        public string created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public string modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public string Old_Ac_No { get; set; }
        public string s1_BD { get; set; }
        public string tag { get; set; }
        public string msg { get; set; }
        public string loanee_name { get; set; }
        public string member_name { get; set; }
        public string loan_Date { get; set; }


        
    }
}