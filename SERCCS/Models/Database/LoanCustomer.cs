using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LoanCustomer
    {
        DBConfig config = new DBConfig();
        string sql;
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String loan_id { get; set; }
        public Int32 cust_srl { get; set; }
        public DateTime loan_date { get; set; }
        public String cust_id { get; set; }
        public String member_id { get; set; }
        public String cust_name { get; set; }
        public String grdn_name { get; set; }
        public String reln_id { get; set; }
        public String designation { get; set; }
        public String occup_id { get; set; }
        public String sex { get; set; }
        public String pan_no { get; set; }
        public String sign_flag { get; set; }
        public String clos_flag { get; set; }
        public DateTime recodt { get; set; }

       
        
    }
}