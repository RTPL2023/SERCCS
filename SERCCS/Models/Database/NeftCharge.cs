using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class NeftCharge
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string bank_name { get; set; }
        public DateTime xdate { get; set; }
        public Decimal from_amt { get; set; }
        public Decimal to_amt { get; set; }
        public Decimal charges_amt { get; set; }


       
    }
}