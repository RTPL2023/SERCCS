using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

//using SERCCS.App_Code;

namespace SERCCS.Models.Database
{
    public class TempShareLedger
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public DateTime vch_date { get; set; }
        public string VCH_TYPE { get; set; }
        public string vch_no { get; set; }
        public string vch_srl { get; set; }
        public string DR_CR { get; set; }
        public decimal TR_AMOUNT { get; set; }
        public decimal BAL_AMOUNT { get; set; }
        public string CERTIFICATE_NO { get; set; }
        public DateTime CERTIFICATE_DATE { get; set; }
        public string CERT_PRINT_FLAG { get; set; }       
        public string DUP_CERT { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_ON { get; set; }
        public string COMPUTER_NAME { get; set; }
        public string MODIFIED_BY { get; set; }
        public DateTime MODIFIED_ON { get; set; }
        public string MCOMPUTER_NAME { get; set; }
        public decimal prin_amount { get; set; }
        public decimal INT_AMOUNT { get; set; }
        public decimal prin_bal { get; set; }
        public decimal int_bal { get; set; }
        public string INSERT_MODE { get; set; }
        public string bankcd { get; set; }
        public string VCH_ACHD { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string member_id { get; set; }
        public decimal FACE_VAL { get; set; }
        public decimal UNITS { get; set; }
        public string DIST_NO_FROM { get; set; }
        public string DIST_NO_TO { get; set; }
        public Int64 queue_id { get; set; }
        public string user { get; set; }
        public string ac_hd { get; set; }
        public string ac_no { get; set; }
        public string cont_no { get; set; }

        
    }
        
}
     
    

