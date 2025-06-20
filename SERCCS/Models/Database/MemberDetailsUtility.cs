using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class MemberDetailsUtility
    {
        DBConfig config = new DBConfig();
        public decimal Share { get; set; }
        public decimal Cmtd { get; set; }
        public string SbAcNo { get; set; }
        public string SbAmt { get; set; }
        public string ListNo { get; set; }
        public string ModeOfPayment { get; set; }
        public string PoNo { get; set; }
        public string employee_id { get; set; }
        public string member_name { get; set; }
        public string member_id { get; set; }


        

    }
}
