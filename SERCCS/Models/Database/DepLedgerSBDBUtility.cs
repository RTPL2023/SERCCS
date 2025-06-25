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
    public class DepLedgerSBDBUtility
    {
        DBConfig config = new DBConfig();

        public DepositLedgerSB getDepositLedgerDetailByAcno(string acno, string achd)
        {
            string sql = "";
            if (achd == "SB")
            {
                sql = "select * from DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            }
            if (achd == "CMTD")
            {
                sql = "select * from CMTD_Ledger WHERE BRANCH_ID='MN' AND vch_achd='CMTD' AND member_id='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            }



            config.singleResult(sql);
            DepositLedgerSB dm = new DepositLedgerSB();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                dm.vch_date = Convert.ToDateTime(dr["vch_date"]);
                dm.prin_bal = Convert.ToDecimal(dr["prin_bal"]);

            }
            return dm;
        }
    }
}
