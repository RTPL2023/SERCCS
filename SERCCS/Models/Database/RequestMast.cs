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
    public class RequestMast
    {

        DBConfig config = new DBConfig();
        String sql;
        public string cont_no { get; set; }
        public String member_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public String loan_id { get; set; }
        public string page_name { get; set; }
        public string controller { get; set; }
        public String requested_by { get; set; }
        public DateTime request_date { get; set; }
        public string completed_by { get; set; }
        public string Canceled_By { get; set; }
        public DateTime Cancel_date { get; set; }
       
        public string mcomputer_name { get; set; }
        public DateTime completion_date { get; set; }
        public Int32 status_flag { get; set; }
        public Int64 queue_id { get; set; }
        public string dr_cr { get; set; }

        
    }
}
