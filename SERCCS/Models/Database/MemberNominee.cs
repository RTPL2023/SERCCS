using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class MemberNominee
    {
        DBConfig config = new DBConfig();
        String sql;

        public String branch_id { get; set; }
        public String member_id { get; set; }
        public Int32 nom_srl { get; set; }
        public String nom_name { get; set; }
        public String nom_reln_id { get; set; }
        public DateTime nom_birth_dt { get; set; }
        public String nom_hno { get; set; }
        public String nom_add1 { get; set; }
        public String nom_add2 { get; set; }
        public String nom_city { get; set; }
        public String nom_dist { get; set; }
        public String nom_state { get; set; }
        public String nom_pin { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public Int32 sl_no { get; set; }
        
    }
}