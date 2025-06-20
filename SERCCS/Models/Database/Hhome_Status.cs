using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class Hhome_Status
    {
        DBConfig config = new DBConfig();
        public string licence_code { get; set; }
        public string h_code { get; set; }
        public string h_desc { get; set; }
        public string h_add { get; set; }
        public string h_phone { get; set; }
        public string h_mob { get; set; }
        public string h_owner { get; set; }
        public string oth { get; set; }
        public string licence_desc { get; set; }
        public string room_no_desc { get; set; }
        public string room_no { get; set; }

     
        
    }
}
