using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class TempPassbookPrintDetail
    {
        DBConfig config = new DBConfig();
        string sql;
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public Int32 passbook_srl { get; set; }
        public Int32 pbook_page_no { get; set; }
        public Int32 pbook_line_no { get; set; }
        public String passbook_no { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int32 vch_srl { get; set; }
        public Int32 L_no_new { get; set; }
        public Int32 Pg_no_new { get; set; }
        public Int64 queue_id { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string msg { get; set; }

        
    }
}
