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
    public class HH_Ledger
    {
        DBConfig config = new DBConfig();
        public string employee_id { get; set; }
        public string h_code { get; set; }
        public string room_no { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public string days { get; set; }
        public string name { get; set; }
        public string ac_non_ac { get; set; }
        public string address { get; set; }
        public string rec_date { get; set; }
        public decimal amount { get; set; }
        public string cr_no { get; set; }
        public decimal scurity_money { get; set; }
        public string scr_no { get; set; }
        public string ph_no { get; set; }
        public string refunded_ei { get; set; }
        public string refunded_on { get; set; }
        public string remarks { get; set; }
        public string allotment_no { get; set; }
        public string adult { get; set; }
        public string child { get; set; }
        public string behalf_of { get; set; }
        public string D1 { get; set; }
        public string D2 { get; set; }
        public string D3 { get; set; }
        public string D4 { get; set; }
        public string D5 { get; set; }
        public string D6 { get; set; }
        public string D7 { get; set; }
        public string D8 { get; set; }
        public string D9 { get; set; }
        public string D10 { get; set; }
        public string D11 { get; set; }
        public string D13 { get; set; }
        public string D12 { get; set; }
        public string D14 { get; set; }
        public string D15 { get; set; }
        public string D16 { get; set; }
        public string D17 { get; set; }
        public string D18 { get; set; }
        public string D19 { get; set; }
        public string D20 { get; set; }
        public string D21 { get; set; }
        public string D22 { get; set; }
        public string D23 { get; set; }
        public string D24 { get; set; }
        public string D25 { get; set; }
        public string D26 { get; set; }
        public string D27 { get; set; }
        public string D28 { get; set; }
        public string D29 { get; set; }
        public string D30 { get; set; }
        public string D31 { get; set; }
        public string member_id { get; set; }
        public string value { get; set; }
        public string text { get; set; }
        public decimal total_amt { get; set; }
        public string name_of_hh { get; set; }
        public string licence_code { get; set; }
        public string room_no2 { get; set; }

        public string h_desc { get; set; }
        public string licence_desc { get; set; }
        public string room_category { get; set; }
        public string loan_name { get; set; }
        public string loan_amt { get; set; }
        public string rate_int { get; set; }
        public string loan_code { get; set; }
        

      
    }
}
