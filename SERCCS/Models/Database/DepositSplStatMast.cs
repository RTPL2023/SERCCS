using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class DepositSplStatMast
    {
        DBConfig config = new DBConfig();
        public String spl_status { get; set; }
        public String status_desc { get; set; }
        public Decimal add_deposit_int { get; set; }
      
        public String is_int_pay { get; set; }
        public String int_play_depend_on { get; set; }

       
    }
}