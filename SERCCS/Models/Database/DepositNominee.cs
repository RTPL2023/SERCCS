using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositNominee
    {
        DBConfig config = new DBConfig();
        string sql;

        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public Int32 nom_srl { get; set; }
        public String member_id { get; set; }
        public String nom_id { get; set; }
        public string serial_no { get; set; }
        public string nom_name { get; set; }
        public string cont_no { get; set; }




        
    }
}







