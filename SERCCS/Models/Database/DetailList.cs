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

namespace SERCCS.Models.Database
{
    public class DetailList
    {
        DBConfig config = new DBConfig();
        public string msgbox { get; set; }
        public string cont_no { get; set; }
        public string Name { get; set; }
        public string Op_Date { get; set; }
        public string vch_date { get; set; }
        public string dr_cr { get; set; }

        public decimal Int_Payable { get; set; }
        public decimal Instalment { get; set; }
        public decimal Interest { get; set; }
        public decimal Balance { get; set; }
        public decimal Int_Rate { get; set; }
        public decimal total_int { get; set; }
        public decimal bal { get; set; }
        public decimal int_rec { get; set; }
        public decimal prin_amount { get; set; }
        public decimal dr_amount { get; set; }
        public decimal cr_amount { get; set; }


       
    }
}