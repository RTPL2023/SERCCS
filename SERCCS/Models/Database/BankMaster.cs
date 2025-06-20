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
    public class BankMaster
    {
        public String bankcd { get; set; }
        public String bankname { get; set; }
    }
}
