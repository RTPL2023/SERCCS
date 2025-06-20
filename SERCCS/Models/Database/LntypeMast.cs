using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LntypeMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public String ac_hd { get; set; }
        public String lntype_desc { get; set; }
        public String loan_type { get; set; }
        public String member_reqd { get; set; }
        public String sec_flag { get; set; }
        public String is_standrd { get; set; }
        public Decimal pledge_reqd { get; set; }
        public String is_adjustable { get; set; }
        public String is_staff_loan { get; set; }
        public String perc_share { get; set; }
        public String int_achd { get; set; }
        public String is_addint { get; set; }
        public String aint_achd { get; set; }
        public String intr_achd { get; set; }
        public String aintr_achd { get; set; }
        public String ch_achd { get; set; }
        public String is_rebate { get; set; }
        public String int_scheme_cd { get; set; }
        public String int_rate_cd { get; set; }
        public String aint_scheme_cd { get; set; }
        public String aint_rate_cd { get; set; }
        public String rebate_scheme_cd { get; set; }
        public String replay_scheme_cd { get; set; }
        public String notice_scheme_cd { get; set; }
        public String letter_scheme_cd { get; set; }
        public String lndoc_scheme_cd { get; set; }
        public String is_lessint_spcl { get; set; }
        public Int64 max_surity { get; set; }
        public String updt_rt { get; set; }
        public DateTime close_date { get; set; }

        
    }
}