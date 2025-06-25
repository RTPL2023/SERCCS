using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class DepositDBUtility
    {
        DBConfig config = new DBConfig();
        public DepositMast getDepositMastDetailByAcno(string acno, string achd)
        {
            //  sql = "SELECT * from deposit_mast WHERE BRANCH_ID = 'MN' AND AC_HD =  user_id = '" + _UserName + "'  and user_password = '" + encpwd + "'";
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = 'MN' AND AC_HD = '" + achd + "' AND AC_NO = '" + acno + "' ORDER BY AC_NO";
            config.singleResult(sql);

            DepositMast dm = new DepositMast();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {

                    dm.ac_name = Convert.ToString(dr["ac_name"]);
                    dm.contno = Convert.ToString(dr["contno"]);
                    dm.oprn_mode = Convert.ToString(dr["oprn_mode"]);
                    dm.ac_closed = Convert.ToString(dr["ac_closed"]);

                }

            }
            else
            {
                dm = null;
            }
            return dm;
        }
        public DepositMast getDepositMastDetailByConNo(string conno, string achd)
        {
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = 'MN' AND AC_HD = '" + achd + "' AND CONTNO = '" + conno + "' ORDER BY ac_no";
            config.singleResult(sql);
            DepositMast dm = new DepositMast();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {

                    dm.ac_name = Convert.ToString(dr["ac_name"]);
                    dm.ac_no = Convert.ToString(dr["ac_no"]);
                    dm.oprn_mode = Convert.ToString(dr["oprn_mode"]);
                    dm.ac_closed = Convert.ToString(dr["ac_closed"]);
                    dm.contno = Convert.ToString(dr["contno"]);
                }

            }
            else
            {
                dm = null;
            }
            return dm;
        }

    }
}
