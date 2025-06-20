using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class CloseDataLoan
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string employee_id { get; set; }
        public string ac_hd { get; set; }
        public string loanee_name { get; set; }
        public string loan_no { get; set; }
        public string ipass_no { get; set; }
        public string bu_no { get; set; }
        public Decimal inst_amt { get; set; }
        public DateTime trn_date { get; set; }

       
    }
}
