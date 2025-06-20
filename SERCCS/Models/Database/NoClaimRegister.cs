using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class NoClaimRegister
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string Cont_No { get; set; }
        public string employee_id { get; set; }
        public string name { get; set; }
        public DateTime issue_date { get; set; }
        public string str_issue_date { get; set; }
        public string bu_no { get; set; }
        public string t_no { get; set; }
        public string desig { get; set; }
        public string send_to { get; set; }
        public string office { get; set; }
        public string ref_no { get; set; }
        public DateTime ref_date { get; set; }
        public string str_ref_date { get; set; }
        public DateTime rt_date { get; set; }
        public string str_rt_date { get; set; }
        public string created_by { get; set; }
        public string created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on  { get; set; }
        public string str_modified_on  { get; set; }
        public string mcomputer_name { get; set; }
       



       
    }
}