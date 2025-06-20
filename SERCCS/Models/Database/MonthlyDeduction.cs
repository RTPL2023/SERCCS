using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class MonthlyDeduction
    {
        DBConfig config = new DBConfig();
        public DateTime date_posting { get; set; }
        public DateTime Last_date_posting { get; set; }
        public string month_deduct { get; set; }
        public string employee_id { get; set; }
        public string year_deduct { get; set; }
        public string name { get; set; }
        public string book_no { get; set; }
        public string t_no { get; set; }
        public Decimal loan { get; set; }
        public string loan_id { get; set; }
        public Decimal p_loan { get; set; }
        public string p_loan_id { get; set; }
        public Decimal cmtd { get; set; }
        public Decimal sb { get; set; }
        public string posting { get; set; }
        public decimal stl { get; set; }
        public string sloan_id { get; set; }
        public Int64 p_stl { get; set; }
        public string p_stl_id { get; set; }
        public decimal fes { get; set; }
        public Int64 pfes { get; set; }
        public string pfes_no { get; set; }
        public string cmtd_id { get; set; }
        public string sb_id { get; set; }
        public string vcmtd_id { get; set; }
        public string loanL { get; set; }
        public string instI { get; set; }
        public string rateR { get; set; }
        public string isntstartedSI { get; set; }
        public string l_date { get; set; }
        public string p_date { get; set; }
        public string pp_date { get; set; }



        
    }
}