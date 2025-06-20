using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;
using OfficeOpenXml;

namespace SERCCS.Models.Database
{
    public class LoanLedgerDBUtility
    {
        DBConfig config = new DBConfig();
        String sql;
        public int cheque_no { get; set; }
        public string str_cheque_no { get; set; }

        public string name { get; set; }
        public string member_id { get; set; }
        public string cont_no { get; set; }
        public Int32 no_instl { get; set; }
        public decimal inst_amt { get; set; }

        public decimal net_pay { get; set; }
        public string list_no { get; set; }
        public string dr_cr { get; set; }
        public decimal text1 { get; set; }
        public decimal amount { get; set; }
        public decimal snln_amt { get; set; }
        public string ac_closed { get; set; }
        public string loan_no { get; set; }
        public string Date { get; set; }
        public string msgbox { get; set; }
        public decimal prin_amount { get; set; }
        public string text2 { get; set; }
        public Decimal ref_amount { get; set; }
        public Decimal ref_amount1 { get; set; }
        public Decimal ref_amount2 { get; set; }
        public Decimal ref_amount3 { get; set; }
        public Decimal ref_amount4 { get; set; }
        public Decimal ref_amount5 { get; set; }
        public Decimal ref_amount_l { get; set; }
        public String add_less { get; set; }
        public String Ref { get; set; }
        public String ref1 { get; set; }
        public String ref2 { get; set; }
        public String ref3 { get; set; }
        public String ref4 { get; set; }
        public String ref5 { get; set; }
        public String ref_l { get; set; }
        public decimal NO { get; set; }
        public decimal RI { get; set; }
        public decimal INST { get; set; }
        public decimal PRIN { get; set; }
        public decimal INT { get; set; }
        public decimal loan_amount { get; set; }
        public string COUNT { get; set; }


        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string loan_id { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }

        public string chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public string bankcd { get; set; }

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
        public string XTY { get; set; }
        public DateTime chq_date { get; set; }
        public string flag { get; set; }
        

    }
}
