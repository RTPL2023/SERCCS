using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LoanDetails
    {
        public string Cont_no { get; set; }
        public string Loan_id { get; set; }
        public string Name { get; set; }
        public string Loan_amt { get; set; }
        public string Bal { get; set; }
        public string Tot_int { get; set; }
        public string No { get; set; }
        public string loan_id { get; set; }
        public string employee_id { get; set; }
        public decimal loan_amt { get; set; }
        public Decimal prin_amount { get; set; }
        public string loanee_name { get; set; }
        public string t_no { get; set; }
        public string book_no { get; set; }
        public decimal Net_amt { get; set; }

    }
}
