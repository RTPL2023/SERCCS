using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class FD
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string employee_id { get; set; }
        public string member_name { get; set; }
        public string member_id { get; set; }
        public DateTime member_date { get; set; }
        public string mail_add1 { get; set; }
        public string mail_add2 { get; set; }
        public string mail_dist { get; set; }
        public string mail_city { get; set; }
        public string mail_state { get; set; }
        public string mail_pin { get; set; }
        public DateTime birth_date { get; set; }
        public string cmtdno { get; set; }
        public string book_no { get; set; }
        public string t_no { get; set; }
        public string grdn_name { get; set; }
        public string reln_id { get; set; }
        public string sex { get; set; }
        public string occup_id { get; set; }
        public string pan_no { get; set; }

        public string Nom_Name { get; set; }
        public string Nom_Pan { get; set; }
        public DateTime Nom_DOB { get; set; }
        public string Nom_AAdhar { get; set; }
        public string Nom_Reln { get; set; }













    }
}
