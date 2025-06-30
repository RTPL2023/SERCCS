using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class Ledger
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public String vch_type { get; set; }
        public String vch_achd { get; set; }
        public String dr_cr { get; set; }
        public String contno { get; set; }
        public String chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public String bankcd { get; set; }
        public String chq_oprmode { get; set; }
        public decimal prin_amount { get; set; }
        public decimal int_amount { get; set; }
        public decimal prin_bal { get; set; }
        public decimal int_bal { get; set; }
        public String chq_bearer { get; set; }
        public String ref_ac_hd { get; set; }
        public String ref_pacno { get; set; }
        public String ref_oth { get; set; }
        public String insert_mode { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }

        public String mcomputer_name { get; set; }
        public String pan_number { get; set; }


         public double tr_amount { get; set; }
         public decimal tran_amount { get; set; }

        public string member_id { get; set; }

        public Int64 units { get; set; }
        public decimal face_val { get; set; }
      
        public string certificate_no { get; set; }
        public DateTime certificate_date { get; set; }
        public string cert_prnt_flag { get; set; }
        public Int64 dist_no_from { get; set; }
        public Int64 dist_no_to { get; set; }
     
        public string dup_cert { get; set; }

       //LOAN++++++++++++++++++++++++++++++
        public string loan_id { get; set; }
        public Decimal loan_amt { get; set; }



        public DateTime chq_date { get; set; }
      
        public Decimal aint_amount { get; set; }
        public Decimal ichrg_amount { get; set; }
     
        public Decimal int_due { get; set; }
        public Decimal int_due_actual { get; set; }
        public Decimal aint_due { get; set; }
        public Decimal ichrg_due { get; set; }
        public Decimal rebate_allowed { get; set; }
       
        public string approval_flag { get; set; }
        public string approved_by { get; set; }
        public Int64 no { get; set; }
        public string pro { get; set; }
        public decimal bal_amount { get; set; }
        public string query { get; set; }
        public string table { get; set; }



        public void SaveLedger(Ledger dlt, String tablename)
        {
            if (tablename == "SHARE_LEDGER")
            {
                config.Insert(tablename, new Dictionary<string, object>()
            {

                { "branch_id", dlt.branch_id },
                { "member_id",dlt.member_id },
                { "vch_date", dlt.vch_date },
                { "vch_no",  dlt.vch_no  },

                { "vch_srl", dlt.vch_srl },
                { "vch_type", dlt.vch_type },
                { "vch_achd", dlt.vch_achd },
                { "dr_cr", dlt.dr_cr },
                { "chq_no", dlt.chq_no },
               // { "chq_dt",  dlt.chq_dt },
                { "bankcd",  dlt.bankcd },
                { "tr_amount",  dlt.tr_amount },
                { "bal_amount",  dlt.bal_amount },
                { "Units", dlt.units },
                { "face_val",  dlt.face_val },
                { "ref_ac_hd", dlt.ref_ac_hd },
                { "ref_pacno",  dlt.ref_pacno },
                { "ref_oth", dlt.ref_oth },
                { "certificate_no", dlt.certificate_no },
                //{ "certificate_date", dlt.certificate_date },
                { "cert_prnt_flag", dlt.cert_prnt_flag },
                { "dist_no_from", dlt.dist_no_from },
                { "dist_no_to", dlt.dist_no_to },
                { "insert_mode", dlt.insert_mode },
                { "dup_cert", dlt.dup_cert },
                { "created_by",dlt.created_by},
                { "created_on", dlt.created_on },
                { "computer_name",dlt.computer_name },
                //{ "modified_by",dlt.modified_by  },
                //{ "modified_on",dlt.modified_on },
                //{ "mcomputer_name",dlt.mcomputer_name },
                
                

                });
            }
            else if (tablename == "CMTD_LEDGER")
            {
                config.Insert(tablename, new Dictionary<string, object>()
            {

                { "branch_id", dlt.branch_id },
                { "member_id", dlt.member_id },
                { "vch_date",  dlt.vch_date  },
                { "vch_no",   dlt.vch_no },
                { "vch_srl", dlt.vch_srl },
                { "vch_type", dlt.vch_type },
                { "vch_achd", dlt.vch_achd },
                { "dr_cr", dlt.dr_cr },
                { "prin_amount",  dlt.prin_amount },
                { "int_amount",  dlt.int_amount },
                { "prin_bal",  dlt.prin_bal },
                { "int_bal", dlt.int_bal },
                { "ref_ac_hd", dlt.ref_ac_hd },
                { "ref_pacno",  dlt.ref_pacno },
                { "ref_oth", dlt.ref_oth },
                { "insert_mode",dlt.insert_mode },
                { "created_by",dlt.created_by},
                { "created_on", dlt.created_on },
                { "computer_name",dlt.computer_name },
                //{ "modified_by",dlt.modified_by  },
                //{ "modified_on",dlt.modified_on },
                //{ "mcomputer_name",dlt.mcomputer_name },
                
            });
            }
            else
            {
                config.Insert(tablename, new Dictionary<string, object>()
            {

                { "branch_id", dlt.branch_id },
                { "ac_hd",dlt.ac_hd },
                { "ac_no", dlt.ac_no },
                { "vch_date",  dlt.vch_date  },
                { "vch_no",   dlt.vch_no },
                { "vch_srl", dlt.vch_srl },
                { "vch_type", dlt.vch_type },
                { "vch_achd", dlt.vch_achd },
                { "dr_cr", dlt.dr_cr },
                { "contno", dlt.contno },
                { "chq_no", dlt.chq_no },
                //{ "chq_dt",  dlt.chq_dt },
                { "bankcd",  dlt.bankcd },
                { "chq_oprmode",dlt.chq_oprmode  },
                { "prin_amount",  dlt.prin_amount },
                { "int_amount",  dlt.int_amount },
                { "prin_bal",  dlt.prin_bal },
                { "int_bal", dlt.int_bal },
                { "chq_bearer",  dlt.chq_bearer },
                { "ref_ac_hd", dlt.ref_ac_hd },
                { "ref_pacno",  dlt.ref_pacno },
                { "ref_oth", dlt.ref_oth },
                { "insert_mode",dlt.insert_mode },
                { "created_by",dlt.created_by},
                { "created_on", dlt.created_on },
                { "computer_name",dlt.computer_name },
                //{ "modified_by",dlt.modified_by  },
                //{ "modified_on",dlt.modified_on },
                //{ "mcomputer_name",dlt.mcomputer_name },
                { "pan_number",dlt.pan_number}

            });
            }







        }

        public Ledger getLedgerDetail(string branchid, string acno, string achd, String conno)
        {

            Ledger dm = new Ledger();
            if (achd != "LFC" && achd != "MISC")
            {


                string sql = String.Empty;
                if (achd == "SB")
                    sql = "select * from DEPOSIT_LEDGER_SB WHERE BRANCH_ID='" + branchid + "' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                //sql = "select * from DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "FD")
                    sql = "select * from DEPOSIT_LEDGER_FD WHERE BRANCH_ID='" + branchid + "' AND AC_HD='FD' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "CMTD")
                    sql = "select * from CMTD_LEDGER  WHERE BRANCH_ID='" + branchid + "'  AND MEMBER_ID='" + conno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "DIV")
                    sql = "select * from DIVIDEND_LEDGER  WHERE BRANCH_ID='" + branchid + "'  AND MEMBER_ID='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "SH")
                    sql = "select * from SHARE_LEDGER   WHERE BRANCH_ID='" + branchid + "'  AND MEMBER_ID='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "LTL")
                    sql = "select * from Loan_ledger_ltl   WHERE BRANCH_ID='" + branchid + "'  AND loan_id='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "STL")
                    sql = "select * from SHARE_LEDGER   WHERE BRANCH_ID='" + branchid + "'  AND loan_id='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";
                else if (achd == "FES")
                    sql = "select * from SHARE_LEDGER   WHERE BRANCH_ID='" + branchid + "'  AND loan_id='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";






                config.singleResult(sql);

                if (config.dt.Rows.Count > 0)
                {
                    DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                    if (achd == "SB") dm.prin_bal = Convert.ToDecimal(dr["prin_bal"]);
                    else if (achd == "SH") dm.bal_amount = Convert.ToDecimal(dr["bal_amount"]);
                    else if (achd == "CMTD") dm.prin_bal = Convert.ToDecimal(dr["prin_bal"]);




                }
                else
                {
                    dm = null;
                }
            }
            else
            {
                dm = null;
            }
            return dm;
        }

        public Ledger getLedgerDetailForHolidayhome(string acno, string achd)
        {

            Ledger dm = new Ledger();


            string sql = String.Empty;

            sql = "select * from DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID='MN' AND AC_HD='" + achd + "' AND AC_NO='" + acno + "' ORDER BY VCH_DATE, VCH_NO,VCH_SRL";

            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                dm.prin_bal = Convert.ToDecimal(dr["prin_bal"]);
            }
            else
            {

                dm.prin_bal = 0;

            }


            return dm;
        }
        public void SaveDepositLedgerTemp(Ledger dlt)
        {

            config.Insert("DEPOSIT_LEDGER_SB", new Dictionary<string, object>()
            {
                { "branch_id", dlt.branch_id },
                { "ac_hd",dlt.ac_hd },
                { "ac_no", dlt.ac_no },
                { "vch_date",  dlt.vch_date  },
                { "vch_no",   dlt.vch_no },
                { "vch_srl", dlt.vch_srl },
                { "vch_type", dlt.vch_type },
                { "vch_achd", dlt.vch_achd },
                { "dr_cr", dlt.dr_cr },
                { "contno", dlt.contno },
                { "chq_no", dlt.chq_no },
                //{ "chq_dt",  dlt.chq_dt },
                { "bankcd",  dlt.bankcd },
                { "chq_oprmode",dlt.chq_oprmode  },
                { "prin_amount",  dlt.prin_amount },
                { "int_amount",  dlt.int_amount },
                { "prin_bal",  dlt.prin_bal },
                { "int_bal", dlt.int_bal },
                { "chq_bearer",  dlt.chq_bearer },
                { "ref_ac_hd", dlt.ref_ac_hd },
                { "ref_pacno",  dlt.ref_pacno },
                { "ref_oth", dlt.ref_oth },
                { "insert_mode",dlt.insert_mode },
                { "created_by",dlt.created_by},
                { "created_on", dlt.created_on },
                { "computer_name",dlt.computer_name },
                { "pan_number",dlt.pan_number}

            });





        }


        public void SaveDepositLedgerSB(Ledger ledset)
        {

            try
            {
                config.Insert("Deposit_Ledger_SB", new Dictionary<string, object>()
                {
                { "branch_id", ledset.branch_id },
                { "ac_hd",ledset.ac_hd },
                { "ac_no", ledset.ac_no },
                { "vch_date",  ledset.vch_date  },
                { "vch_no",   ledset.vch_no },
                { "vch_srl", ledset.vch_srl },
                { "vch_type", ledset.vch_type },
                { "vch_achd", ledset.vch_achd },
                { "dr_cr", ledset.dr_cr },
                { "contno", ledset.contno },
                { "chq_no", ledset.chq_no },
                { "bankcd",  ledset.bankcd },
                { "chq_oprmode",ledset.chq_oprmode  },
                { "prin_amount",  ledset.prin_amount },
                { "int_amount",  ledset.int_amount },
                { "prin_bal",  ledset.prin_bal },
                { "int_bal", ledset.int_bal },
                { "chq_bearer",  ledset.chq_bearer },
                { "ref_ac_hd", ledset.ref_ac_hd },
                { "ref_pacno",  ledset.ref_pacno },
                { "ref_oth", ledset.ref_oth },
                { "insert_mode",ledset.insert_mode },
                { "created_by",ledset.created_by},
                { "created_on", ledset.created_on },
                { "computer_name",ledset.computer_name },
                { "pan_number",ledset.pan_number}

            });
                string sql = "";

                sql = "DELETE FROM DEPOSIT_LEDGER_TEMP WHERE BRANCH_ID='MN' AND AC_HD='SB' AND TO_CHAR(VCH_DATE, 'DD/MM/YYYY')='" + ledset.vch_date.ToString("dd/MM/yyyy").Replace("-", "/") + "'";
                sql = sql + " AND vch_no='" + ledset.vch_no + "' And dr_cr='" + ledset.dr_cr + "' and ac_no='" + ledset.ac_no + "'";
                config.Execute_Query(sql);

                string date = ledset.vch_date.ToString("dd/MM/yyyy").Replace("-", "/");
                decimal lbal_prin = 0;
                decimal lbal_int = 0;
                sql = "SELECT * FROM DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + ledset.ac_no + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')< to_date('" + date + "','dd/mm/yyyy') ORDER BY VCH_DATE";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    DataRow dr6 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                    lbal_prin = !Convert.IsDBNull(dr6["prin_bal"]) ? Convert.ToDecimal(dr6["prin_bal"]) : Convert.ToDecimal(00);
                    lbal_int = !Convert.IsDBNull(dr6["int_bal"]) ? Convert.ToDecimal(dr6["int_bal"]) : Convert.ToDecimal(00);
                }
                sql = "SELECT * FROM DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' AND AC_HD='SB' AND AC_NO='" + ledset.ac_no + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')>= to_date('" + date + "','dd/mm/yyyy') ORDER BY VCH_DATE";
                config.singleResult(sql);

                if (config.dt.Rows.Count > 0)
                {
                    Ledger ld = new Ledger();
                    foreach (DataRow dr5 in config.dt.Rows)
                    {
                        ld.dr_cr = Convert.ToString(dr5["dr_cr"]);
                        if (ld.dr_cr == "D")
                        {
                            lbal_prin = lbal_prin - Convert.ToDecimal(dr5["prin_amount"]);
                            lbal_int = lbal_int + (!Convert.IsDBNull(dr5["INT_AMOUNT"]) ? Convert.ToDecimal(dr5["INT_AMOUNT"]) : Convert.ToDecimal(00));
                        }
                        else
                        {
                            lbal_prin = lbal_prin + Convert.ToDecimal(dr5["prin_amount"]);
                            lbal_int = lbal_int - (!Convert.IsDBNull(dr5["INT_AMOUNT"]) ? Convert.ToDecimal(dr5["INT_AMOUNT"]) : Convert.ToDecimal(00));
                        }

                        string VOUCHER_DATE = ((Convert.ToDateTime(dr5["vch_date"])).ToShortDateString()).Replace("-", "/");
                        ld.vch_no = Convert.ToString(dr5["vch_no"]);
                        ld.vch_srl = Convert.ToInt32(dr5["vch_srl"]);

                        string qry = "Update DEPOSIT_LEDGER_SB set prin_bal=" + lbal_prin + ",int_bal=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' AND AC_NO='" + ledset.ac_no + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                        config.Execute_Query(qry);




                    }

                }
            }
            catch
            {

            }



        }
        public void SaveCmtdLedger(Ledger ledset)
        {
            config.Insert("Cmtd_Ledger", new Dictionary<string, object>()
                {
                { "branch_id", ledset.branch_id },
                { "vch_date",  ledset.vch_date  },
                { "vch_no",   ledset.vch_no },
                { "vch_srl", ledset.vch_srl },
                { "vch_type", ledset.vch_type },
                { "vch_achd", ledset.vch_achd },
                { "dr_cr", ledset.dr_cr },
                { "Member_id", ledset.member_id },
                { "prin_amount",  ledset.prin_amount },
                { "int_amount",  ledset.int_amount },
                { "prin_bal",  ledset.prin_bal },
                { "insert_mode",ledset.insert_mode },
                { "created_by",ledset.created_by},
                { "created_on", ledset.created_on },
                { "computer_name",ledset.computer_name },


            });
        }
        public void UpdateDepositLedgerSB(Ledger ledset)
        {
            config.Update("Deposit_Ledger_SB", new Dictionary<string, object>()
                {
                  { "prin_bal", ledset.prin_bal },
                  { "modified_by",ledset.modified_by  },
                  { "modified_on",ledset.modified_on },
                  { "mcomputer_name",ledset.mcomputer_name }

                }, new Dictionary<string, object>()
                {
                              { "vch_date", ledset.vch_date },
                              { "vch_no",   ledset.vch_no }
                });


        }
        public void UpdateCmtdLedger(Ledger ledset)
        {
            config.Update("CMTD_Ledger", new Dictionary<string, object>()
                {
                  { "prin_bal",  ledset.prin_bal },
                  { "modified_by",ledset.modified_by  },
                  { "modified_on",ledset.modified_on },
                  { "mcomputer_name",ledset.mcomputer_name }

                }, new Dictionary<string, object>()
                {
                              { "vch_date", ledset.vch_date },
                              { "vch_no",   ledset.vch_no }
                });


        }
        public void DeleteDepositLedgerSB(string ac_no, DateTime vchdate, string insertmode)
        {
            int r = 0;
            String sql;
            sql = "DELETE FROM DEPOSIT_LEDGER_SB WHERE BRANCH_ID='MN' and ac_no='" + ac_no + "' AND AC_HD='SB' AND INSERT_MODE='SI' AND TO_CHAR(VCH_DATE, 'DD/MM/YYYY')='" + vchdate.ToString("dd-MM-yyyy").Replace("-", "/") + "'";
            config.Execute_Query(sql);
            // return r;
        }
        public void DeleteCmtdLedger(string member_id, DateTime vchdate)
        {
            int r = 0;
            String sql;
            sql = "DELETE FROM Cmtd_LEDGER WHERE BRANCH_ID='MN' AND member_id='" + member_id + "' and INSERT_MODE='IN' AND TO_CHAR(VCH_DATE,'DD/MM/YYYY')='" + vchdate.ToString("dd-MM-yyyy").Replace("-", "/") + "'";
            config.Execute_Query(sql);
            // return r;
        }
        public Ledger GET_GEN_LEDGER(string XACHD, string xacno, string vch_date, int vch_srl)
        {
            int i = 0;
            Ledger ld = new Ledger();

            string sql = "select * from ACC_HEAD WHERE AC_HD='" + XACHD + "'";
            config.singleResult(sql);
            AccHead ah = new AccHead();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    //AccHead ah = new AccHead();
                    ah.ledger_tab = Convert.ToString(dr["ledger_tab"]);
                    ah.led_achd = Convert.ToString(dr["led_achd"]);

                    ah.ifcharge = Convert.ToString(dr["ifcharge"]);
                    ld.table = ah.ledger_tab;
                    if (ah.ledger_tab == "")
                    {
                        ld.query = "";
                    }
                    if (ah.ifcharge != "")
                    {
                        sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND to_char(VCH_DATE,'dd/mm/yyyy')='" + vch_date.Replace("-", "/") + "'";
                    }
                    else
                    {
                        if (xacno == "")
                        {
                            ld.query = "";
                            return ld;
                        }
                        if (ah.ledger_tab == "DEPOSIT_LEDGER_SB")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "DEPOSIT_LEDGER_FD")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "SHARE_LEDGER" || ah.ledger_tab == "CMTD_LEDGER" || ah.ledger_tab == "GF_LEDGER" || ah.ledger_tab == "TF_LEDGER" || ah.ledger_tab == "DIVIDEND_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND MEMBER_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "LOAN_LEDGER_CON")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "LOAN_LEDGER_FES")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "LOAN_LEDGER_LTL")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "LOAN_LEDGER_STL")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "LOCKER_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND LOCKER_AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "INVEST_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "DD_AGENT_SEC_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND DD_AGENT_CODE='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                        else if (ah.ledger_tab == "SUSPENSE_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";

                        }
                    }

                }


            }
            else
            {
                ld.query = "";
            }
            ld.query = sql;

            return ld;
        }


        public void Delete_LEDGER(string XACHD, string xacno, string vch_date, int vch_srl, string query, string table, string txtvch_No)
        {
            string voucher_date = vch_date.Replace("-", "/");
            Ledger ld = new Ledger();
            config.singleResult(query);
            if (config.dt.Rows.Count > 0)
            {
                if (table == "DEPOSIT_LEDGER_SB" || table == "DEPOSIT_LEDGER_FD")
                {

                    string sql = "Delete  FROM " + table + " WHERE branch_id = 'MN' AND  AC_NO = '" + xacno + "' AND to_char(VCH_DATE,'dd/mm/yyyy')='" + voucher_date + "' AND VCH_NO='" + txtvch_No + "' AND VCH_SRL=" + vch_srl + "";
                    config.Execute_Query(sql);

                }

                if (table == "GF_LEDGER" || table == "TF_LEDGER" || table == "SHARE_LEDGER" || table == "CMTD_LEDGER" || table == "DIVIDEND_LEDGER")
                {

                    string sql = "Delete from" + table + " WHERE branch_id='MN' AND MEMBER_ID='" + xacno + "' AND to_char(VCH_DATE,'dd/mm/yyyy')='" + voucher_date + "' AND VCH_NO='" + txtvch_No + "' AND VCH_SRL= " + vch_srl + "";
                    config.Execute_Query(sql);

                }
                if (table == "LOAN_LEDGER_CON" || table == "LOAN_LEDGER_FES" || table == "LOAN_LEDGER_STL" || table == "LOAN_LEDGER_LTL")
                {

                    string sql = "Delete FROM " + table + " WHERE branch_id='MN' AND LOAN_ID='" + xacno + "' AND to_char(VCH_DATE,'dd/mm/yyyy')='" + voucher_date + "' AND VCH_NO='" + txtvch_No + "' AND VCH_SRL= " + vch_srl + "";
                    config.Execute_Query(sql);

                }

            }
        }
        public void AddLedger(vchdetail vd)
        {
            string voucher_date = vd.vch_date.ToString("dd/MM/yyyy").Replace("-", "/");
            string sql = "select * from ACC_HEAD WHERE AC_HD='" + vd.ac_hd + "'";
            AccHead ah = new AccHead();
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[0];
                ah.ledger_tab = Convert.ToString(dr["ledger_tab"]);
                ah.led_achd = Convert.ToString(dr["led_achd"]);
                ah.ifcharge = Convert.ToString(dr["ifcharge"]);
                ah.ledger_col = Convert.ToString(dr["ledger_col"]);
                if (ah.ledger_col == "")
                {
                    ah.ledger_col = "P";
                }

                if (ah.ledger_tab == "DEPOSIT_LEDGER_SB" || ah.ledger_tab == "DEPOSIT_LEDGER_FD")
                {
                    decimal lbal_prin = 0;
                    decimal lbal_int = 0;
                    DepositLedgerSB dlsb = new DepositLedgerSB();
                    string sql1 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + vd.vch_pacno + "' AND TO_DATE(TO_CHAR(VCH_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<= TO_DATE('" + voucher_date + "', 'DD/MM/YYYY') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql1);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                        lbal_prin = !Convert.IsDBNull(dr1["prin_bal"]) ? Convert.ToDecimal(dr1["prin_bal"]) : Convert.ToDecimal(00);
                        lbal_int = !Convert.IsDBNull(dr1["int_bal"]) ? Convert.ToDecimal(dr1["int_bal"]) : Convert.ToDecimal(00);
                    }
                    dlsb.branch_id = "MN";
                    dlsb.ac_hd = ah.led_achd;
                    dlsb.ac_no = vd.vch_pacno;
                    dlsb.vch_date = Convert.ToDateTime(voucher_date);
                    dlsb.vch_no = vd.vch_no;
                    dlsb.vch_srl = Convert.ToInt32(vd.vch_srl);
                    dlsb.vch_type = Convert.ToString(vd.vch_type);
                    dlsb.vch_achd = vd.ac_hd;
                    dlsb.dr_cr = vd.vch_drcr;
                    dlsb.ref_ac_hd = vd.ref_ac_hd;
                    dlsb.ref_pacno = vd.ref_pacno;
                    dlsb.ref_oth = vd.ref_oth;
                    dlsb.insert_mode = "D";
                    if (ah.ledger_col == "P")
                    {
                        dlsb.prin_amount = vd.vch_amt;
                        dlsb.int_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.prin_bal = lbal_prin - vd.vch_amt;
                        }
                        else
                        {
                            dlsb.prin_bal = lbal_prin + vd.vch_amt;
                        }
                        dlsb.int_bal = lbal_int;
                    }
                    if (ah.ledger_col == "I")
                    {
                        dlsb.int_amount = vd.vch_amt;
                        dlsb.prin_bal = lbal_prin;
                        dlsb.prin_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.int_bal = lbal_int + vd.vch_amt;
                        }
                        else
                        {
                            dlsb.int_bal = lbal_int - vd.vch_amt;
                        }
                    }

                    config.Insert(ah.ledger_tab, new Dictionary<String, object>()
                     {
                        {"branch_id",dlsb.branch_id },
                        {"ac_hd",dlsb.ac_hd },
                        {"AC_NO",dlsb.ac_no },
                        {"vch_date",dlsb.vch_date },
                        {"vch_no",dlsb.vch_no },
                        {"vch_srl",dlsb.vch_srl },
                        {"vch_type",dlsb.vch_type },
                        {"vch_achd", dlsb.vch_achd},
                        {"dr_cr", dlsb.dr_cr},
                        {"ref_ac_hd", dlsb.ref_ac_hd},
                        {"ref_pacno", dlsb.ref_pacno},
                        {"ref_oth", dlsb.ref_oth},
                        {"insert_mode", dlsb.insert_mode},
                        {"prin_amount", dlsb.prin_amount},
                        {"prin_bal", dlsb.prin_bal},
                        {"INT_AMOUNT", dlsb.int_amount},
                        {"int_bal",dlsb.int_bal},

                    });

                    ResetPrinBalIntBalForDepositLedgerSb_Fd(ah.ledger_tab, ah.led_achd, vd.vch_pacno, voucher_date);
                }

                if (ah.ledger_tab == "GF_LEDGER" || ah.ledger_tab == "TF_LEDGER")
                {
                    decimal lbal_prin = 0;
                    decimal lbal_int = 0;
                    Ledger dlsb = new Ledger();
                    string sql1 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND ac_hd='" + ah.led_achd + "' and Member_id='" + vd.vch_pacno + "' AND TO_DATE(TO_CHAR(VCH_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<= TO_DATE('" + voucher_date + "', 'DD/MM/YYYY') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql1);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                        lbal_prin = !Convert.IsDBNull(dr1["prin_bal"]) ? Convert.ToDecimal(dr1["prin_bal"]) : Convert.ToDecimal(00);
                        lbal_int = !Convert.IsDBNull(dr1["int_bal"]) ? Convert.ToDecimal(dr1["int_bal"]) : Convert.ToDecimal(00);

                    }
                    dlsb.branch_id = "MN";
                    dlsb.ac_hd = ah.led_achd;
                    dlsb.member_id = vd.vch_pacno;
                    dlsb.vch_date = Convert.ToDateTime(vd.vch_date);
                    dlsb.vch_no = vd.vch_no;
                    dlsb.vch_srl = Convert.ToInt32(vd.vch_srl);
                    dlsb.vch_type = Convert.ToString(vd.vch_type);
                    dlsb.vch_achd = vd.ac_hd;
                    dlsb.dr_cr = vd.vch_drcr;
                    dlsb.ref_ac_hd = vd.ref_ac_hd;
                    dlsb.ref_pacno = vd.ref_pacno;
                    dlsb.ref_oth = vd.ref_oth;
                    dlsb.insert_mode = "D";
                    if (ah.ledger_col == "P")
                    {
                        dlsb.prin_amount = vd.vch_amt;
                        dlsb.int_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.prin_bal = lbal_prin - vd.vch_amt;
                        }
                        else
                        {
                            dlsb.prin_bal = lbal_prin + vd.vch_amt;
                        }
                        dlsb.int_bal = lbal_int;
                    }
                    if (ah.ledger_col == "I")
                    {
                        dlsb.int_amount = vd.vch_amt;
                        dlsb.prin_bal = lbal_prin;
                        dlsb.prin_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.int_bal = lbal_int + vd.vch_amt;
                        }
                        else
                        {
                            dlsb.int_bal = lbal_int - vd.vch_amt;
                        }
                    }

                    config.Insert(ah.ledger_tab, new Dictionary<String, object>()
                     {
                        {"branch_id",dlsb.branch_id },
                        {"ac_hd",dlsb.ac_hd },
                        {"MEMBER_ID",dlsb.member_id },
                        {"vch_date",dlsb.vch_date },
                        {"vch_no",dlsb.vch_no },
                        {"vch_srl",dlsb.vch_srl },
                        {"vch_type",dlsb.vch_type },
                        {"vch_achd", dlsb.vch_achd},
                        {"dr_cr", dlsb.dr_cr},
                        {"ref_ac_hd", dlsb.ref_ac_hd},
                        {"ref_pacno", dlsb.ref_pacno},
                        {"ref_oth", dlsb.ref_oth},
                        {"insert_mode", dlsb.insert_mode},
                        {"prin_amount", dlsb.prin_amount},
                        {"prin_bal", dlsb.prin_bal},
                        {"int_bal",dlsb.int_bal},

                    });
                    ResetPrinBalIntBalForGF_TF_CMTDLedger(ah.ledger_tab, ah.led_achd, vd.vch_pacno, vd.vch_date);
                }

                if (ah.ledger_tab == "CMTD_LEDGER")
                {
                    decimal lbal_prin = 0;
                    decimal lbal_int = 0;
                    Ledger dlsb = new Ledger();
                    string sql1 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND  Member_id='" + vd.vch_pacno + "' AND TO_DATE(TO_CHAR(VCH_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<= TO_DATE('" + voucher_date + "', 'DD/MM/YYYY') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql1);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                        lbal_prin = !Convert.IsDBNull(dr1["prin_bal"]) ? Convert.ToDecimal(dr1["prin_bal"]) : Convert.ToDecimal(00);
                        lbal_int = !Convert.IsDBNull(dr1["int_bal"]) ? Convert.ToDecimal(dr1["int_bal"]) : Convert.ToDecimal(00);

                    }
                    dlsb.branch_id = "MN";
                    dlsb.ac_hd = ah.led_achd;
                    dlsb.member_id = vd.vch_pacno;
                    dlsb.vch_date = Convert.ToDateTime(vd.vch_date);
                    dlsb.vch_no = vd.vch_no;
                    dlsb.vch_srl = Convert.ToInt32(vd.vch_srl);
                    dlsb.vch_type = Convert.ToString(vd.vch_type);
                    dlsb.vch_achd = vd.ac_hd;
                    dlsb.dr_cr = vd.vch_drcr;
                    dlsb.ref_ac_hd = vd.ref_ac_hd;
                    dlsb.ref_pacno = vd.ref_pacno;
                    dlsb.ref_oth = vd.ref_oth;
                    dlsb.insert_mode = "D";
                    if (ah.ledger_col == "P")
                    {
                        dlsb.prin_amount = vd.vch_amt;
                        dlsb.int_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.prin_bal = lbal_prin - vd.vch_amt;
                        }
                        else
                        {
                            dlsb.prin_bal = lbal_prin + vd.vch_amt;
                        }
                        dlsb.int_bal = lbal_int;
                    }
                    if (ah.ledger_col == "I")
                    {
                        dlsb.int_amount = vd.vch_amt;
                        dlsb.prin_bal = lbal_prin;
                        dlsb.prin_amount = 0;
                        if (vd.vch_drcr == "D")
                        {
                            dlsb.int_bal = lbal_int + vd.vch_amt;
                        }
                        else
                        {
                            dlsb.int_bal = lbal_int - vd.vch_amt;
                        }
                    }

                    config.Insert(ah.ledger_tab, new Dictionary<String, object>()
                     {
                        {"branch_id",dlsb.branch_id },
                        {"vch_achd",dlsb.ac_hd },
                        {"MEMBER_ID",dlsb.member_id },
                        {"vch_date",dlsb.vch_date },
                        {"vch_no",dlsb.vch_no },
                        {"vch_srl",dlsb.vch_srl },
                        {"vch_type",dlsb.vch_type },
                        {"dr_cr", dlsb.dr_cr},
                        {"ref_ac_hd", dlsb.ref_ac_hd},
                        {"ref_pacno", dlsb.ref_pacno},
                        {"ref_oth", dlsb.ref_oth},
                        {"insert_mode", dlsb.insert_mode},
                        {"prin_amount", dlsb.prin_amount},
                        {"prin_bal", dlsb.prin_bal},
                        {"int_bal",dlsb.int_bal},

                    });
                    ResetPrinBalIntBalForGF_TF_CMTDLedger(ah.ledger_tab, ah.led_achd, vd.vch_pacno, vd.vch_date);
                }

                if (ah.ledger_tab == "SHARE_LEDGER" || ah.ledger_tab == "DIVIDEND_LEDGER")
                {
                    decimal lbal_prin = 0;
                    decimal lbal_int = 0;
                    Ledger dlsb = new Ledger();
                    string sql1 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND Member_id='" + vd.vch_pacno + "' AND TO_DATE(TO_CHAR(VCH_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<= TO_DATE('" + voucher_date + "', 'DD/MM/YYYY') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql1);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                        lbal_prin = !Convert.IsDBNull(dr1["BAL_AMOUNT"]) ? Convert.ToDecimal(dr1["BAL_AMOUNT"]) : Convert.ToDecimal(00);

                    }
                    dlsb.branch_id = "MN";
                    dlsb.member_id = vd.vch_pacno;
                    dlsb.vch_date = Convert.ToDateTime(vd.vch_date);
                    dlsb.vch_no = vd.vch_no;
                    dlsb.vch_srl = Convert.ToInt32(vd.vch_srl);
                    dlsb.vch_type = Convert.ToString(vd.vch_type);
                    dlsb.vch_achd = vd.ac_hd;
                    dlsb.dr_cr = vd.vch_drcr;
                    dlsb.ref_ac_hd = vd.ref_ac_hd;
                    dlsb.ref_pacno = vd.ref_pacno;
                    dlsb.ref_oth = vd.ref_oth;
                    dlsb.insert_mode = "D";
                    dlsb.tran_amount = vd.vch_amt;

                    if (vd.vch_drcr == "D")
                    {
                        dlsb.bal_amount = lbal_prin - vd.vch_amt;
                    }
                    else
                    {
                        dlsb.bal_amount = lbal_prin + vd.vch_amt;
                    }
                    if (ah.ledger_tab == "SHARE_LEDGER")
                    {
                        decimal unit = 0;
                        string QRY = "SELECT * FROM ACC_HEAD WHERE AC_HD='SH' and IS_MISCDEP='Y'";
                        config.singleResult(QRY);
                        if (config.dt.Rows.Count > 0)
                        {
                            DataRow dr2 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                            dlsb.face_val = Convert.ToDecimal(dr2["miscdep_baseamt"]);
                            unit = (dlsb.tran_amount / dlsb.face_val);
                        }

                        config.Insert("SHARE_LEDGER", new Dictionary<String, object>()
                            {
                                {"branch_id",dlsb.branch_id },
                                {"member_id",dlsb.member_id },
                                {"vch_date",dlsb.vch_date },
                                {"vch_no",dlsb.vch_no },
                                {"vch_srl",dlsb.vch_srl },
                                {"vch_type",dlsb.vch_type },
                                {"vch_achd", dlsb.vch_achd},
                                {"dr_cr", dlsb.dr_cr},
                                {"ref_ac_hd", dlsb.ref_ac_hd},
                                {"ref_pacno", dlsb.ref_pacno},
                                {"ref_oth", dlsb.ref_oth},
                                {"insert_mode", dlsb.insert_mode},
                                {"TR_AMOUNT", dlsb.tran_amount},
                                {"BAL_AMOUNT", dlsb.bal_amount},
                                {"FACE_VAL",dlsb.face_val},
                                {"UNITS",unit}

                            });

                    }
                    else
                    {
                        config.Insert("DIVIDEND_LEDGER", new Dictionary<String, object>()
                            {
                                {"branch_id",dlsb.branch_id },
                                {"member_id",member_id },
                                {"vch_date",dlsb.vch_date },
                                {"vch_no",dlsb.vch_no },
                                {"vch_srl",dlsb.vch_srl },
                                {"vch_type",dlsb.vch_type },
                                {"vch_achd", dlsb.vch_achd},
                                {"dr_cr", dlsb.dr_cr},
                                {"ref_ac_hd", dlsb.ref_ac_hd},
                                {"ref_pacno", dlsb.ref_pacno},
                                {"ref_oth", dlsb.ref_oth},
                                {"insert_mode", dlsb.insert_mode},
                                {"TR_AMOUNT", dlsb.tran_amount},
                                {"BAL_AMOUNT", dlsb.bal_amount}

                            });
                    }

                    ResetPrinBalIntBalForShare_DividendLedger(ah.ledger_tab, vd.vch_pacno, vd.vch_date);
                }

                if (ah.ledger_tab == "LOAN_LEDGER_LTL" || ah.ledger_tab == "LOAN_LEDGER_STL" || ah.ledger_tab == "LOAN_LEDGER_FES")
                {
                    decimal lbal_prin = 0;
                    decimal lbal_int = 0;
                    Ledger dlsb = new Ledger();
                    string sql1 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + vd.vch_pacno + "' AND TO_DATE(TO_CHAR(VCH_DATE,'DD/MM/YYYY'),'DD/MM/YYYY') <= TO_DATE('" + voucher_date + "', 'DD/MM/YYYY') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql1);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                        lbal_prin = !Convert.IsDBNull(dr1["prin_bal"]) ? Convert.ToDecimal(dr1["prin_bal"]) : Convert.ToDecimal(00);
                        lbal_int = !Convert.IsDBNull(dr1["int_DUE"]) ? Convert.ToDecimal(dr1["int_DUE"]) : Convert.ToDecimal(00);

                    }
                    dlsb.branch_id = "MN";
                    dlsb.ac_hd = ah.led_achd;
                    dlsb.loan_id = vd.vch_pacno;
                    dlsb.vch_date = Convert.ToDateTime(vd.vch_date);
                    dlsb.vch_no = vd.vch_no;
                    dlsb.vch_srl = Convert.ToInt32(vd.vch_srl);
                    dlsb.vch_type = Convert.ToString(vd.vch_type);
                    dlsb.vch_achd = vd.ac_hd;
                    dlsb.dr_cr = vd.vch_drcr;
                    dlsb.ref_ac_hd = vd.ref_ac_hd;
                    dlsb.ref_pacno = vd.ref_pacno;
                    dlsb.ref_oth = vd.ref_oth;
                    dlsb.insert_mode = "D";
                    //dlsb.no = 0;
                    dlsb.tran_amount = vd.vch_amt;
                    if (ah.ledger_col == "P")
                    {
                        dlsb.prin_amount = dlsb.tran_amount;
                        if (dlsb.dr_cr == "D")
                        {
                            dlsb.prin_bal = lbal_prin + dlsb.tran_amount;
                        }
                        else
                        {
                            dlsb.prin_bal = lbal_prin - dlsb.tran_amount;
                        }
                        dlsb.int_due = lbal_int;
                        dlsb.int_amount = 0;
                    }
                    if (ah.ledger_col == "I")
                    {
                        dlsb.int_amount = dlsb.tran_amount;
                        dlsb.prin_bal = lbal_prin;
                        if (dlsb.dr_cr == "D")
                        {
                            dlsb.int_due = lbal_int + dlsb.tran_amount;
                        }
                        else
                        {
                            dlsb.int_due = lbal_int - dlsb.tran_amount;
                        }

                        dlsb.prin_amount = 0;
                    }
                    LoanLedger ll = new LoanLedger();
                    string installment_no = ll.getLastLoanNo(dlsb.ac_hd, dlsb.loan_id);
                    string sql2 = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + vd.vch_pacno + "' AND TO_CHAR(VCH_DATE,'DD/MM/YYYY') = '" + voucher_date + "' AND vch_no='" + dlsb.vch_no + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                    config.singleResult(sql2);
                    if (config.dt.Rows.Count > 0)
                    {
                        DataRow dr2 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                        installment_no = Convert.ToString(dr2["no"]);
                    }

                    config.Insert(ah.ledger_tab, new Dictionary<String, object>()
                     {
                        {"branch_id",dlsb.branch_id },
                        {"ac_hd",dlsb.ac_hd },
                        {"loan_id",dlsb.loan_id },
                        {"vch_date",dlsb.vch_date },
                        {"vch_no",dlsb.vch_no },
                        {"vch_srl",dlsb.vch_srl },
                        {"vch_type",dlsb.vch_type },
                        {"vch_achd", dlsb.vch_achd},
                        {"dr_cr", dlsb.dr_cr},
                        {"ref_ac_hd", dlsb.ref_ac_hd},
                        {"ref_pacno", dlsb.ref_pacno},
                        {"ref_oth", dlsb.ref_oth},
                        {"insert_mode", dlsb.insert_mode},
                        {"no",installment_no},
                        {"prin_amount", dlsb.prin_amount},
                        {"prin_bal", dlsb.prin_bal},
                        {"int_due", dlsb.int_due},
                        {"int_amount", dlsb.int_amount}

                    });

                    ResetPrinBalIntDueForLoanLedger_LTL_STL_FES_for_vch_entry(ah.ledger_tab, ah.led_achd, vd.vch_pacno, vd.vch_date);
                }



            }


        }
        public void ResetPrinBalIntBalForDepositLedgerSb_Fd(string xledtab, string xled_achd, string xacno, string dt)
        {
            Ledger ld = new Ledger();
            decimal lbal_prin = 0;
            decimal lbal_int = 0;
            string sql = "SELECT * FROM " + xledtab + " WHERE AC_HD='" + xled_achd + "' AND AC_NO='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')<to_date('" + dt + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow ldr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                lbal_prin = !Convert.IsDBNull(ldr["prin_bal"]) ? Convert.ToDecimal(ldr["prin_bal"]) : Convert.ToDecimal(00);
                lbal_int = !Convert.IsDBNull(ldr["int_bal"]) ? Convert.ToDecimal(ldr["int_bal"]) : Convert.ToDecimal(00);
            }

            sql = "SELECT * FROM " + xledtab + " WHERE AC_HD='" + xled_achd + "' AND AC_NO='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')>=to_date('" + dt + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ld.dr_cr = Convert.ToString(dr["dr_cr"]);
                    if (ld.dr_cr == "D")
                    {
                        lbal_prin = lbal_prin - (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int + (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }
                    else
                    {
                        lbal_prin = lbal_prin + (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int - (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }
                    string VOUCHER_DATE = ((Convert.ToDateTime(dr["vch_date"])).ToShortDateString()).Replace("-", "/");
                    ld.vch_no = Convert.ToString(dr["vch_no"]);
                    ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);

                    string qry = "Update " + xledtab + " set prin_bal=" + lbal_prin + ",int_bal=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "'  AND AC_NO='" + xacno + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                    config.Execute_Query(qry);



                }

            }







        }

        public void ResetPrinBalIntBalForGF_TF_CMTDLedger(string xledtab, string xled_achd, string xacno, DateTime vch_dt)
        {

            Ledger ld = new Ledger();
            decimal lbal_prin = 0;
            decimal lbal_int = 0;
            string sql = "SELECT * FROM " + xledtab + " where Member_id='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')<to_date('" + vch_dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow ldr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                lbal_prin = !Convert.IsDBNull(ldr["prin_bal"]) ? Convert.ToDecimal(ldr["prin_bal"]) : Convert.ToDecimal(00);
                lbal_int = !Convert.IsDBNull(ldr["int_bal"]) ? Convert.ToDecimal(ldr["int_bal"]) : Convert.ToDecimal(00);
            }

            sql = "SELECT * FROM " + xledtab + " WHERE  Member_id='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')>=to_date('" + vch_dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ld.dr_cr = Convert.ToString(dr["dr_cr"]);
                    if (ld.dr_cr == "D")
                    {
                        lbal_prin = lbal_prin - (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int + (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }
                    else
                    {
                        lbal_prin = lbal_prin + (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int - (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }

                    string VOUCHER_DATE = (Convert.ToDateTime(dr["vch_date"])).ToString("dd/MM/yyyy").Replace("-", "/");
                    ld.vch_no = Convert.ToString(dr["vch_no"]);
                    ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);
                    string qry = "Update " + xledtab + " set prin_bal=" + lbal_prin + ",int_bal=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' AND member_id='" + xacno + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                    config.Execute_Query(qry);





                }

            }







        }

        public void ResetPrinBalIntBalForShare_DividendLedger(string xledtab, string xacno, DateTime dt)
        {
            Ledger ld = new Ledger();
            decimal lbal_prin = 0;
            //decimal lbal_int = 0;
            //decimal Tr_prin = 0;
            //decimal Tr_int = 0;





            string sql = "SELECT * FROM " + xledtab + " where  Member_id='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')<to_date('" + dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow ldr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                lbal_prin = !Convert.IsDBNull(ldr["BAL_AMOUNT"]) ? Convert.ToDecimal(ldr["BAL_AMOUNT"]) : Convert.ToDecimal(00);

            }


            sql = "SELECT * FROM " + xledtab + " WHERE  Member_id='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')>=to_date('" + dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ld.dr_cr = Convert.ToString(dr["dr_cr"]);
                    if (ld.dr_cr == "D")
                    {
                        lbal_prin = lbal_prin - (!Convert.IsDBNull(dr["tr_amount"]) ? Convert.ToDecimal(dr["tr_amount"]) : Convert.ToDecimal(00));

                    }
                    else
                    {
                        lbal_prin = lbal_prin + (!Convert.IsDBNull(dr["tr_amount"]) ? Convert.ToDecimal(dr["tr_amount"]) : Convert.ToDecimal(00));

                    }

                    string VOUCHER_DATE = ((Convert.ToDateTime(dr["vch_date"])).ToShortDateString()).Replace("-", "/");
                    ld.vch_no = Convert.ToString(dr["vch_no"]);
                    ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);
                    string qry = "Update " + xledtab + " set BAL_AMOUNT=" + lbal_prin + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' and Member_id='" + xacno + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                    config.Execute_Query(qry);

                    //config.Update(xledtab, new Dictionary<string, object>()
                    //{
                    //{ "BAL_AMOUNT",  lbal_prin }



                    //}, new Dictionary<string, object>()
                    //{
                    //{ "to_char(vch_date,'dd/mm/yyyy')", VOUCHER_DATE },
                    //{ "vch_no",   ld.vch_no },
                    //{ "vch_srl",   ld.vch_srl }
                    //});


                }

            }







        }

        public void ResetPrinBalIntDueForLoanLedger_LTL_STL_FES_for_vch_entry(string xledtab, string xled_achd, string xacno, DateTime dt)
        {
            Ledger ld = new Ledger();
            decimal lbal_prin = 0;
            decimal lbal_int = 0;
            int i = 1;
            //decimal Tr_prin = 0;
            //decimal Tr_int = 0;




            string sql = "SELECT * FROM " + xledtab + " where  AC_HD='" + xled_achd + "' AND LOAN_ID='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')<to_date('" + dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow ldr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                lbal_prin = !Convert.IsDBNull(ldr["prin_bal"]) ? Convert.ToDecimal(ldr["prin_bal"]) : Convert.ToDecimal(00);
                lbal_int = !Convert.IsDBNull(ldr["int_Due"]) ? Convert.ToDecimal(ldr["int_Due"]) : Convert.ToDecimal(00);

            }


            sql = "SELECT * FROM " + xledtab + " WHERE AC_HD='" + xled_achd + "' AND LOAN_ID='" + xacno + "' and to_date(to_char(VCH_DATE,'dd/mm/yyyy'),'dd/mm/yyyy')>=to_date('" + dt.ToString("dd/MM/yyyy").Replace("-", "/") + "','dd/mm/yyyy') ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {

                    ld.dr_cr = Convert.ToString(dr["dr_cr"]);
                    if (ld.dr_cr == "D")
                    {
                        lbal_prin = lbal_prin + (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int + (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }
                    else
                    {
                        lbal_prin = lbal_prin - (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                        lbal_int = lbal_int - (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                    }

                    string VOUCHER_DATE = ((Convert.ToDateTime(dr["vch_date"])).ToShortDateString()).Replace("-", "/");
                    ld.vch_no = Convert.ToString(dr["vch_no"]);
                    ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);

                    string qry = "Update " + xledtab + " set prin_bal=" + lbal_prin + ",int_Due=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' AND LOAN_ID='" + xacno + "'and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                    config.Execute_Query(qry);





                }

            }







        }

        public void ResetPrinBalIntDueForLoanLedger_LTL_STL_FES(string xledtab, string xled_achd, string xacno)
        {
            Ledger ld = new Ledger();
            decimal lbal_prin = 0;
            decimal lbal_int = 0;
            int i = 1;
            //decimal Tr_prin = 0;
            //decimal Tr_int = 0;
            string sql = "SELECT * FROM " + xledtab + " WHERE AC_HD='" + xled_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    if (i == 1)
                    {

                        lbal_prin = !Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00);

                        lbal_int = !Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00);



                        string VOUCHER_DATE = ((Convert.ToDateTime(dr["vch_date"])).ToShortDateString()).Replace("-", "/");
                        ld.vch_no = Convert.ToString(dr["vch_no"]);
                        ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);

                        string qry = "Update " + xledtab + " set prin_bal=" + lbal_prin + ",int_Due=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + " AND LOAN_ID='" + xacno + "'";
                        config.Execute_Query(qry);
                        //config.Update(xledtab, new Dictionary<string, object>()
                        //{
                        //{ "prin_bal",  lbal_prin },
                        //{ "int_Due",  lbal_int }


                        //}, new Dictionary<string, object>()
                        //{
                        //{ "to_char(vch_date,'dd/mm/yyyy')", VOUCHER_DATE },
                        //{ "vch_no",   ld.vch_no },
                        //{ "vch_srl",   ld.vch_srl }
                        //});
                    }
                    else
                    {
                        ld.dr_cr = Convert.ToString(dr["dr_cr"]);
                        if (ld.dr_cr == "D")
                        {
                            lbal_prin = lbal_prin + (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                            lbal_int = lbal_int + (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                        }
                        else
                        {
                            lbal_prin = lbal_prin - (!Convert.IsDBNull(dr["prin_amount"]) ? Convert.ToDecimal(dr["prin_amount"]) : Convert.ToDecimal(00));
                            lbal_int = lbal_int - (!Convert.IsDBNull(dr["INT_AMOUNT"]) ? Convert.ToDecimal(dr["INT_AMOUNT"]) : Convert.ToDecimal(00));
                        }

                        string VOUCHER_DATE = ((Convert.ToDateTime(dr["vch_date"])).ToShortDateString()).Replace("-", "/");
                        ld.vch_no = Convert.ToString(dr["vch_no"]);
                        ld.vch_srl = Convert.ToInt32(dr["vch_srl"]);

                        string qry = "Update " + xledtab + " set prin_bal=" + lbal_prin + ",int_Due=" + lbal_int + " where to_char(vch_date,'dd/mm/yyyy')='" + VOUCHER_DATE + "' AND LOAN_ID='" + xacno + "' and vch_no='" + ld.vch_no + "' and vch_srl=" + ld.vch_srl + "";
                        config.Execute_Query(qry);

                        //config.Update(xledtab, new Dictionary<string, object>()
                        //    {
                        //    { "prin_bal",  lbal_prin },
                        //    { "int_Due",  lbal_int }


                        //    }, new Dictionary<string, object>()
                        //    {
                        //    { "to_char(vch_date,'dd/mm/yyyy')", VOUCHER_DATE },
                        //    { "vch_no",   ld.vch_no },
                        //    { "vch_srl",   ld.vch_srl }
                        //    });




                    }

                    i = i + 1;

                }

            }







        }

    }
}