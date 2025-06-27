using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositCustomer
    {
        DBConfig config = new DBConfig();
        string sql;
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public Int32 cust_srl { get; set; }
        public String member_id { get; set; }
        public String sign_flag { get; set; }
        public String member_name { get; set; }
        public String grdn_name { get; set; }
        public String reln_id { get; set; }
        public string employee_id { get; set; }
        public String occup_id { get; set; }
        public String sex { get; set; }
        public String pan_no { get; set; }
        public string if_lti { get; set; }
        public void SaveDepositCustomer(DepositCustomer dc)
        {

            config.Insert("Deposit_Customer", new Dictionary<String, object>()
            {
                    { "branch_id",dc.branch_id },
                    { "ac_hd",dc.ac_hd },
                    { "ac_no",dc.ac_no },
                    { "cust_srl",dc.cust_srl },
                    { "sign_flag",dc.sign_flag },
                    { "member_id",dc.member_id }


            });
        }
    }
}