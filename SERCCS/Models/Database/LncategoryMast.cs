using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    
    public class LncategoryMast
    {
     DBConfig config = new DBConfig();
     string sql;
     public String ln_speacial { get; set;}
     public String ln_spcl_desc{ get; set;}
     public Decimal less_int { get; set; }
     public String is_interest { get; set; }

       
    }
}