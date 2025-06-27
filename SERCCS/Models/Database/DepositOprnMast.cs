using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositOprnMast
    {
        DBConfig config = new DBConfig();
        public String oprn_mode { get; set; }
        public String oprn_desc { get; set; }


        public List<DepositOprnMast> getOprnModeFromDepositOprnMast()
        {
            string sql;
            sql = "select * from deposit_oprn_mast ORDER BY CASE WHEN oprn_desc = 'SINGLE' then 1 END ASC";
            config.singleResult(sql);
            List<DepositOprnMast> lstdom = new List<DepositOprnMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositOprnMast dom = new DepositOprnMast();
                    dom.oprn_desc = dr["oprn_desc"].ToString();
                    dom.oprn_mode = dr["oprn_mode"].ToString();


                    lstdom.Add(dom);
                }
            }
            return lstdom;
        }
    }
}