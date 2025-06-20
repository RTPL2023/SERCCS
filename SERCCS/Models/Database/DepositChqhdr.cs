using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositChqhdr
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public String chq_book_no { get; set; }
        public DateTime date_issued { get; set; }
        public String start_chqno { get; set; }
        public String end_chqno { get; set; }
        public Int64 no_of_chqs { get; set; }


    }
}