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
    public class Room_Rate
    {
        DBConfig config = new DBConfig();
        public string licence_code { get; set; }
        public string h_code { get; set; }
        public string room_no { get; set; }
        public string r_date { get; set; }
        public decimal r_rate { get; set; }
        public string desc { get; set; }
        public string value { get; set; }
        public string text { get; set; }
        public string room_type { get; set; }
        public decimal r_rate1 { get; set; }
        

        
    }
}
