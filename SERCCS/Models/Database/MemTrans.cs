using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;
using System.Data;


namespace SERCCS.Models.Database
{

    public class MemTrans
    {
        DBConfig config = new DBConfig();
        public string ac_hd { get; set; }
        public string member_id { get; set; }
        public DateTime xdate { get; set; }
        public string member_name { get; set; }
        public string employee_id { get; set; }
        public Decimal sbamt { get; set; }
        public string flag { get; set; }
        public string remarks { get; set; }
        public string cmtdamt { get; set; }
        public string sbno { get; set; }
        public string cmtdno { get; set; }
        public decimal vcmtd { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string refno { get; set; }
        public string empname { get; set; }
        public string billunit { get; set; }




        
    }
}
