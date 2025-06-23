using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class ReligionMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string relgn_id { get; set; }
        public string relgn_name { get; set; }

        public List<ReligionMast> getReligionMast()
        {
            string sql;
            sql = "select * from Religion_Mast ORDER BY CASE WHEN Relgn_name = 'HINDU' then 1 END ASC";
            config.singleResult(sql);
            List<ReligionMast> lstrm = new List<ReligionMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ReligionMast rm = new ReligionMast();
                    rm.relgn_id = dr["relgn_id"].ToString();
                    rm.relgn_name = dr["relgn_name"].ToString();
                    lstrm.Add(rm);
                }
            }
            return lstrm;
        }
    }
}