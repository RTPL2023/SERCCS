using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class TvchLedgerDBUtility
    {

        DBConfig config = new DBConfig();

        String sql;


        public List<TvchDetail> GetTotalByDateforPrint(string DepositWithdrow, string CounterNo, string AcHd, string TransDate)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();
            if (DepositWithdrow == "Withdrawal")
            {
                if (CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + TransDate + "', 'DD/MM/YYYY') ";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + "  AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + AcHd + "'";

                    if (AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW' AND COUNTER_NO <>'7' order by COUNTER_NO,TRN_NO";

                }
                else
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + TransDate + "', 'DD/MM/YYYY') ";//and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + AcHd + "'";

                    if (AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'";
                    else
                        qry = qry + " AND INSERT_MODE='MW'";
                    qry = qry + " AND COUNTER_NO='" + CounterNo + "' order by COUNTER_NO,TRN_NO";
                }
            }
            else
            {
                if (CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + " TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C' AND AC_HD='" + AcHd + "'";

                    if (AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD' order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MD' order by COUNTER_NO,TRN_NO";

                }

                else
                {

                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY') , 'DD/MM/YYYY')= TO_DATE('" + TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='C'";

                    if (AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD'AND AC_HD='" + AcHd + "'";

                    else
                        qry = qry + " AND INSERT_MODE='MD'AND AC_HD='" + AcHd + "'";

                    qry = qry + " AND COUNTER_NO=" + CounterNo + "order by COUNTER_NO,TRN_NO";
                }
            }

            lstTV = GetTotalDeposit(qry);


            return lstTV;

        }
        public List<TvchDetail> GetTotalByDate(CashDepositWthdrawViewModel model)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();
            if (model.DepositWithdrow == "Withdrawal")
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY') ";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + "  AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW' AND COUNTER_NO <>'7' order by COUNTER_NO,TRN_NO";

                }
                else
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY') ";//and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'";

                    else
                        qry = qry + " AND INSERT_MODE='MW'";



                    qry = qry + " AND COUNTER_NO='" + model.CounterNo + "' order by COUNTER_NO,TRN_NO";

                }
            }
            else
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + " TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C' AND AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD' order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MD' order by COUNTER_NO,TRN_NO";

                }

                else
                {

                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY') , 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='C'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD'AND AC_HD='" + model.AcHd + "'";

                    else
                        qry = qry + " AND INSERT_MODE='MD'AND AC_HD='" + model.AcHd + "'";

                    qry = qry + " AND COUNTER_NO=" + model.CounterNo + "order by COUNTER_NO,TRN_NO";
                }
            }

            lstTV = GetTotalDeposit(qry);


            return lstTV;

        }


        public List<TvchDetail> GetTotalByDateRange(CashDepositWthdrawViewModel model)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();
            if (model.DepositWithdrow == "Withdrawal")
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + "  AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW' AND COUNTER_NO <>'7' order by COUNTER_NO,TRN_NO";

                }
                else
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'";

                    else
                        qry = qry + " AND INSERT_MODE='MW'";



                    qry = qry + " AND COUNTER_NO='" + model.CounterNo + "' order by COUNTER_NO,TRN_NO";

                }
            }
            else
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C' AND AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD' order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MD' order by COUNTER_NO,TRN_NO";

                }

                else
                {

                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='C'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD'AND AC_HD='" + model.AcHd + "'";

                    else
                        qry = qry + " AND INSERT_MODE='MD'AND AC_HD='" + model.AcHd + "'";

                    qry = qry + " AND COUNTER_NO=" + model.CounterNo + "order by COUNTER_NO,TRN_NO";
                }
            }


            lstTV = GetTotalDeposit(qry);


            return lstTV;
        }


        public List<TvchDetail> GetTotalByDateRangeForScroll(CashDepositWthdrawViewModel model)
        {
            String qry;
            String qry1;
            List<TvchDetail> lst = new List<TvchDetail>();
            if (model.DepositWithdrow == "Withdrawal")
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + "  AND TRN_SHIFT='G' AND COUNTER_NO <> '15'  AND VCH_DRCR='D' AND TRN_NO <> '0' AND TRN_SRL <> '8'  AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'  order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MW'  order by COUNTER_NO,TRN_NO";
                }
                else
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND TRN_SHIFT='G' AND TRN_NO <> '0' AND TRN_SRL <> '8' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'";

                    else
                        qry = qry + " AND INSERT_MODE='MW'";



                    qry = qry + " AND COUNTER_NO='" + model.CounterNo + "' order by COUNTER_NO,TRN_NO";

                }
            }
            else
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C' AND COUNTER_NO <> '15' AND TRN_NO <> '0' AND TRN_SRL <> '8' AND AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD' order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MD' order by COUNTER_NO,TRN_NO";

                }

                else
                {

                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='C' AND TRN_NO <> '0' AND TRN_SRL <> '8' ";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD'AND AC_HD='" + model.AcHd + "'";

                    else
                        qry = qry + " AND INSERT_MODE='MD'AND AC_HD='" + model.AcHd + "'";

                    qry = qry + " AND COUNTER_NO=" + model.CounterNo + "order by COUNTER_NO,TRN_NO";
                }
            }


            config.Load_DTG(qry);

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
                    dls.insert_mode = dr["insert_mode"].ToString();
                    dls.vch_drcr = dr["vch_drcr"].ToString();
                    dls.ac_hd = dr["ac_hd"].ToString();

                    DataRow dr1;
                    if (dr["ac_hd"].ToString() == "STL")
                    {

                        qry1 = "SELECT * FROM SLOAN_PAYMENT_MODE WHERE TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY')  AND LOAN_ID = '" + dls.vch_pacno + "' ORDER BY LOAN_ID";
                        config.Load_DTG(qry1);
                        if (config.dt.Rows.Count > 0)
                        {
                            dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                            dls.listno = "STL/" + dr1["LIST_NO"].ToString() + "/" + (Convert.ToDateTime(dr1["LDATE"])).Year.ToString().Substring(4 - 2);

                        }
                    }
                    else if (dr["ac_hd"].ToString() == "LTL")
                    {
                        qry1 = "SELECT * FROM LOAN_PAYMENT_MODE WHERE TO_DATE(TO_CHAR(LDATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') AND TO_DATE(TO_CHAR(LDATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<= TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') AND LOAN_ID='" + dls.vch_pacno + "' ORDER BY LOAN_ID";
                        config.Load_DTG(qry1);
                        if (config.dt.Rows.Count > 0)
                        {
                            dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                            dls.listno = "LTL/" + dr1["LIST_NO"].ToString() + "/" + (Convert.ToDateTime(dr1["LDATE"])).Year.ToString().Substring(4 - 2);

                        }
                    }
                    else
                        dls.listno = string.Empty;

                    lst.Add(dls);

                }


            }
            return lst;
        }

        public List<TvchDetail> GetTotalAllDateRange(CashDepositWthdrawViewModel model)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();

            qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

            qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + model.FromDate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + model.ToDate + "', 'DD/MM/YYYY') ";

            qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C'";


            qry = qry + " AND (INSERT_MODE='CD' OR INSERT_MODE='MD') order by COUNTER_NO,TRN_NO";




            lstTV = GetTotalDeposit(qry);


            return lstTV;
        }


        public List<TvchDetail> GetAllDistinctAcHd(String fromdate, string todate)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();

            qry = "SELECT distinct ac_hd, vch_drcr FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

            qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')>= TO_DATE('" + fromdate + "', 'DD/MM/YYYY') and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<=TO_DATE('" + todate + "', 'DD/MM/YYYY') Order By ac_hd ";

            config.Load_DTG(qry);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    TvchDetail dls = new TvchDetail();
                    dls.vch_drcr = dr["vch_drcr"].ToString();
                    dls.ac_hd = dr["ac_hd"].ToString();
                    lstTV.Add(dls);
                }
            }

            return lstTV;
        }
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
                    dls.insert_mode = dr["insert_mode"].ToString();
                    dls.vch_drcr = dr["vch_drcr"].ToString();
                    dls.ac_hd = dr["ac_hd"].ToString();
                    lst.Add(dls);
                }


            }
            return lst;
        }
    }
}
