using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LnrepaySalMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public string repay_sal_cd { get; set; }
        public string repay_sal_desc { get; set; }

        
    }
}