using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class GiftIssue
    {
        DBConfig config = new DBConfig();

        public DateTime issue_date { get; set; }
        public string cont_no { get; set; }
        public Int32 qty { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string item_code { get; set; }
        public string Xmsg { get; set; }
        public string member_id { get; set; }
        public string member_name { get; set; }
        public string item_name { get; set; }
        public string issued_on { get; set; }
        public string count { get; set; }





      
    }
}
