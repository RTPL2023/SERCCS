using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class CashBookUtility
    {
        DBConfig config = new DBConfig();


        public string msgbox { get; set; }
        public string branch_id { get; set; }
        public string cb_date { get; set; }
        public string starting_pg { get; set; }
        public int ending_pg { get; set; }
        public int count { get; set; }
        public DateTime trn_date { get; set; }
        public string ac_hd { get; set; }
        public string dr_cr { get; set; }
        public string dr_cr_d { get; set; }
        public string dr_cr_c { get; set; }
        public string srl_no { get; set; }
        public decimal cash_recp { get; set; }
        public decimal bank_recp { get; set; }
        public decimal row7 { get; set; }
        public decimal bank_payment { get; set; }
        public string page_no { get; set; }
        public int trn_no { get; set; }
        public string particulars { get; set; }
        public string amt_cash { get; set; }
        public string amt_bank { get; set; }
        public decimal bal_cash { get; set; }
        public decimal bal_bank { get; set; }
        public string vch_no { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public string modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string ac_desc { get; set; }
        public decimal amt { get; set; }
        public string date1 { get; set; }
        public string from_date { get; set; }
        public string to_date1 { get; set; }
        public string month { get; set; }
        public decimal cr_amt { get; set; }
        public decimal dr_amt { get; set; }
        public string book_name { get; set; }
        public string srl { get; set; }
        public decimal Receipt { get; set; }
        public decimal Payment { get; set; }
        public decimal total_Receipt { get; set; }
        public decimal total_Payment { get; set; }
        public Int32 list_no { get; set; }
        public DateTime ldate { get; set; }
        public String xyear { get; set; }
        public Int32 ch_no { get; set; }
        public String loan_id_from { get; set; }
        public String loan_to { get; set; }
        public String favour { get; set; }
        public decimal amount { get; set; }
        public String payment_mode { get; set; }

        public String refo { get; set; }
        public String ref1 { get; set; }
        public String ref2 { get; set; }
        public String ref3 { get; set; }
        public String ref4 { get; set; }
        public String ref5 { get; set; }
        public String ref_l { get; set; }
        public String bank { get; set; }
        public Decimal ref_amount { get; set; }
        public Decimal ref_amount1 { get; set; }
        public Decimal ref_amount2 { get; set; }
        public Decimal ref_amount3 { get; set; }
        public Decimal ref_amount4 { get; set; }
        public Decimal ref_amount5 { get; set; }
        public Decimal ref_amount_l { get; set; }
        public String add_less { get; set; }
        public String Ref { get; set; }
        public DateTime issue_date { get; set; }
        public string cont_no { get; set; }
        public string name { get; set; }
        public decimal lf_no { get; set; }
        public DateTime rec_date { get; set; }
        public decimal vch_amt { get; set; }
        public string VCH_DRCR { get; set; }
        public string vch_pacno { get; set; }
        public string prin_amount { get; set; }
        public string trn_no1 { get; set; }
        public string vch_acname { get; set; }
        public decimal XAMTCJ { get; set; }
        public decimal XAMTDJ { get; set; }
        public string EMPLOYEE_ID { get; set; }
        public string MEMBER_ID { get; set; }
        public string member_name { get; set; }
        public string cashacc_hd { get; set; }
        public string liabilities { get; set; }
        public string income { get; set; }
        public string assets { get; set; }
        public string expenditure { get; set; }
        public decimal opening_bal { get; set; }
        public decimal debit { get; set; }
        public decimal credit { get; set; }
        public decimal closing_bal { get; set; }
        public string schedule { get; set; }

     

        //---------------------------------------For Cash Book-----------------------------------
       
    }
}
