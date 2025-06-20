using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;

using System.Data;
namespace SERCCS.Models.Database
{
    public class CmtdLedger
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string member_id { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }
        public string dr_cr { get; set; }
        public string vch_mode { get; set; }
        public Decimal prin_amount { get; set; }
        public Decimal int_amount { get; set; }
        public Decimal prin_bal { get; set; }
        public Decimal int_bal { get; set; }
        public string chq_no { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string insert_mode { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public int btnvalue { get; set; }
        public string member_name { get; set; }
        public string Date { get; set; }
        public string dt { get; set; }
        //***** For CMTD Checking***************
        public Decimal W_1 { get; set; }
        public Decimal W_2 { get; set; }
        public Decimal W_3 { get; set; }
        public Decimal W_4 { get; set; }
        public Decimal W_5 { get; set; }
        public Decimal W_6 { get; set; }
        public Decimal W_7 { get; set; }
        public Decimal W_8 { get; set; }
        public Decimal W_9 { get; set; }
        public Decimal W_10 { get; set; }
        public Decimal W_11 { get; set; }
        public Decimal W_12 { get; set; }
        public string str_vch_date { get; set; }

    }
}