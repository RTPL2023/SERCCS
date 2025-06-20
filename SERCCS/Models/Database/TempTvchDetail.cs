using SERCCS.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class TempTvchDetail
    {
        DBConfig config = new DBConfig();
        String sql;
        public Int64 queue_id { get; set; }
        public string branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public string trn_shift { get; set; }
        public Int32 counter_no { get; set; }
        public string trn_no { get; set; }
        public Int32 trn_srl { get; set; }
        public string token_no { get; set; }
        public string vch_drcr { get; set; }
        public string Mvch_drcr { get; set; }
        public string ac_hd { get; set; }
        public string vch_pacno { get; set; }
        public string vch_acname { get; set; }
        public Decimal vch_amt { get; set; }
        public string is_self { get; set; }
        public string is_chq { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_date { get; set; }
        public string bankcd { get; set; }
        public string chq_mode { get; set; }
        public string bearer_branch { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string insert_mode { get; set; }
        public string conf_flag { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string listno { get; set; }
        public String deposit_withdraw { get; set; }

        
    }
}
