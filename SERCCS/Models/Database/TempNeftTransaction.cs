using SERCCS.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class TempNeftTransaction
    {
        DBConfig config = new DBConfig();
        public Int64 queue_id { get; set; }
        public string branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public string ac_hd { get; set; }
        public string ac_no_or_l_no { get; set; }
        public string employee_id { get; set; }
        public string member_name { get; set; }
        public Decimal net_amount { get; set; }
        public string bank_ac_no { get; set; }
        public string bank_name { get; set; }
        public string branch_name { get; set; }
        public string branch_code { get; set; }
        public string ifscode { get; set; }
        public Decimal amount_credited { get; set; }
        public Decimal neft_charge { get; set; }
        public DateTime credited_date { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string list_no { get; set; }

        
    }
}
