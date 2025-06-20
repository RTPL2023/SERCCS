using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class TdIntdetl
    {
        DBConfig config = new DBConfig();

        String sql;
        public string ac_hd { get; set; }
        public DateTime weff_date { get; set; }
        public DateTime to_date1 { get; set; }
        public Int32 upto_flag { get; set; }
        public Int32 period_dd { get; set; }
        public Int32 period_mm { get; set; }
        public Int32 period_yy { get; set; }
        public string comments { get; set; }
        public decimal tdint_rate { get; set; }
        public string tag { get; set; }
        public string F { get; set; }
        public string value { get; set; }
        public string text { get; set; }
        public Int32 srl { get; set; }
        public decimal last_tdint_rate { get; set; }
        public decimal second_last_tdint_rate { get; set; }

        
    }
}