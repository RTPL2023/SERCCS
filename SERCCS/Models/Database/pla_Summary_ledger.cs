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
    public class pla_Summary_ledger
    {

            DBConfig config = new DBConfig();
            public string ac_hd { get; set; }
         
            public string ac_desc { get; set; }
            public string schedule { get; set; }
            public decimal amount { get; set; }
            public string fin_year { get; set; }
            public string profit { get; set; }
            public string loss { get; set; }
          

       
    }
}
