using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{

    public class MemtypeMast
    {
        DBConfig config = new DBConfig();
        string sql;

        public string member_type { get; set; }
        public string type_desc { get; set; }
        public string code { get; set; }
        public string description { get; set; }

        public List<MemtypeMast> getshareType()
        {
            string sql;
            sql = "select * from sh_type_master ORDER BY code";

            config.singleResult(sql);
            List<MemtypeMast> lstmtm = new List<MemtypeMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    MemtypeMast mtm = new MemtypeMast();
                    mtm.code = dr["CODE"].ToString();
                    mtm.description = dr["description"].ToString();
                    lstmtm.Add(mtm);
                }
            }
            return lstmtm;
        }
        public List<MemtypeMast> getpayCategoryMaster()
        {
            string sql;
            sql = "select * from pay_category_master ORDER BY code";

            config.singleResult(sql);
            List<MemtypeMast> lstmtm = new List<MemtypeMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    MemtypeMast mtm = new MemtypeMast();
                    mtm.code = dr["CODE"].ToString();
                    mtm.description = dr["description"].ToString();
                    lstmtm.Add(mtm);
                }
            }
            return lstmtm;
        }
        public List<MemtypeMast> getmembershipStatus()
        {
            string sql;
            sql = "select * from membership_status_master ORDER BY code";

            config.singleResult(sql);
            List<MemtypeMast> lstmtm = new List<MemtypeMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    MemtypeMast mtm = new MemtypeMast();
                    mtm.code = dr["CODE"].ToString();
                    mtm.description = dr["description"].ToString();
                    lstmtm.Add(mtm);
                }
            }
            return lstmtm;
        }
       
    }
}