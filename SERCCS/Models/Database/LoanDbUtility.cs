using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;
using System.Net;

namespace SERCCS.Models.Database
{
    public class LoanDbUtility
    {
        DBConfig config = new DBConfig();
        //NEFT TRANSACTION
        public string branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public string ac_hd { get; set; }
        public string ac_no_or_l_no { get; set; }
        public string employee_id { get; set; }
        public string member_name { get; set; }
        public Decimal net_amount { get; set; }
        public string bank_ac_no { get; set; }
        public string bank_name { get; set; }
        public string branch_name { get; set; }
        public string branch_code { get; set; }
        public string ifscode { get; set; }
        public Decimal amount_credited { get; set; }
        public Decimal neft_charge { get; set; }
        public DateTime credited_date { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string list_no { get; set; }
        //LOAN PAYMENT MODE
        public DateTime ldate { get; set; }
        public string loan_id { get; set; }
        public string payment_mode { get; set; }
        //LOAN LEDGER LTL       
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }
        public string dr_cr { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public string bankcd { get; set; }
        public Decimal prin_amount { get; set; }
        public Decimal int_amount { get; set; }
        public Decimal aint_amount { get; set; }
        public Decimal ichrg_amount { get; set; }
        public Decimal prin_bal { get; set; }
        public Decimal int_due { get; set; }
        public Decimal int_due_actual { get; set; }
        public Decimal aint_due { get; set; }
        public Decimal ichrg_due { get; set; }
        public Decimal rebate_allowed { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string insert_mode { get; set; }
        public string approval_flag { get; set; }
        public string approved_by { get; set; }
        public string no { get; set; }
        public Decimal pro { get; set; }
        public string flag { get; set; }
        public string XTY { get; set; }
        //LOAN MASTER
        public DateTime loan_date { get; set; }
        public string ln_speacial { get; set; }
        public DateTime recodt { get; set; }
        public string claim_issued { get; set; }
        public DateTime claim_date { get; set; }
        public string lnr_issued { get; set; }
        public DateTime lnr_date { get; set; }
        public string loanee_name { get; set; }
        public string caste_id { get; set; }
        public string sex { get; set; }
        public string relgn_id { get; set; }
        public string mail_hno { get; set; }
        public string mail_add1 { get; set; }
        public string mail_add2 { get; set; }
        public string mail_state { get; set; }
        public string mail_city { get; set; }
        public string mail_dist { get; set; }
        public string mail_pin { get; set; }
        public string perm_hno { get; set; }
        public string perm_add1 { get; set; }
        public string perm_add2 { get; set; }
        public string perm_state { get; set; }
        public string perm_city { get; set; }
        public string perm_dist { get; set; }
        public string perm_pin { get; set; }
        public string zone_id { get; set; }
        public string municipality { get; set; }
        public string ward { get; set; }
        public string occup_id { get; set; }
        public decimal yrly_income { get; set; }
        public decimal yrly_expense { get; set; }
        public decimal tot_dependent { get; set; }
        public decimal loan_amt { get; set; }
        public Int32 no_instl { get; set; }
        public decimal int_rate { get; set; }
        public string instl_scheme { get; set; }
        public decimal instl_amount { get; set; }
        public DateTime instl_cleared_upto { get; set; }
        public string repay_mode { get; set; }
        public string repay_sal_cd { get; set; }
        public string ln_security_cd { get; set; }
        public string is_secured { get; set; }
        public string ln_purpose { get; set; }
        public string rbi_purpose_cd { get; set; }
        public string prior_sect { get; set; }
        public string weaker_sect { get; set; }
        public string remarks { get; set; }
        public DateTime sanction_dt { get; set; }
        public string sanction_ref { get; set; }
        public string disbursed_by { get; set; }
        public string ln_disburse_mode { get; set; }
        public string ln_trac_hd { get; set; }
        public string ln_trac_no { get; set; }
        public string loss_asset { get; set; }
        public string end_loan { get; set; }
        public string clos_flag { get; set; }
        public DateTime clos_date { get; set; }
        public string clos_type { get; set; }
        public string clos_adjusted { get; set; }
        public string clos_adj_nloan_id { get; set; }
        public DateTime old_ac_no { get; set; }
        public DateTime close_date { get; set; }
        public string created_by1 { get; set; }
        public DateTime created_on1 { get; set; }
        public string modified_by1 { get; set; }
        public DateTime modified_on1 { get; set; }
        public string tag { get; set; }
        public DateTime ln_date { get; set; }
        public DateTime cal_date { get; set; }
        public decimal roi { get; set; }
        public decimal sbamt { get; set; }
        public decimal interest { get; set; }
        public string smember_id { get; set; }
        public string surity_name { get; set; }
        public string msgbox { get; set; }
        public decimal tot_amt { get; set; }

       
    }
}
