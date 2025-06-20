using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;

using SERCCS.Includes;
using SERCCS.Models.Views;
using System.Data;

namespace SERCCS.Models.Database
{
    public class AccountsUtility
    {
        DBConfig config = new DBConfig();
        public DateTime F_DATE { get; set; }
        public DateTime T_DATE { get; set; }
        public decimal NP_AMT { get; set; }
        public decimal NL_AMT { get; set; }
        public decimal CR_AMT { get; set; }
        public decimal BAL_C { get; set; }
        public decimal BAL_D { get; set; }
        public decimal AMT_C { get; set; }
        public decimal AMT_D { get; set; }
        public decimal OB_C { get; set; }
        public string msg { get; set; }
        public string slno { get; set; }
        public string particulars { get; set; }
        public string Amount { get; set; }
        public string slno2 { get; set; }
        public string particulars2 { get; set; }
        public string Amount2 { get; set; }
        public string from_date { get; set; }
        public string TO_DATE1 { get; set; }
        public decimal DR_AMT { get; set; }
        public string ac_hd { get; set; }
        public string EXPENDITURE { get; set; }
        public string ASSETS { get; set; }
        public string LIABILITIES { get; set; }
        public string EARNINGS { get; set; }
        public string CAPITAL { get; set; }
        public string ADJ_AC { get; set; }
        



       

    }
}
