using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class LoanLedger
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_id { get; set; }
        public string str_loan_date { get; set; }
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
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string approval_flag { get; set; }
        public string approved_by { get; set; }
        public string no { get; set; }
        public Decimal pro { get; set; }
        public string computer_name { get; set; }
        public string mcomputer_name { get; set; }
        public string flag { get; set; }
        public string XTY { get; set; }
        public string name { get; set; }
        public string cont_no { get; set; }
        public string getLastLoanNo(string ac_hd, string Loan_id)
        {
            DBConfig config = new DBConfig();
            string no = "0";
            string sql = "";
            if (ac_hd == "LTL")
            {
                sql = "SELECT * FROM LOAN_LEDGER_LTL WHERE BRANCH_ID='MN' AND AC_HD='" + ac_hd + "' AND LOAN_ID='" + Loan_id + "' ORDER BY VCH_DATE, VCH_NO, VCH_SRL";
            }
            if (ac_hd == "STL")
            {
                sql = "SELECT * FROM LOAN_LEDGER_STL WHERE BRANCH_ID='MN' AND AC_HD='" + ac_hd + "' AND LOAN_ID='" + Loan_id + "' ORDER BY VCH_DATE, VCH_NO, VCH_SRL";
            }
            if (ac_hd == "FES")
            {
                sql = "SELECT * FROM LOAN_LEDGER_FES WHERE BRANCH_ID='MN' AND AC_HD='" + ac_hd + "' AND LOAN_ID='" + Loan_id + "' ORDER BY VCH_DATE, VCH_NO, VCH_SRL";
            }
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                no = Convert.ToString(dr["no"]);
                if (no == "")
                {
                    no = "0";
                }
                no = Convert.ToString(Convert.ToInt32(no) + 1);
            }
            return no;
        }

    }
}