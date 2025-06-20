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
    public class CashAccount
    {

        public string from_date { get; set; }
        public string to_date1 { get; set; }
        public string ac_hd { get; set; }

        public string month { get; set; }
        public decimal cr_amt { get; set; }
        public decimal dr_amt { get; set; }
        public string msgbox { get; set; }
    }
}
