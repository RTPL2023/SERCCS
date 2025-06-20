using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class Licence
    {
        DBConfig config = new DBConfig();
        public string licence_code { get; set; }
        public string licence_desc { get; set; }

        

    }
}
