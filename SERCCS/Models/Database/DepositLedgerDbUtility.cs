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
    public class DepositLedgerDbUtility
    {
        DBConfig config = new DBConfig();

        String sql;
        public List<TvchDetail> GetTotalDeposit(String qry)
        {
            config.Load_DTG(qry);

            List<TvchDetail> lst = new List<TvchDetail>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    TvchDetail dls = new TvchDetail();

                    dls.counter_no = Convert.ToInt32(dr["counter_no"]);
                    dls.trn_no = dr["trn_no"].ToString();
                    dls.vch_pacno = dr["vch_pacno"].ToString();
                    dls.vch_acname = dr["vch_acname"].ToString();
                    dls.vch_amt = Convert.ToDecimal(dr["vch_amt"]);
                    lst.Add(dls);
                }


            }
            return lst;
        }
        public DepositLedgerFd GetFDLedgerDetail(string acno, string achd)
        {
            sql = "select * from DEPOSIT_LEDGER_FD WHERE BRANCH_ID='MN' AND AC_HD = 'FD' AND AC_NO = '" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            config.Load_DTG(sql);

            DepositLedgerFd lst = new DepositLedgerFd();

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                lst.vch_date = Convert.ToDateTime(dr["vch_date"]);
                lst.prin_bal = Convert.ToDecimal(dr["prin_bal"]);

            }
            return lst;
        }

        public Ledger GetLedgerDetail(string acno, string achd, string contno)
        {
            if (achd == "SH")
                sql = "SELECT * FROM SHARE_LEDGER WHERE BRANCH_ID='MN' AND MEMBER_ID='" + acno + "' ORDER BY VCH_DATE, VCH_NO, VCH_SRL";
            else if (achd == "CMTD")
                sql = "select * from CMTD_LEDGER WHERE BRANCH_ID='MN' AND MEMBER_ID='" + contno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            else if (achd == "DIV")
                sql = "select * from DIVIDEND_LEDGER WHERE BRANCH_ID='MN' AND MEMBER_ID='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            config.Load_DTG(sql);

            Ledger lst = new Ledger();

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                lst.vch_date = Convert.ToDateTime(dr["vch_date"]);
                if (achd == "SH" || achd == "DIV")
                    lst.prin_bal = Convert.ToDecimal(dr["BAL_AMOUNT"]);
                else
                    lst.prin_bal = Convert.ToDecimal(dr["prin_bal"]);

            }
            return lst;
        }
        public Ledger GetLedgerDetail(string acno, string achd, string contno, string transdate)
        {
            if (achd == "LTL")
                sql = "select * from LOAN_LEDGER_LTL WHERE BRANCH_ID='MN' AND AC_HD='LTL' AND LOAN_ID='" + acno + "' AND TO_CHAR(vch_DATE, 'DD/MM/YYYY')='" + transdate + "' AND VCH_ACHD='LTL' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            else if (achd == "CON")
                sql = "select * from LOAN_LEDGER_CON WHERE BRANCH_ID='MN' AND AC_HD='CON' AND LOAN_ID='" + acno + "' AND VCH_ACHD='CON' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            else if (achd == "STL")
                sql = "select * from LOAN_LEDGER_STL WHERE BRANCH_ID='MN' AND AC_HD='STL' AND LOAN_ID='" + acno + "' AND TO_CHAR(vch_DATE, 'DD/MM/YYYY')='" + transdate + "' AND VCH_ACHD='STL' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
            else if (achd == "FES")
                sql = "select * from LOAN_LEDGER_FES WHERE BRANCH_ID='MN' AND AC_HD='FES' AND LOAN_ID='" + acno + "' AND VCH_ACHD='FES' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";





            config.Load_DTG(sql);

            Ledger lst = new Ledger();

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                lst.vch_date = Convert.ToDateTime(dr["vch_date"]);
                if (achd != "FES")
                    lst.prin_amount = Convert.ToDecimal(dr["prin_amount "]);
                else
                    lst.prin_amount = Convert.ToDecimal(dr["LOAN_AMT"]);
            }
            return lst;
        }
    }
}