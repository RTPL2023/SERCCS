using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class Delux_Room_Type
    {
        DBConfig config = new DBConfig();
        public string licence_code { get; set; }
        public string h_code { get; set; }
        public string room_no { get; set; }      
        public string ac_non_ac { get; set; }
        public string des { get; set; }
    }
}
