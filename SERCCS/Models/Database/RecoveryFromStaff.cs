using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class RecoveryFromStaff
    {
        DBConfig config = new DBConfig();
        public DateTime date_posting { get; set; }
        public String month_deduct { get; set; }
        public String employee_id { get; set; }
        public String year_deduct { get; set; }
        public String name { get; set; }
        public String book_no { get; set; }
        public String Sb_no { get; set; }
        public Int32 vch_srl { get; set; }
        public Decimal loan { get; set; }
        public Decimal cmtd { get; set; }
        public Decimal sb { get; set; }
        public String posting { get; set; }
        public String Created_By { get; set; }
        public DateTime Created_On { get; set; }
        public String Computer_Name { get; set; }
        public decimal TotLoanAmt { get; set; }
        public decimal TotSbAmt { get; set; }
        public decimal TotCMTDAmt { get; set; }



       
    }
}