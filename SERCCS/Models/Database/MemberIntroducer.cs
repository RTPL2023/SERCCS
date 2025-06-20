using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class MemberIntroducer
    {
        DBConfig config = new DBConfig();
        String sql;
        public String branch_id { get; set; }
        public String member_id { get; set; }
        public Int32 intr_srl { get; set; }
        public String intr_member_id { get; set; }
        public String intr_name { get; set; }

       
    }
}