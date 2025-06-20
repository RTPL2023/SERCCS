using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using Oracle.ManagedDataAccess.Client;


namespace SERCCS.Models.Database
{
    public class AccHead
    {
        DBConfig config = new DBConfig();
        public string ac_hd { get; set; }
        public string ac_manager { get; set; }
        public string ac_subgr { get; set; }
        public string ac_desc { get; set; }
        public string cb_flag { get; set; }
        public string ledger_tab { get; set; }
        public string led_achd { get; set; }
        public string ifcharge { get; set; }
        public string ac_lf_mast_fl { get; set; }
        public string is_clearing { get; set; }
        public string ledger_col { get; set; }
        public string acc_prefix { get; set; }
        public string is_miscdep { get; set; }
        public string is_miscpay { get; set; }
        public Decimal miscdep_baseamt { get; set; }
        public string invest_flag { get; set; }
        public string ex_trial { get; set; }
        public string is_member_fund { get; set; }
        public string is_salary_deduction { get; set; }
        public string is_contra { get; set; }
        public string earnings { get; set; }
        public string expenditure { get; set; }
        public string assets { get; set; }
        public string liabilities { get; set; }
        public string capital { get; set; }
        public string adj_ac { get; set; }
        public string cash_book { get; set; }
        public Int64 sl_no { get; set; }
        public string dip { get; set; }
        public Int64 dip_rate { get; set; }
        public string pla { get; set; }
        public Int64 cnt { get; set; }
        public String ac_parti { get; set; }
        public String clos_flag { get; set; }
        public String particulars { get; set; }
        public String achd_name { get; set; }
        public String achd_value { get; set; }

        public List<AccHead> getacchdfortialbalance(string achd_type, string achd)
        {
            string sql = "";
            List<AccHead> aclist = new List<AccHead>();
            if (achd_type == "li")
            {
                sql = "SELECT a.*, a.AC_HD || ' - ' || a.AC_DESC AS AC_PARTI FROM li_achd a where upper(a.AC_DESC) LIKE '%" + achd.ToUpper() + "%' ORDER BY a.AC_HD";

            }
            else
            {
                sql = "SELECT a.*, a.AC_HD || ' - ' || a.AC_DESC AS AC_PARTI FROM ae_achd a where upper(a.AC_DESC) LIKE '%" + achd.ToUpper() + "%' ORDER BY a.AC_HD";

            }
            config.Load_DTG(sql);
            int i = 1;
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    if (i == 1)
                    {
                        AccHead ah1 = new AccHead();
                        ah1.ac_desc = "Select Achd";
                        ah1.ac_hd = "";
                        ah1.ac_parti = "Select Achd";
                        aclist.Add(ah1);
                    }
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    ah.ac_parti = dr["AC_PARTI"].ToString();

                    aclist.Add(ah);
                    i = i + 1;
                }
            }
            else aclist = null;

            return aclist;



        }

        public AccHead getacchdDescfortialbalanceByachd(string achd_type, string achd)
        {
            string sql = "";
            AccHead ah = new AccHead();
            if (achd_type == "li")
            {
                sql = "SELECT * FROM li_achd where AC_HD ='" + achd.ToUpper() + "'";
            }
            else
            {
                sql = "SELECT * FROM ae_achd where AC_HD ='" + achd.ToUpper() + "'";
            }
            config.Load_DTG(sql);
            int i = 1;
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();

                }
            }
            return ah;
        }
        public List<AccHead> GetAccheadListPLAYes()
        {
            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT * FROM ACC_HEAD WHERE PLA='YES' ORDER BY AC_HD";
            config.Load_DTG(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    aclist.Add(ah);
                }
            }
            else aclist = null;

            return aclist;
        }
        public AccHead Getparticular(string achd, string acno)
        {
            AccHead ah = new AccHead();
            string sql;
            sql = "select * from ACC_HEAD WHERE AC_HD = '" + achd + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                ah.ac_lf_mast_fl = dr["AC_LF_MAST_FL"].ToString();
                ah.led_achd = dr["LED_ACHD"].ToString();


            }

            if (ah.ac_lf_mast_fl == "D")
            {
                sql = "SELECT AC_NAME AS NAME_OUT,AC_CLOSED AS CLOS_FLG FROM DEPOSIT_MAST WHERE BRANCH_ID='MN' AND ";
                sql = sql + "AC_HD='" + ah.led_achd + "' AND AC_NO='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "L")
            {
                sql = "SELECT loanee_name AS NAME_OUT,CLOS_FLAG AS CLOS_FLG FROM loan_master WHERE BRANCH_ID='MN' AND ";
                sql = sql + "AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "M")
            {
                sql = "SELECT MEMBER_NAME AS NAME_OUT,MEMBER_CLOSED AS CLOS_FLG FROM MEMBER_MAST WHERE BRANCH_ID='MN' AND ";
                sql = sql + "MEMBER_ID='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "K")
            {
                sql = "SELECT AC_NAME AS NAME_OUT,AC_CLOSED AS CLOS_FLG FROM LOCKER_MASTER WHERE BRANCH_ID='MN' AND ";
                sql = sql + "LOCKER_AC_NO='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "I")
            {

                sql = "SELECT INVEST_NAME AS NAME_OUT,AC_CLOSED AS CLOS_FLG FROM INVEST_MASTER WHERE BRANCH_ID='MN' AND ";
                sql = sql + "AC_HD='" + ah.led_achd + "' AND AC_NO='" + acno + "'";
            }

            if (ah.ac_lf_mast_fl == "A")
            {
                sql = "SELECT DD_AGENT_NAME AS NAME_OUT,AC_CLOSED AS CLOS_FLG FROM DD_AGENT_MASTER WHERE BRANCH_ID='MN' AND ";
                sql = sql + "DD_AGENT_CODE='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "S")
            {
                sql = "SELECT AC_NAME AS NAME_OUT,SUSPENSE_TYPE,suspense_amount,SUSPENSE_DR,SUSPENSE_CR,AC_CLOSED AS CLOS_FLG FROM SUSPENSE_MASTER ";
                sql = sql + "WHERE AC_HD='" + ah.led_achd + "' AND AC_NO='" + acno + "'";
            }
            if (ah.ac_lf_mast_fl == "C")
            {
                sql = "SELECT MEMBER_NAME AS NAME_OUT,MEMBER_CLOSED AS CLOS_FLG FROM MEMBER_MAST WHERE BRANCH_ID='MN' AND ";
                sql = sql + "EMPLOYEE_ID='" + acno + "'";
            }
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr1 = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                ah.particulars = Convert.ToString(dr1["NAME_OUT"]);
                ah.clos_flag = Convert.ToString(dr1["CLOS_FLG"]);
            }
            return ah;
        }

        public AccHead GetAccHeadDetailByID(String achd)
        {
            AccHead ah = new AccHead();
            string sql;
            sql = "select * from Acc_Head ORDER BY AC_HD";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ah.led_achd = dr["LED_ACHD"].ToString();
                    ah.ledger_tab = dr["LED_ACHD"].ToString();
                    ah.ledger_col = dr["LEDGER_COL"].ToString();
                }
            }
            else ah = null;

            return ah;
        }
        public List<AccHead> GetAccheadList()
        {
            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a ORDER BY a.AC_HD";
            config.Load_DTG(sql);
            int i = 1;
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    if (i==1)
                    {
                        AccHead ah1 = new AccHead();
                        ah1.ac_desc = "Select Achd";
                        ah1.ac_hd = "Select Achd";
                        ah1.ac_parti = "Select Achd";
                        aclist.Add(ah1);
                    }
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    ah.ac_parti = dr["AC_PARTI"].ToString();
                    aclist.Add(ah);
                    i = i + 1;
                }
            }
            else aclist = null;

            return aclist;
        }
        public AccHead GetAccHeadDetail( string vch_achd)
        {
            AccHead ah = new AccHead();
            string sql = "select * from acc_head where ledger_tab='SHARE_LEDGER'";
            config.Load_DTG(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    ah.ac_hd = dr["ac_hd"].ToString();
                    if (ah.ac_hd == vch_achd)
                    {
                        ah.ac_desc = dr["ac_desc"].ToString();
                        ah.miscdep_baseamt = !Convert.IsDBNull(dr["miscdep_baseamt"]) ? Convert.ToDecimal(dr["miscdep_baseamt"]) : Convert.ToDecimal("00");
                    }
                    else
                    {
                        ah.ac_desc = "";
                        ah.miscdep_baseamt = Convert.ToDecimal("00");
                    }
                }
            }
            return ah;
        }
        public List<AccHead> getAccHeaddetails()
        {
            string sql;
            sql = "select * from Acc_Head";
            config.singleResult(sql);
            List<AccHead> lstah = new List<AccHead>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    lstah.Add(ah);
                }
            }
            return lstah;
        }
        public Boolean GET_GEN_LEDGER(string XACHD, string PACNO)
        {
            string xacno = null;
            string sql;
            sql = "select * from ACC_HEAD WHERE AC_HD='" + XACHD + "' ";
            config.singleResult(sql);
            AccHead ah = new AccHead();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    //AccHead ah = new AccHead();
                    ah.ledger_tab = dr["ledger_tab"].ToString();
                    ah.led_achd = dr["led_achd"].ToString();
                    ah.ifcharge = dr["ifcharge"].ToString();
                    if (ah.ledger_tab == " ")
                    {

                    }
                    if (ah.ifcharge != null)
                    {
                        sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + XACHD + "' AND to_char(VCH_DATE,'dd/mm/yyyy')='MN'";
                    }
                    else
                    {
                        if (xacno == null)
                        {

                        }
                        if (ah.ledger_tab == "DEPOSIT_LEDGER_SB")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "DEPOSIT_LEDGER_FD")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "SHARE_LEDGER" || ah.ledger_tab == "CMTD_LEDGER" || ah.ledger_tab == "GF_LEDGER" || ah.ledger_tab == "TF_LEDGER" || ah.ledger_tab == "DIVIDEND_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN' AND MEMBER_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "LOAN_LEDGER_CON")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "LOAN_LEDGER_FES")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "LOAN_LEDGER_LTL")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "LOAN_LEDGER_STL")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND LOAN_ID='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "LOCKER_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND LOCKER_AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "INVEST_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "DD_AGENT_SEC_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND DD_AGENT_CODE='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                        if (ah.ledger_tab == "SUSPENSE_LEDGER")
                        {
                            sql = "SELECT * FROM " + ah.ledger_tab + " WHERE branch_id='MN'AND AC_HD='" + ah.led_achd + "' AND AC_NO='" + xacno + "' ORDER BY VCH_DATE,VCH_NO,VCH_SRL";
                        }
                    }
                }
            }
            return true;

        }
        public List<AccHead> AC_HD()
        {
            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a ORDER BY a.AC_HD";
            config.Load_DTG(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    AccHead ah = new AccHead();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    aclist.Add(ah);
                }
            }
            return aclist;
        }


        public List<AccHead> GetAccheads()
        {
            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT AC_HD FROM ACC_HEAD WHERE AC_HD<>'P&L' AND CASH_BOOK='YES' GROUP BY AC_HD ORDER BY AC_HD";
            config.Load_DTG(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    AccHead ah = new AccHead();

                    ah.ac_hd = dr["ac_hd"].ToString();
                    aclist.Add(ah);
                }
            }
            else aclist = null;

            return aclist;
        }
        public AccHead GetAccHeadDetailByACHD(String achd)
        {
            AccHead ah = new AccHead();
            string sql;
            sql = "SELECT * FROM ACC_HEAD WHERE AC_HD ='" + achd + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                ah.ac_desc = dr["ac_desc"].ToString();
                ah.earnings = dr["EARNINGS"].ToString();
                ah.expenditure = dr["EXPENDITURE"].ToString();
                ah.assets = dr["ASSETS"].ToString();
                ah.liabilities = dr["LIABILITIES"].ToString();


            }
            else
            {
                ah = null;
            }


            return ah;
        }
        public AccHead GetAccHeadDetailByACDesc(String achd)
        {
            AccHead ah = new AccHead();
            string sql;
            sql = "SELECT * FROM ACC_HEAD WHERE AC_DESC ='" + achd + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                ah.ac_desc = dr["ac_desc"].ToString();
                ah.earnings = dr["EARNINGS"].ToString();
                ah.expenditure = dr["EXPENDITURE"].ToString();
                ah.assets = dr["ASSETS"].ToString();
                ah.liabilities = dr["LIABILITIES"].ToString();


            }
            else
            {
                ah = null;
            }


            return ah;
        }
        public AccHead GetLastAccHeadDetailByACHD(String achd)
        {
            AccHead ah = new AccHead();
            string sql;
            sql = "SELECT * FROM ACC_HEAD WHERE AC_HD ='" + achd + "'";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];

                ah.ac_desc = dr["ac_desc"].ToString();


            }
            else ah = null;

            return ah;
        }

        public List<AccHead> getAchdListForBalanceSheet(string achd, string comboAsstLiab)
        {
            string sql = "";
            if (comboAsstLiab== "ASSETS")
            {
                sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a WHERE ASSETS='YES' and a.AC_HD LIKE '" + achd.ToUpper() + "%'";
            }
            if (comboAsstLiab == "LIABILITIES")
            {
                sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a WHERE LIABILITIES='YES' and a.AC_HD LIKE '" + achd.ToUpper() + "%'";
            }
            List<AccHead> iml = new List<AccHead>();
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    AccHead ime = new AccHead();
                    ime.achd_name = Convert.ToString(dr["AC_PARTI"]);
                    ime.achd_value = Convert.ToString(dr["AC_HD"]); 
                    iml.Add(ime);
                }
            }
            return iml;
        }


        public List<AccHead> getAchdListForVchEntry(string vch_achd)
        {

            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a where a.AC_HD LIKE '" + vch_achd.ToUpper() + "%' ORDER BY a.AC_HD";
            config.Load_DTG(sql);
            int i = 1;
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    if (i == 1)
                    {
                        AccHead ah1 = new AccHead();
                        ah1.ac_desc = "Select Achd";
                        ah1.ac_hd = "";
                        ah1.ac_parti = "Select Achd";
                        aclist.Add(ah1);
                    }
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    ah.ac_parti = dr["AC_PARTI"].ToString();
                    aclist.Add(ah);
                    i = i + 1;
                }
            }
            else aclist = null;

            return aclist;


         
        }

        public List<AccHead> getAchdListForTrialBalance(string vch_achd)
        {

            List<AccHead> aclist = new List<AccHead>();
            string sql = "SELECT a.*, a.AC_HD||' - '|| a.AC_DESC AS AC_PARTI FROM ACC_HEAD a where UPPER(a.AC_DESC) LIKE '%" + vch_achd.ToUpper() + "%' ORDER BY a.AC_HD";
            config.Load_DTG(sql);
            int i = 1;
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    if (i == 1)
                    {
                        AccHead ah1 = new AccHead();
                        ah1.ac_desc = "Select Achd";
                        ah1.ac_hd = "";
                        ah1.ac_parti = "Select Achd";
                        aclist.Add(ah1);
                    }
                    AccHead ah = new AccHead();
                    ah.ac_desc = dr["ac_desc"].ToString();
                    ah.ac_hd = dr["ac_hd"].ToString();
                    ah.ac_parti = dr["AC_PARTI"].ToString();
                    aclist.Add(ah);
                    i = i + 1;
                }
            }
            else aclist = null;

            return aclist;



        }


    }
}