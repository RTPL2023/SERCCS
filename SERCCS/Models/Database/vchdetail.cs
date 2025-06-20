using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class vchdetail
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public DateTime vch_date { get; set; }
        public string vch_no { get; set; }
        public Int32 vch_srl { get; set; }
        public string vch_drcr { get; set; }
        public string ac_hd { get; set; }
        public string vch_pacno { get; set; }
        public string vch_type { get; set; }
        public string vch_acname { get; set; }
        public decimal vch_amt { get; set; }
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



        
    }
}