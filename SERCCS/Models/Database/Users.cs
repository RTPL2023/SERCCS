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
        public string UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
     
        public string EmailID { get; set; }
        public string NewPassword { get; set; }
        public int Blocked { get; set; }
        public int tag { get; set; }


       
    }
}