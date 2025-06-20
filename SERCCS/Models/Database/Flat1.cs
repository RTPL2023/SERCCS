using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class Flat1
    {
        DBConfig config = new DBConfig();
        public string employee_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_id { get; set; }
        public DateTime xdate { get; set; }
        public string Acd { get; set; }
        public decimal loan_amt { get; set; }
        public DateTime loan_date { get; set; }
        public decimal instl_amount { get; set; }
        public decimal noinst { get; set; }
        public string insrec { get; set; }
        public string lnreco { get; set; }
        public string month { get; set; }
        public decimal cmtdno { get; set; }
        public decimal cmtdamt { get; set; }
        public string cmtdflag { get; set; }
        public decimal ipass_no { get; set; }
        public string contno_11d { get; set; }

        
    }
}







