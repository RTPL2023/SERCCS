using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class RelnMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string reln_id { get; set; }
        public string reln_name { get; set; }

        public List<RelnMast> getRelnMast()
        {
            string sql;
            sql = "select * from Reln_Mast";
            config.singleResult(sql);
            List<RelnMast> lstrm = new List<RelnMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    RelnMast rm = new RelnMast();
                    rm.reln_id = dr["reln_id"].ToString();
                    rm.reln_name = dr["reln_name"].ToString();
                    lstrm.Add(rm);
                }
            }
            return lstrm;
        }
    }
}
    
