using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace SERCCS.Models.Database
{
    public class Users
    {
        DBConfig config = new DBConfig();
        public Int32 Id {get; set;} 
        public string allocated_branch_id {get; set;} 
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_role { get; set; }            
        public int Blocked { get; set; }
        public int tag { get; set; }
      
    }
}