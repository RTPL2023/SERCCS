using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Controllers;

namespace SERCCS.Models.Database
{
    public class SettlementStatus
    {
        DBConfig config = new DBConfig();
      
        public string cont_No { get; set; }
        public string srl { get; set; }
        public string reason { get; set; }     
        public string name { get; set; }     
        public DateTime entry_Date { get; set; }
        public string  str_entry_Date { get; set; }
        public int is_Settled { get; set; }
        public DateTime settlement_Date { get; set; }
        public string str_Settlement_Date { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_On { get; set; }
        public string Computer_Name { get; set; }
        public string Modified_By { get; set; }
        public DateTime Modified_On { get; set; }      
        public string M_computer_Name { get; set; }
        public string Canceled_on { get; set; }

       
    }
}
