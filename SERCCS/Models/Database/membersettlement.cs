using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class membersettlement
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public DateTime bill_date { get; set; }
        public String employee_id { get; set; }
        public String member_id { get; set; }
        public String payment_mode { get; set; }
        public Int64 list_no { get; set; }
        public Int64 po_no { get; set; }
        public Int64 sh_amt { get; set; }
        public Int64 cmtd_amt { get; set; }
        public Int64 sb_amt { get; set; }
        public Int64 total_amt { get; set; }
        public String pan_number { get; set; }
        public DateTime farewel_date { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String charges_amt { get; set; }
        public String member_name { get; set; }

       
    }
}