using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;


using System.Data;

namespace SERCCS.Models.Database
{
    public class ClwCcs
    {
        DBConfig config = new DBConfig();

        
        public string ID { get; set; }
        public string CO7_Number { get; set; }
        public string CO7_Date { get; set; }
        public string BillUnit { get; set; }
        public string ED_Code { get; set; }
        public string ED_Desc { get; set; }
        public string EMP_No { get; set; }
        public string Emp_Name { get; set; }
        public string Ref_No { get; set; }
        public decimal Amount { get; set; }


       
    }
}
