using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class VchlDetail
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public String vch_drcr { get; set; }
        public String ac_hd { get; set; }
        public String vch_pacno { get; set; }
        public String vch_acname { get; set; }
        public Decimal vch_amt { get; set; }
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

        
    }
}
  

