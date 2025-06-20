using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class Ledger
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public String vch_type { get; set; }
        public String vch_achd { get; set; }
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


         public double tr_amount { get; set; }
         public decimal tran_amount { get; set; }

        public string member_id { get; set; }

        public Int64 units { get; set; }
        public decimal face_val { get; set; }
      
        public string certificate_no { get; set; }
        public DateTime certificate_date { get; set; }
        public string cert_prnt_flag { get; set; }
        public Int64 dist_no_from { get; set; }
        public Int64 dist_no_to { get; set; }
     
        public string dup_cert { get; set; }

       //LOAN++++++++++++++++++++++++++++++
        public string loan_id { get; set; }
        public Decimal loan_amt { get; set; }



        public DateTime chq_date { get; set; }
      
        public Decimal aint_amount { get; set; }
        public Decimal ichrg_amount { get; set; }
     
        public Decimal int_due { get; set; }
        public Decimal int_due_actual { get; set; }
        public Decimal aint_due { get; set; }
        public Decimal ichrg_due { get; set; }
        public Decimal rebate_allowed { get; set; }
       
        public string approval_flag { get; set; }
        public string approved_by { get; set; }
        public Int64 no { get; set; }
        public string pro { get; set; }
        public decimal bal_amount { get; set; }
        public string query { get; set; }
        public string table { get; set; }


       
    }
}