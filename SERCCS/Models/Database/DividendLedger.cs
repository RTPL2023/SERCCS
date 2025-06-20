using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class DividendLedger
    {
        DBConfig config = new DBConfig();

        public string branch_id { get; set; }
        public string member_id { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int32 vch_srl { get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }
        public string dr_cr { get; set; }
        public Int32 div_post_year_to { get; set; }
        public string div_pay_mode { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public string bankcd { get; set; }
        public decimal tr_amount { get; set; }
        public decimal tr_amount1 { get; set; }
        public decimal bal_amount { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string insert_mode { get; set; }
        public decimal tot_amt { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string tran_Particulars { get; set; }

      
    }
}