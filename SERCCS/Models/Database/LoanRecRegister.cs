using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Controllers;


namespace SERCCS.Models.Database
{
    public class LoanRecRegister
    {
        DBConfig config = new DBConfig();
        public DateTime rec_date { get; set; }
        public string ac_hd { get; set; }
        public string loan_form_no { get; set; }
        public string cont_no { get; set; }
        public string name { get; set; }
        public Int32 sl_no { get; set; }
        public string bu_no { get; set; }
        public DateTime issue_date { get; set; }
        public DateTime Passed_date { get; set; }
        public string loan_no { get; set; }
        public DateTime can_date { get; set; }
        public string remarks { get; set; }



        
    }
}