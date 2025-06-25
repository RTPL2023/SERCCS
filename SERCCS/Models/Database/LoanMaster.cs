using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class LoanMaster
    {
        DBConfig config = new DBConfig();

        String sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_date_m { get; set; }
        public string loan_id { get; set; }
        public string employee_id { get; set; }
        public DateTime loan_date { get; set; }
        public string ln_speacial { get; set; }
        public DateTime recodt { get; set; }
        public string claim_issued { get; set; }
        public DateTime claim_date { get; set; }
        public string lnr_issued { get; set; }
        public DateTime lnr_date { get; set; }
        public string claim_lnr { get; set; }
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
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public DateTime sanction_dt { get; set; }
        public string sanction_ref { get; set; }
        public string approval_flag { get; set; }
        public string approved_by { get; set; }
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
        public string payment_mode { get; set; }
        public DateTime close_date { get; set; }
        public string created_by1 { get; set; }
        public DateTime created_on1 { get; set; }
        public string computer_name { get; set; }
        public string modified_by1 { get; set; }
        public DateTime modified_on1 { get; set; }
        public string mcomputer_name { get; set; }
        public string tag { get; set; }
        public DateTime ln_date { get; set; }
        public DateTime cal_date { get; set; }
        public decimal roi { get; set; }
        public decimal interest { get; set; }
        public decimal net_amount { get; set; }
        public decimal prin_bal { get; set; }
        public decimal int_due { get; set; }
        public string smember_id { get; set; }
        public string surity_name { get; set; }
        public string loan_idlast { get; set; }
        public string list_No { get; set; }
        public string loan_id1 { get; set; }
        public string loan_id2 { get; set; }
        public string ac_desc { get; set; }
        public string ledger_tab { get; set; }
        public decimal tot_rcv { get; set; }
        public string loan_id_first { get; set; }
        public string book_no { get; set; }
        public string t_no { get; set; }
        public string contNo { get; set; }
        public string cmtd_acNo { get; set; }
        public string Inst_Deducted { get; set; }
        public string FES_Inst { get; set; }
        public string DATA_Figure { get; set; }
        public string srl1 { get; set; }
        public string loan_no { get; set; }
        public decimal prin_amount { get; set; }
        public decimal neft_charge { get; set; }
        public decimal total_net_pay { get; set; }
        public decimal total_loan_amount { get; set; }
        public decimal total_neft_charge { get; set; }
        public string str_claim_date { get; set; }
        public string stl_loan_id { get; set; }
        public decimal int_amt { get; set; }
        public string list_no { get; set; }
        public string po_no { get; set; }





        public LoanMaster getLoanMasterDetailByAcno(string acno, string achd)
        {
            string sql = "SELECT* FROM LOAN_MASTER WHERE BRANCH_ID = 'MN' AND AC_HD = '" + achd + "' AND LOAN_ID = '" + acno + "'";
            config.singleResult(sql);
            LoanMaster lm = new LoanMaster();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    lm.loanee_name = dr["loanee_name"].ToString();
                    lm.employee_id = dr["employee_id"].ToString();
                    lm.loan_amt = Convert.ToDecimal(dr["loan_amt"]);
                    lm.loan_date = Convert.ToDateTime(dr["loan_date"]);

                }

            }
            else
            {
                lm = null;
            }
            return lm;



        }
        public LoanMaster getLoanMasterDetailByConno(string conno, string achd)
        {
            string sql = "SELECT* FROM LOAN_MASTER WHERE BRANCH_ID = 'MN' AND AC_HD = '" + achd + "' AND EMPLOYEE_ID = '" + conno + "' order by loan_date,loan_id";
            config.singleResult(sql);
            LoanMaster lm = new LoanMaster();
            if (config.dt.Rows.Count > 0)
            {
                //foreach (DataRow dr in config.dt.Rows)
                //{
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                lm.loanee_name = dr["loanee_name"].ToString();
                lm.loan_id = dr["loan_id"].ToString();
                lm.loan_amt = Convert.ToDecimal(dr["loan_amt"]);
                lm.loan_date = Convert.ToDateTime(dr["loan_date"]);

                //}

            }
            else
            {
                lm = null;
            }
            return lm;



        }
    }
}
