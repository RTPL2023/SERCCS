using SERCCS.Includes;
using SERCCS.Models.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class LOAN_INSTL_NON_RECOVERY
    {
        DBConfig config = new DBConfig();

        public string contno { get; set; }
        public string loan_id { get; set; }
        public string month { get; set; }
        public string is_recovery { get; set; }
        public string year { get; set; }
        public string lnr_issued { get; set; }
        public string claim_issued { get; set; }
        public DateTime lnr_issued_date { get; set; }
        public DateTime claim_issued_date { get; set; }
        public DateTime created_date { get; set; }
        public string is_informed { get; set; }
        public DateTime recovery_date { get; set; }
        public string ac_hd { get; set; }
       

    }
}
