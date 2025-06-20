using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;


using System.Data;

namespace SERCCS.Models.Database
{
    public class ExcessLoanRefund
    {
        DBConfig config = new DBConfig();

        String sql;
        public string list_no { get; set; }
        public string po_no { get; set; }
        public DateTime po_date { get; set; }
        public string paid_to_cont { get; set; }
        public string paid_to_name { get; set; }
        public string paid_to_tno { get; set; }
        public string paid_to_bu { get; set; }
        public string loan_id { get; set; }
        public string loanee_cont { get; set; }
        public string loanee_name { get; set; }
        public decimal int_amt { get; set; }
        public decimal prin_amt { get; set; }
        public decimal total_amt { get; set; }
        public string ac_hd { get; set; }
       
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
     
      


    }
}
