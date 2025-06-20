using SERCCS.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class JournalBook
    {
        DBConfig config = new DBConfig();
        public string msgbox { get; set; }
        public string branch_id { get; set; }
        public string cb_date { get; set; }
        public string starting_pg { get; set; }
        public string ending_pg { get; set; }
        public string trn_date { get; set; }
        public string ac_hd { get; set; }
        public string dr_cr { get; set; }
        public string srl_no { get; set; }
        public decimal cash_recp { get; set; }
        public decimal bank_recp { get; set; }
        public int row7 { get; set; }
        public decimal cash_payment { get; set; }
        public decimal bank_payment { get; set; }
        public string page_no { get; set; }
        public int trn_no { get; set; }
        public string particulars { get; set; }
        public decimal amt_cash { get; set; }
        public decimal amt_bank { get; set; }
        public decimal bal_cash { get; set; }
        public decimal bal_bank { get; set; }
        public string vch_no { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public string modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public decimal amt { get; set; }
        public decimal cr_amt { get; set; }
        public decimal dr_amt { get; set; }
        
    }
}
