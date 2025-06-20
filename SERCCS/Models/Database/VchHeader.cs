using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using Oracle.ManagedDataAccess.Client;


namespace SERCCS.Models.Database
{
    public class VchHeader
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public String vch_type { get; set; }
        public String vch_narr { get; set; }
        public String insert_mode { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String tag { get; set; }
        public String Pannel { get; set; }
        public String value { get; set; }
        public String text { get; set; }

       


    }
}
