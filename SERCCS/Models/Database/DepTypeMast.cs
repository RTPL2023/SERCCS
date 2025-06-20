using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepTypeMast
    {
        DBConfig config = new DBConfig();

        String sql;
        public String ac_hd { get; set; }
        public String dep_desc { get; set; }
        public Decimal minbal_chq { get; set; }
        public Decimal minbal_nochq { get; set; }
        public String intp_achd { get; set; }
        public String int_achd { get; set; }
        public String int_fixed { get; set; }
        public Int64 int_freq_mm { get; set; }
        public String int_rnd_flag{ get; set; }
        public String int_closure { get; set; }
        public Decimal int_premat { get; set; }
        public Int64 min_period_dd { get; set; }
        public String dep_prefix { get; set; }
        public String time_demand { get; set; }
        public String deposit_type { get; set; }
        public String wdrw_type { get; set; }
        public String transfer_type { get; set; }
        public Decimal penal_int_perc { get; set; }
        public Decimal demand_int_rate { get; set; }
        public Decimal demand_maxminbal { get; set; }
        public Int64 int_fyr_from_mm { get; set; }
        public Int64 int_fyr_to_mm { get; set; }
        public Int64 int_period_mm { get; set; }
        public String defa_order { get; set; }
        public String int_scheme { get; set; }
        public String prmat_int_scheme { get; set; }
        public String updt_rt { get; set; }
        public String pbook_updt_mode { get; set; }
        public Int64 pbook_page_count { get; set; }
        public DateTime pbook_start_date { get; set; }
        public String photo_path { get; set; }
        public String sign_path{ get; set; }
        public String photo_pathold { get; set; }
        public String sign_pathold { get; set; }

       
    }
}