using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositStatusMaster
    {
        DBConfig config = new DBConfig();
        public String status_id { get; set; }
        public String status_desc { get; set; }
        public String status_type { get; set; }
        public Int32 status_srl { get; set; }
        public DateTime eff_date { get; set; }
        public string comments { get; set; }
        public string restr_status { get; set; }

     

    }
}