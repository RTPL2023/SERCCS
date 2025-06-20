using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class LoanLedgerUtility
    {
        DBConfig config = new DBConfig();

        public decimal prin_bal { get; set; }
        public string XCONT1 { get; set; }
        public string XL_INST1 { get; set; }
        public string xacno1 { get; set; }
        public string XAA1 { get; set; }
        public string XLOANNO1 { get; set; }
        public string XNAME1 { get; set; }
        public decimal xinst1 { get; set; }
        public decimal i1 { get; set; }
        public decimal L1 { get; set; }
        public decimal R1 { get; set; }
        public decimal IA1 { get; set; }
        public decimal XIA1 { get; set; }
        public decimal xprin1 { get; set; }
        public string xx1 { get; set; }
        public Decimal XNO1 { get; set; }
        public decimal OS11 { get; set; }
        public decimal OS2 { get; set; }
        public decimal SI1 { get; set; }
        public decimal B { get; set; }





        public string tab_contno { get; set; }
        public string tab_loanno { get; set; }
        public string tab_name { get; set; }
        public string tab_instamt { get; set; }
        public string tab_no { get; set; }
        public string tab_loan_amt { get; set; }
        public string tab_ri { get; set; }
        public string tab_inst { get; set; }
        public string tab_prin { get; set; }
        public string tab_int { get; set; }
        public string msg { get; set; }
        public decimal clwamt { get; set; }

        


    }
}















