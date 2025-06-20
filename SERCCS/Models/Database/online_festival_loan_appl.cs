using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class online_festival_loan_appl
    {
        DBConfig config = new DBConfig();
        public int application_id { get; set; }
        public string application_date { get; set; }
        public string cont_no { get; set; }
        public string member_name { get; set; }
        public string grdn_name { get; set; }
        public string mail_hno { get; set; }
        public string mail_add1 { get; set; }
        public string mail_add2 { get; set; }
        public string mail_city { get; set; }
        public string mail_dist { get; set; }
        public string mail_state { get; set; }
        public string mail_pin { get; set; }
        public string bu_no { get; set; }
        public string birth_date { get; set; }
        public string date_of_retirement { get; set; }
        public string mobile_no { get; set; }
        public decimal cmtd_amt { get; set; }
        public decimal avl_cmtd_amt { get; set; }
        public decimal loan_amt { get; set; }
        public string bank_name { get; set; }
        public string branch_code { get; set; }
        public string branch_name { get; set; }
        public string bank_ifsc { get; set; }
        public string bank_ac_no { get; set; }
        public string sign_otp { get; set; }
        public string viewed_on { get; set; }
        public string viewed_by { get; set; }
        public int viewed { get; set; }
        public string status { get; set; }
        public string passed_rejected_on { get; set; }
        public string remarks { get; set; }
        public string msg { get; set; }
        public Byte[] salary_slip { get; set; }


      
    }
}
