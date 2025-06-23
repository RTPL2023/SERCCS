using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{

    public class OccupMast
    {
        DBConfig config = new DBConfig();
        string sql;
        public string occup_id { get; set; }
        public string occup_name { get; set; }
        public List<OccupMast> getOccupMast()
        {
            string sql;
            sql = "select * from Occup_Mast";
            config.singleResult(sql);
            List<OccupMast> lstom = new List<OccupMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    OccupMast om = new OccupMast();
                    om.occup_id = dr["occup_id"].ToString();
                    om.occup_name = dr["occup_name"].ToString();
                    lstom.Add(om);
                }
            }
            return lstom;
        }

    }
}