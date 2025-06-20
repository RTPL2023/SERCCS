using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;
using Oracle.ManagedDataAccess.Client;


namespace SERCCS.Models.Database
{
    public class ShareLedger
    {
        DBConfig config = new DBConfig();
        public int no_of_share { get; set; }
        public string branch_id { get; set; }
        public decimal net_Div { get; set; }
        public string member_id { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int32 vch_srl { get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }
        public string dr_cr { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public string bankcd { get; set; }
        public decimal tr_amount { get; set; }
        public decimal bal_amount { get; set; }
        public Int32 units { get; set; }
        public decimal face_val { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string certificate_no { get; set; }
        public DateTime certificate_date { get; set; }
        public string cert_prnt_flag { get; set; }
        public Int32 dist_no_from { get; set; }
        public Int32 dist_no_to { get; set; }
        public string insert_mode { get; set; }
        public string dup_cert { get; set; }
        public string created_by { get; set; }
        public string ledger_tab { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string XTR_type { get; set; }
        public string create_dt { get; set; }
        public string modified_dt { get; set; }
        public string acc_head_ahd { get; set; }
        public decimal miscdep_baseamt { get; set; }

        public Int32 tot_unitdr { get; set; }
        public Int32 tot_unitcr { get; set; }
        public decimal tot_amtdr { get; set; }
        public decimal tot_amtcr { get; set; }
        public Int32 Bal_units { get; set; }
        public decimal sh_capital { get; set; }
        public decimal total_capital { get; set; }
        public string cert_prefix { get; set; }
        public string cert_no_from { get; set; }
        public string dist_no_from_Text { get; set; }
        public string book_no { get; set; }
        public string t_no { get; set; }
        public string employee_id { get; set; }
        public string member_name { get; set; }
        public string cert_stat { get; set; }
        public decimal div_cal_amount1 { get; set; }
        public decimal div_cal_amount2 { get; set; }
        public decimal tot_div_amount { get; set; }
        
    }
}