using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LoanPaymentMode
    {
        DBConfig config = new DBConfig();
        string sql;
        public DateTime ldate { get; set; }
        public String lldate { get; set; }
        public string loan_id { get; set; }
        public string employee_id { get; set; }
        public string payment_mode { get; set; }
        public string list_no { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string loan_idlast { get; set; }
        public string loan_id_first { get; set; }
        public string vch_amt { get; set; }
        public string loan_no { get; set; }
        public decimal share_money { get; set; }
        public decimal stab_fund { get; set; }
        public decimal loan_prin { get; set; }
        public decimal intrst { get; set; }
        public decimal pro_fee { get; set; }
        public decimal ttl_duc { get; set; }
        public decimal net_pay { get; set; }
        public decimal loan_amt { get; set; }
        public string loan_id1 { get; set; }
        public string loan_id2 { get; set; }

        

    }
}