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
using SERCCS.Models.Views;
using SERCCS.Controllers;


namespace SERCCS.Models.Database
{
    public class loanformissue
    {
        DBConfig config = new DBConfig();
        String sql;
        public string issue_date { get; set; }
        public DateTime issue_date1 { get; set; }
        public String cont_no { get; set; }
        public String sr_no { get; set; }
        public String name { get; set; }
        public String lf_no { get; set; }
        public String lf_no_to { get; set; }
        public DateTime rec_date { get; set; }
        public String ac_hd { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String type { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public int is_deleted { get; set; }
        public string Receive_date { get; set; }


        
    }
}