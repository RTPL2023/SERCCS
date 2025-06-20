using SERCCS.Models.Views;
using SERCCS.Models.Database;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net.Mail;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
//using System.Web.MVC;
using Microsoft.AspNetCore.Http;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LogOut
    { DBConfig config = new DBConfig();
        private LogOut lo;

        public string user_id { get; set; }
        public int logged_in { get; set; }
        public DateTime login_datetime { get; set; }
       
        public DateTime logout_datetime { get; set; }
       
        
        

    }
}
