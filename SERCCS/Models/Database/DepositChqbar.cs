using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositChqbar
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public String status_id { get; set; }
        public Int32 status_srl { get; set; }
        public Int32 chq_srl { get; set; }
        public String chq_book_no { get; set; }
        public String chq_no { get; set; }
        public String restr_status { get; set; }
        public DateTime revived_on { get; set; }

    }
}