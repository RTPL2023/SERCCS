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
    public class Room_Type
    {
        public string name_of_hh { get; set; }
        public string room_no { get; set; }
        public string room_desc { get; set; }
        public string h_code { get; set; }
        public string ac_non_ac { get; set; }
        DBConfig config = new DBConfig();
        
    }
}

