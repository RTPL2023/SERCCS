using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace SERCCS.Models.Database
{
    public class TvchDetail
    {

        DBConfig config = new DBConfig();

        String sql;

        public string branch_id { get; set; }
        public DateTime trn_date { get; set; }
        public string trn_shift { get; set; }
        public Int32 counter_no { get; set; }
        public string trn_no { get; set; }
        public Int32 trn_srl { get; set; }
        public string token_no { get; set; }
        public string vch_drcr { get; set; }
        public string ac_hd { get; set; }
        public string vch_pacno { get; set; }
        public string vch_acname { get; set; }
        public Decimal vch_amt { get; set; }
        public string is_self { get; set; }
        public string is_chq { get; set; }
        public string chq_no { get; set; }
        public DateTime chq_date { get; set; }
        public string bankcd { get; set; }
        public string chq_mode { get; set; }
        public string bearer_branch { get; set; }
        public string ref_ac_hd { get; set; }
        public string ref_pacno { get; set; }
        public string ref_oth { get; set; }
        public string insert_mode { get; set; }
        public string conf_flag { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }

        public string listno { get; set; }

        public int ValidateData(string ac_hd, string ac_no, string counter, string date, string pono, string vch_drcr)
        {
            int i = 0;
            string sql;
            if (vch_drcr == "D")
            {
                sql = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND AC_HD='" + ac_hd + "' AND VCH_PACNO='" + ac_no + "' AND COUNTER_NO='" + counter + "' AND TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" + date + "' AND TRN_NO='" + pono + "' AND VCH_DRCR='D'";
            }
            else
            {
                sql = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND AC_HD='" + ac_hd + "' AND VCH_PACNO='" + ac_no + "' AND COUNTER_NO='" + counter + "' AND TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" + date + "' AND TRN_NO='" + pono + "' AND VCH_DRCR='C'";
            }

            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                i = 1;
            }
            return i;
        }
        public TvchDetail getTvchDetailWithdrowAll(string achd, String trndate)
        {
            string sql = "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" + trndate + "' AND AC_HD='" + achd + "' AND VCH_DRCR='D' ORDER BY TRN_DATE, TRN_NO, TRN_SRL";


            config.singleResult(sql);
            TvchDetail tv = new TvchDetail();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                tv.trn_no = dr["trn_no"].ToString();//.Substring(dr["trn_no"].ToString().Length, -4);

            }
            else
            {
                tv = null;
            }
            return tv;
        }
        public List<TvchDetail> GetAchdFromTvchDetail(string TrnDate, string counter_no, string DrCr)
        {
            string sql;
            if (counter_no == "ALL")
            {
                sql = "SELECT AC_HD FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND TO_CHAR(TRN_DATE, 'DD/MM/YYYY')='" + TrnDate + "' AND VCH_DRCR='" + DrCr + "' GROUP BY AC_HD";
            }
            else
            {
                sql = "SELECT AC_HD FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND TO_CHAR(TRN_DATE, 'DD/MM/YYYY')='" + TrnDate + "' AND COUNTER_NO='" + counter_no + "' AND VCH_DRCR='" + DrCr + "' GROUP BY AC_HD";
            }

            List<TvchDetail> tdlist = new List<TvchDetail>();
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    TvchDetail td = new TvchDetail();

                    td.ac_hd = dr["ac_hd"].ToString();

                    tdlist.Add(td);

                }
            }
            return tdlist;
        }

        public TvchDetail Gettvchadetails(string date, string counter, string ac_hd, string ac_no, string voucher_no, string drcr)
        {
            string sql;
            TvchDetail tv = new TvchDetail();
            if (drcr == "D")
                sql = "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" + date.Replace("-", "/") + "' AND COUNTER_NO='" + counter + "'  AND AC_HD='" + ac_hd + "'  AND VCH_PACNO='" + ac_no + "' AND VCH_DRCR='D' AND TRN_NO='" + voucher_no + "' ORDER BY TRN_NO ";
            else
                sql = "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" + date.Replace("-", "/") + "' AND COUNTER_NO='" + counter + "'  AND AC_HD='" + ac_hd + "'  AND VCH_PACNO='" + ac_no + "' AND VCH_DRCR='C' AND TRN_NO='" + voucher_no + "' ORDER BY TRN_NO ";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {


                    tv.vch_amt = !Convert.IsDBNull(dr["vch_amt"]) ? Convert.ToDecimal(dr["vch_amt"]) : Convert.ToDecimal("00");
                }
            }
            else
            {
                tv = null;
            }
            return tv;
        }
        public TvchDetail getTvchDetailWithdrowCounter(string achd, String trndate, string counterno)
        {
            string sql = "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD-MM-YYYY')= '" + trndate + "' AND AC_HD='" + achd + "' AND COUNTER_NO='" + counterno + "' AND VCH_DRCR='D' ORDER BY TRN_DATE, TRN_NO, TRN_SRL";
            // "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD/MM/YYYY')= '" & Me.DTPicker1 & "' AND AC_HD='" & Me.Combo1.Text & "' AND COUNTER_NO='" & Me.Combo2.Text & "' AND VCH_DRCR='D' ORDER BY TRN_DATE, TRN_NO, TRN_SRL"


            config.singleResult(sql);
            TvchDetail tv = new TvchDetail();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                tv.trn_no = dr["trn_no"].ToString();//.Substring(dr["trn_no"].ToString().Length, -4);

            }
            else
            {
                tv = null;
            }
            return tv;
        }

        public TvchDetail getTvchDetailDepositCounter(string achd, String trndate, string counterno)
        {
            string sql = "SELECT * FROM TVCH_DETAIL WHERE TO_CHAR(TRN_DATE, 'DD-MM-YYYY')= '" + trndate + "' AND AC_HD='" + achd + "' AND COUNTER_NO='" + counterno + "' AND VCH_DRCR='C' ORDER BY TRN_DATE, TRN_NO, TRN_SRL";


            config.singleResult(sql);
            TvchDetail tv = new TvchDetail();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                tv.trn_no = dr["trn_no"].ToString();//.Substring(dr["trn_no"].ToString().Length, -4);

            }
            else
            {
                tv = null;
            }
            return tv;
        }

        public void SaveVoucher(TvchDetail tv)
        {

            config.Insert("TVCH_DETAIL", new Dictionary<string, object>()
            {
                { "branch_id", tv.branch_id },
                { "trn_date", tv.trn_date },
                { "trn_shift", tv.trn_shift },
                { "counter_no", tv.counter_no  },
                { "trn_no",  tv.trn_no },
                { "trn_srl", tv.trn_srl },
                { "token_no", tv.token_no },
                { "vch_drcr", tv.vch_drcr },
                { "ac_hd", tv.ac_hd },
                { "vch_pacno", tv.vch_pacno },
                { "vch_acname", tv.vch_acname },
                { "vch_amt", tv.vch_amt },
                { "is_self", tv.is_self },
                { "is_chq", tv.is_chq  },
                { "chq_no",  tv.chq_no },
                //{ "chq_date", tv.chq_date },
                { "bankcd", tv.bankcd },
                { "chq_mode", tv.chq_mode },
                { "bearer_branch", tv.bearer_branch },
                { "ref_ac_hd",tv.ref_ac_hd },
                { "ref_pacno", tv.ref_pacno },
                { "ref_oth",tv.ref_oth },
                { "insert_mode",tv.insert_mode },
                { "conf_flag",tv.conf_flag },
                { "created_by",tv.created_by},
                { "created_on",tv.created_on },
                { "computer_name",tv.computer_name },
                //{ "modified_by",tv.modified_by },
                //{ "modified_on",tv.modified_on },
                //{ "mcomputer_name",tv.mcomputer_name }


            });

        }


        public List<DepositTransfer> getTvchDetailByDate(string trndate)
        {
            // List<TvchDetail> tdl = new List<TvchDetail>();
            List<DepositTransfer> tdl = new List<DepositTransfer>();
            string sql = @"SELECT * FROM  TVCH_DETAIL tv WHERE AC_HD='SB' AND TO_CHAR(TRN_DATE, 'dd-MM-yyyy')='" + trndate + "' " +
                " and VCH_PACNO NOT IN (select AC_NO FROM DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO=tv.VCH_PACNO  AND TO_CHAR(VCH_DATE, 'DD/MM/YYYY') ='" + trndate + "' AND VCH_NO=tv.TRN_NO ) ORDER BY VCH_PACNO";

            config.Load_DTG(sql);
            //  TvchDetail td = new TvchDetail();
            DepositTransfer td = new DepositTransfer();
            if (config.dt.Rows.Count > 0)
            {

                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositTransfer dlt = new DepositTransfer();
                    dlt.dr_cr = dr["vch_drcr"].ToString();

                    dlt.print_amount = dr["vch_amt"].ToString();
                    dlt.vch_no = dr["trn_no"].ToString();
                    dlt.vch_date = dr["trn_date"].ToString();
                    dlt.ac_no = dr["vch_pacno"].ToString();
                    dlt.vch_acname = dr["vch_acname"].ToString();
                    //  dlt.computer_name = Environment.MachineName.ToString();
                    tdl.Add(dlt);

                }
                //foreach (DataRow dr in config.dt.Rows)
                //{
                //    td.vch_pacno = dr["vch_pacno"].ToString();
                //    //dlt.ac_no = dr["ac_no"].ToString();
                //    td.vch_amt = dr["vch_amt"].ToString();
                //    td.vch_drcr = dr["vch_drcr"].ToString();
                //    td.trn_no = dr["trn_no"].ToString();
                //    td.vch_acname = dr["vch_acname"].ToString();
                //    td.trn_date = dr["trn_date"].ToString();
                //    tdl.Add(td);
                //}

            }
            return tdl;
        }


        public void updateLossTvchDetailByDate(string trndate)
        {
            // List<TvchDetail> tdl = new List<TvchDetail>();
            List<DepositTransfer> tdl = new List<DepositTransfer>();
            string sql = @"SELECT * FROM  TVCH_DETAIL tv WHERE AC_HD='SB' AND TO_CHAR(TRN_DATE, 'dd-MM-yyyy')='" + trndate + "' " +
                " and VCH_PACNO NOT IN (select AC_NO FROM DEPOSIT_LEDGER_SB WHERE BRANCH WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO=' tv.VCH_PACNO  AND TO_CHAR(VCH_DATE, 'DD/MM/YYYY') ='" + trndate + "' AND VCH_NO=tv.TRN_NO ) ORDER BY VCH_PACNO";

            config.Load_DTG(sql);
            int i = 0;
            if (config.dt.Rows.Count > 0)
            {

                i++;

                config.con.Open();

                string[] BRANCH_IDs = new string[config.dt.Rows.Count];
                string[] ac_hds = new string[config.dt.Rows.Count];
                string[] ac_nos = new string[config.dt.Rows.Count];
                int[] vch_srls = new int[config.dt.Rows.Count];
                string[] VCH_TYPEs = new string[config.dt.Rows.Count];
                string[] DR_CRs = new string[config.dt.Rows.Count];

                decimal[] PRIN_AMOUNTs = new decimal[config.dt.Rows.Count];
                decimal[] prin_bals = new decimal[config.dt.Rows.Count];
                string[] INSERT_MODEs = new string[config.dt.Rows.Count];

                for (int j = 0; j < config.dt.Rows.Count; j++)
                {
                    BRANCH_IDs[j] = config.dt.Rows[j]["BRANCH_ID"].ToString();
                    ac_hds[j] = Convert.ToString(config.dt.Rows[j]["ac_hd"]);
                    ac_nos[j] = Convert.ToString(config.dt.Rows[j]["ac_no"]);

                    vch_srls[j] = Convert.ToInt32(config.dt.Rows[j]["vch_srl"]);
                    VCH_TYPEs[j] = Convert.ToString(config.dt.Rows[j]["VCH_TYPE"]);
                    DR_CRs[j] = Convert.ToString(config.dt.Rows[j]["DR_CR"]);

                    PRIN_AMOUNTs[j] = Convert.ToDecimal(config.dt.Rows[j]["PRIN_AMOUNT"]);
                    prin_bals[j] = Convert.ToDecimal(config.dt.Rows[j]["prin_bal"]);
                    if (DR_CRs[j] == "D")
                        INSERT_MODEs[j] = "CW";
                    else
                        INSERT_MODEs[j] = "CD";

                }



                OracleParameter BRANCH_ID = new OracleParameter();
                BRANCH_ID.OracleDbType = OracleDbType.Varchar2;
                BRANCH_ID.Value = BRANCH_IDs;

                OracleParameter ac_hd = new OracleParameter();
                ac_hd.OracleDbType = OracleDbType.Varchar2;
                ac_hd.Value = ac_hds;

                OracleParameter ac_no = new OracleParameter();
                ac_no.OracleDbType = OracleDbType.Varchar2;
                ac_no.Value = ac_nos;

                OracleParameter vch_srl = new OracleParameter();
                vch_srl.OracleDbType = OracleDbType.Int32;
                vch_srl.Value = vch_srls;

                OracleParameter VCH_TYPE = new OracleParameter();
                VCH_TYPE.OracleDbType = OracleDbType.Varchar2;
                VCH_TYPE.Value = VCH_TYPEs;

                OracleParameter DR_CR = new OracleParameter();
                DR_CR.OracleDbType = OracleDbType.Varchar2;
                DR_CR.Value = DR_CRs;

                OracleParameter PRIN_AMOUNT = new OracleParameter();
                PRIN_AMOUNT.OracleDbType = OracleDbType.Decimal;
                PRIN_AMOUNT.Value = PRIN_AMOUNTs;

                OracleParameter prin_bal = new OracleParameter();
                prin_bal.OracleDbType = OracleDbType.Decimal;
                prin_bal.Value = prin_bals;

                OracleParameter INSERT_MODE = new OracleParameter();
                INSERT_MODE.OracleDbType = OracleDbType.Varchar2;
                INSERT_MODE.Value = INSERT_MODEs;


                // create command and set properties
                OracleCommand cmd = config.con.CreateCommand();
                cmd.CommandText = "INSERT INTO DEPOSIT_LEDGER_SB (BRANCH_ID, ac_hd, ac_no) VALUES (:1, :2, :3)";
                cmd.ArrayBindCount = BRANCH_IDs.Length;
                cmd.Parameters.Add(BRANCH_ID);
                cmd.Parameters.Add(ac_hd);
                cmd.Parameters.Add(ac_no);
                cmd.ExecuteNonQuery();


            }
        }

    }

}