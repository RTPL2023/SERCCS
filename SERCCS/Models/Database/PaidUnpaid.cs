using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class PaidUnpaid
    {
        DBConfig config = new DBConfig();
        string sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string employee_id { get; set; }
        public string list_no { get; set; }
        public string po_no { get; set; }
        public Decimal net_amount { get; set; }
        public string paid_unpaid { get; set; }
        public DateTime paid_date { get; set; }
        public string cash_cheque { get; set; }
        public string cheque_no { get; set; }
        public string bank_name { get; set; }
        public string XPACNO { get; set; }

       
    }
}