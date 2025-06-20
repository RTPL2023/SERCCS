using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Database;
using SERCCS.Models.Views;
using Oracle.ManagedDataAccess.Client;

namespace SERCCS.Models.Database
{
    public class Balance_Sheet
    {
        DBConfig config = new DBConfig();
        public DateTime f_date { get; set; }
        public DateTime t_date { get; set; }
        public string ac_hd { get; set; }
        public string ac_DESC { get; set; }
        public decimal ob_l { get; set; }
        public decimal add_l { get; set; }
        public decimal less_l { get; set; }
        public decimal bal_l { get; set; }
        public decimal ob_a { get; set; }
        public decimal add_a { get; set; }
        public decimal less_a { get; set; }
        public decimal bal_a { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string particulars { get; set; }
        public decimal bal_c { get; set; }
       

    }
}
