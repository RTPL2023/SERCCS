using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class TempDepositLedger
    {
        DBConfig config = new DBConfig();
        public Int64 queue_id { get; set; }
        public String branch_id { get; set; }
        public string modifyvch_date { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int32 vch_srl { get; set; }
        public String vch_type { get; set; }
        public String vch_achd { get; set; }
        public String list_no { get; set; }
        public String dr_cr { get; set; }
        public String contno { get; set; }
        public String chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public String bankcd { get; set; }
        public String chq_oprmode { get; set; }
        public decimal prin_amount { get; set; }
        public decimal int_amount { get; set; }
        public decimal prin_bal { get; set; }
        public decimal int_bal { get; set; }
        public String chq_bearer { get; set; }
        public String ref_ac_hd { get; set; }
        public String ref_pacno { get; set; }
        public String ref_oth { get; set; }
        public String insert_mode { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String pan_number { get; set; }
        public String deposit_withdraw { get; set; }
        public String Mdr_cr { get; set; }

        //public double tr_amount { get; set; }


        
    }
}
