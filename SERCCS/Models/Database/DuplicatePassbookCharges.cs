using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class DuplicatePassbookCharges
    {
        DBConfig config = new DBConfig();
        public string ac_no { get; set; }
        public string prin_bal { get; set; }
        public decimal bal_amount { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string msgbox { get; set; }
        public string contno { get; set; }
        public string ac_name { get; set; }
        public string prin_amount { get; set; }
        public string member_id { get; set; }
        public decimal total_Sb_Charge { get; set; }
        public decimal total_cmtd_Charge { get; set; }
        public decimal vch_srl { get; set; }




       

    }
    
}
