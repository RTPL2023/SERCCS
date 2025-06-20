using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositIntMast
    {
        DBConfig config = new DBConfig();

        String sql;
        public String ac_hd { get; set; }
        public String scheme_desc { get; set; }
        public String scheme_apply_to { get; set; }

       
      
    }
}