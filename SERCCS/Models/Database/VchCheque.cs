using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class VchCheque
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int64 chq_srl { get; set; }
        public String chq_no { get; set; }
        public DateTime chq_date { get; set; }
        public String bearer_branch { get; set; }
        public String bank_cd { get; set; }
        public Decimal chq_amt { get; set; }
        public String insert_mode { get; set; }
        public String bankname { get; set; }

       
    }        
}