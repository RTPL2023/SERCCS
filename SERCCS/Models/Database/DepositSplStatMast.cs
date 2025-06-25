using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class DepositSplStatMast
    {
        DBConfig config = new DBConfig();
        public String spl_status { get; set; }
        public String status_desc { get; set; }
        public Decimal add_deposit_int { get; set; }
      
        public String is_int_pay { get; set; }
        public String int_play_depend_on { get; set; }

        public List<DepositSplStatMast> getStatusDescfromDepositSplStatMast()
        {
            string sql;
            sql = "select * from deposit_splstat_mast ORDER BY CASE WHEN status_desc = 'GENERAL' then 1 END ASC";
            config.singleResult(sql);
            List<DepositSplStatMast> lstdssm = new List<DepositSplStatMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositSplStatMast dssm = new DepositSplStatMast();
                    dssm.status_desc = dr["status_desc"].ToString();
                    dssm.spl_status = dr["spl_status"].ToString();


                    lstdssm.Add(dssm);
                }
            }
            return lstdssm;
        }
    }
}