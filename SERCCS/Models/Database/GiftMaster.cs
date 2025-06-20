using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class GiftMaster
    {
        DBConfig config = new DBConfig();

        public string gift_name { get; set; }
        public string gift_cd { get; set; }


      
    }
}
