using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositDebit
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public String db_ac_hd { get; set; }
        public String trac_hd { get; set; }
        public String trac_no { get; set; }
        public DateTime eff_date { get; set; }
        public Decimal tr_amount { get; set; }
        public Int32 freq_month { get; set; }
        public DateTime last_tr_dt { get; set; }
        public Int64 noi { get; set; }
        public String status { get; set; }

      

    }
}