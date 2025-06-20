using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{

    public class DepositPassbook
    {

        DBConfig config = new DBConfig();

        String sql;
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public Int32 passbook_srl { get; set; }
        public String passbook_no { get; set; }
        public String issue_type { get; set; }
        public DateTime issue_date { get; set; }
        public string issue_date1 { get; set; }

        public DateTime bf_date { get; set; }
        public String remarks { get; set; }
        public String clos_flag { get; set; }
        public Decimal bf_balance { get; set; }
        public String bfbal_drcr { get; set; }
        public String updt_mode { get; set; }
        public Int32 page_count { get; set; }
        public string bfbal_new { get; set; }
        public string rec { get; set; }
        public String close_flag { get; set; }


    }
}