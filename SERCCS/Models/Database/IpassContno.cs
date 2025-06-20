  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class IpassContno
    {
        DBConfig config = new DBConfig();

        public string cont_no { get; set; }
        public string ipass { get; set; }
        public string contno_11d { get; set; }

        
    }
}
