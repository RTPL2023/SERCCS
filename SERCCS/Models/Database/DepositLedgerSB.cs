using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositLedgerSB
    {

        DBConfig config = new DBConfig();

        String sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string ac_no { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int64 vch_srl {get; set; }
        public string vch_type { get; set; }
        public string vch_achd { get; set; }
        public string dr_cr { get; set; }
        public string contno { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public string bankcd { get; set; }
        public string chq_oprmode { get; set; }
        public decimal prin_amount { get; set; }
        public decimal int_amount{ get; set; }
        public decimal prin_bal { get; set; } 
        public decimal int_bal { get; set; }
        public string chq_bearer { get; set; }
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
        public string pan_number { get; set; }
        public string ac_name { get; set; }

        public string vch_mode { get; set; }
        public string str_vch_date { get; set; }
        //For Other Info
        public string Ac_closed { get; set; }
        public string Ac_clos_dt { get; set; }
        public string L_Oprn_Date { get; set; }
        public decimal Opening_balance { get; set; }
        public decimal current_balance { get; set; }



       
    }
}