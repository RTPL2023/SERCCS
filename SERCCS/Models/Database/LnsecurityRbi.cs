using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class LnsecurityRbi
    {
        DBConfig config = new DBConfig();
        string sql;
        public String ln_security_cd { get; set; }
        public String ln_security_desc { get; set; }
        public String is_applicable { get; set; }
        public Int64 frame_index { get; set; }
        public String fix_achd { get; set; }
        public Int32 fix_gldrate { get; set; }
        public String is_mat_diary { get; set; }

        
    }
}