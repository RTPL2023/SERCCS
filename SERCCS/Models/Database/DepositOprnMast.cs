using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositOprnMast
    {
        DBConfig config = new DBConfig();
        public String oprn_mode { get; set; }
        public String oprn_desc { get; set; }

       

    }
}