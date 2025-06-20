using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{

    public class RecPayable
    {
        DBConfig config = new DBConfig();
        public DateTime f_date { get; set; }
        public DateTime t_date { get; set; }
        public String ac_hd { get; set; }
        public Decimal recievable { get; set; }
        public Decimal payable { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String drcr { get; set; }
        public decimal Cash { get; set; }
        
    }
}
