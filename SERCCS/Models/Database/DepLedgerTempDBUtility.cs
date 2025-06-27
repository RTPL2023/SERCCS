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
    public class DepLedgerTempDBUtility
    {
        DBConfig config = new DBConfig();

        String sql;


        //*********DEPOSIT MASTER***********************************************
        public DepositLedgerTemp getDepositLedgerTempByAcno(string acno, string achd)
        {
            string sql = "select * from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            //select* from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID = 'MN' AND AC_HD = 'SB' AND AC_NO = '24619' ORDER BY VCH_DATE, VCH_NO,VCH_SRL

            config.singleResult(sql);
            DepositLedgerTemp dm = new DepositLedgerTemp();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                dm.dr_cr = dr["DR_CR"].ToString();
                dm.prin_amount = Convert.ToDecimal(dr["prin_amount"]);



            }
            else
            {
                dm = null;
            }
            return dm;
        }
        public List<DepositLedgerTemp> getDepositLedgerTempByAcnoForDepWith(string acno, string achd)
        {
            string sql = "select * from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            //select* from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID = 'MN' AND AC_HD = 'SB' AND AC_NO = '24619' ORDER BY VCH_DATE, VCH_NO,VCH_SRL
            List<DepositLedgerTemp> dml = new List<DepositLedgerTemp>();
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositLedgerTemp dm = new DepositLedgerTemp();
                    dm.dr_cr = dr["DR_CR"].ToString();
                    dm.prin_amount = Convert.ToDecimal(dr["prin_amount"]);
                    dml.Add(dm);
                }
                //DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];





            }
            return dml;
        }
        public List<DepositLedgerTemp> getDepositLedgerTempListByAcno(string acno, string achd)
        {
            List<DepositLedgerTemp> dml = new List<DepositLedgerTemp>();
            string sql = "select * from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            //select* from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID = 'MN' AND AC_HD = 'SB' AND AC_NO = '24619' ORDER BY VCH_DATE, VCH_NO,VCH_SRL

            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositLedgerTemp dm = new DepositLedgerTemp();
                    dm.dr_cr = dr["DR_CR"].ToString();
                    dm.prin_amount = Convert.ToDecimal(dr["prin_amount"]);
                    dml.Add(dm);
                }
                //DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];





            }
            return dml;
        }
    }
}
