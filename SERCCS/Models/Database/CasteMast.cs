using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class CasteMast
    {
        DBConfig config = new DBConfig();

        public string caste_name { get; set; }
        public string caste_id { get; set; }
        public List<CasteMast> getCasteMast()
        {
            string sql;
            sql = "select * from Caste_Mast";
            config.singleResult(sql);
            List<CasteMast> lstcm = new List<CasteMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    CasteMast cm = new CasteMast();
                    cm.caste_name = dr["caste_name"].ToString();
                    cm.caste_id = dr["caste_id"].ToString();
                    lstcm.Add(cm);
                }
            }
            return lstcm;
        }
    }
}