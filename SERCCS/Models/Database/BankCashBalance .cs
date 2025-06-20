using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class BankCashBalance
    {
        DBConfig config = new DBConfig();
        public string cb_date { get; set; }
        public string dr_cr { get; set; }
        public string vch_no { get; set; }
        public string vch_srl { get; set; }
        public string Date { get; set; }
        public string vch_date { get; set; }
        public string ch_fdr_no { get; set; }
        public string cash_bank { get; set; }
        public decimal amount_cash { get; set; }
        public decimal bal_bank { get; set; }
        public decimal bal_cash { get; set; }
        public decimal amount_bank { get; set; }
        public string frmdate { get; set; }
        public string todate { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string cash_bal { get; set; }
        public string bank_bal { get; set; }
        public string msg { get; set; }



    }
}
