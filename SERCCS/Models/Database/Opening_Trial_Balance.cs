using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;
using Oracle.ManagedDataAccess.Client;
namespace SERCCS.Models.Database
{
    public class Opening_Trial_Balance
    {
        DBConfig config = new DBConfig();
        public string ac_hd { get; set; }
        public decimal open_bal { get; set; }
        public string fin_year { get; set; }
        public string msg { get; set; }
        
    }
}
