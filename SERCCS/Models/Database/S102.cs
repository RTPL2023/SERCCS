using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class S102
    {
        DBConfig config = new DBConfig();
        public String ac_hd { get; set; }
        public String member_id { get; set; }
        public DateTime xdate { get; set; }
        public String member_name { get; set; }
        public String employee_id { get; set; }
        public Decimal sbamt { get; set; }
        public String flag { get; set; }
        public String remarks { get; set; }
        public String cmtdamt { get; set; }
        public String sbno { get; set; }
        public String cmtdno { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }


        
    }
}