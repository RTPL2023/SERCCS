using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;

using System.Data;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{

    public class DepositMast
    {
        DBConfig config = new DBConfig();

        String sql;
        public string branch_id { get; set; }
        public string ac_hd { get; set; }
        public string ac_no { get; set; }
        public string contno { get; set; }
        public DateTime open_date { get; set; }
        public string open_date_s { get; set; }
        public string str_open_date { get; set; }
        public string ac_name { get; set; }
        public string ac_add1 { get; set; }
        public string ac_add2 { get; set; }
        public string ac_state { get; set; }
        public string ac_city { get; set; }
        public string ac_dist { get; set; }
        public string ac_pin { get; set; }
        public string spl_status { get; set; }
        public string Is_Matured { get; set; }
        public string dd_agent_code { get; set; }
        public string ac_regd_date { get; set; }
        public string chq_facility { get; set; }
        public string oprn_mode { get; set; }
        public string is_minor { get; set; }
        public DateTime minor_dob { get; set; }
        public string str_minor_dob { get; set; }
        public DateTime minor_adult_dt { get; set; }
        public string str_minor_adult_dt { get; set; }
        public Int32 td_dd { get; set; }
        public Int32 td_mm { get; set; }
        public Int32 td_yy { get; set; }
        public decimal td_face_val { get; set; }
        public decimal td_inst_intr { get; set; }
        public decimal td_int_rate { get; set; }
        public DateTime td_mat_date { get; set; }
        public decimal td_mat_val { get; set; }
        public Int32 td_intfrq_mm { get; set; }
        public string str_td_intfrq_mm { get; set; }
        public Int64 td_cert_no { get; set; }
        public string td_cert_issued { get; set; }
        public string td_pledged { get; set; }
        public string td_pledge_ac_hd { get; set; }
        public string modifyopen_date { get; set; }
        public DateTime td_renew_date { get; set; }
        public string td_renew_flag { get; set; }
        public string ac_closed { get; set; }
        public string ac_clos_date { get; set; }
        public decimal td_clos_int_pay { get; set; }
        public decimal td_clos_rate { get; set; }
        public string td_clos_paymode { get; set; }
        public string remarks { get; set; }
        public string book_no { get; set; }
        public string t_no { get; set; }
        public string dept_cd { get; set; }
        public string created_by { get; set; }

        public string td_pledge_loan_id { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string td_term { get; set; }
        public string Date { get; set; }

        public string barcodepath { get; set; }
        public string barcode { get; set; }
        public string msg { get; set; }
        public string msg1 { get; set; }


        //from Member_Mast*****************
        public string member_id { get; set; }
        public string grdn_name { get; set; }
        public string reln_id { get; set; }
        public string sex { get; set; }
        public string occup_id { get; set; }

        //from Member_Mast*****************
        public string Nom_name { get; set; }
        public string nom_DoB { get; set; }
        public string Nom_Reln { get; set; }
        public string Nom_Pan { get; set; }
        public string Nom_aadhar { get; set; }
        public Int32 if_lti { get; set; }
        public string lti { get; set; }
        public string sign { get; set; }
        public string pan { get; set; }
        public string prin_bal { get; set; }
        public string ac_DESC { get; set; }
        public string int_bal { get; set; }
        public string ledger_tab { get; set; }
        public DateTime vch_date { get; set; }
        public string status { get; set; }
        public decimal penal_int { get; set; }
        public decimal totint { get; set; }
        public string inttag { get; set; }


        public DepositMast CheckStatus(string achd, string ac_no)
        {
            DepositMast dm = new DepositMast();
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID='MN' AND AC_HD='" + achd + "' AND Ac_No='" + ac_no + "' ORDER BY AC_NO";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.ac_closed = Convert.ToString(dr["ac_closed"]);


                }
            }
            return dm;
        }
        public void UpdateDepositMastForClosFlag(DepositMast dm)
        {

            config.Update("Deposit_Mast", new Dictionary<string, object>()
                {
                { "ac_closed", dm.ac_closed },
                { "ac_clos_date", DateTime.Now}

                }, new Dictionary<string, object>()
                {
                {"ac_hd", dm.ac_hd},
                {"ac_no",dm.ac_no }

                });

        }
        public DepositMast GetDepositOrMemberMastbyContNo(string branchid, string achd, string Contno)
        {
            DepositMast dm = new DepositMast();
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = 'MN' AND AC_HD = '" + achd + "' AND CONTNO = '" + Contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.contno = Contno;
                    dm.ac_name = Convert.ToString(dr["ac_name"]);
                    dm.ac_hd = Convert.ToString(dr["ac_hd"]);
                    dm.ac_no = Convert.ToString(dr["ac_no"]);
                    dm.branch_id = Convert.ToString(dr["branch_id"]);
                    if ((!Convert.IsDBNull(dr["open_date"]) ? Convert.ToDateTime(dr["open_date"]) : Convert.ToDateTime("01/01/0001")) != Convert.ToDateTime("01/01/0001"))
                    {
                        dm.str_open_date = (Convert.ToDateTime(dr["open_date"])).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dm.str_open_date = "";
                    }

                    dm.ac_add1 = Convert.ToString(dr["ac_add1"]);
                    dm.ac_add2 = Convert.ToString(dr["ac_add2"]);
                    dm.ac_city = Convert.ToString(dr["ac_city"]);
                    dm.ac_dist = Convert.ToString(dr["ac_dist"]);
                    dm.ac_state = Convert.ToString(dr["ac_state"]);
                    dm.ac_pin = Convert.ToString(dr["ac_pin"]);

                    dm.is_minor = Convert.ToString(dr["is_minor"]);
                    if (dm.is_minor != null && dm.is_minor != "")
                    {
                        dm.str_minor_dob = (!Convert.IsDBNull(dr["minor_dob"]) ? Convert.ToDateTime(dr["minor_dob"]) : Convert.ToDateTime("01/01/0001")).ToString("dd/MM/yyyy");
                        dm.str_minor_adult_dt = (!Convert.IsDBNull(dr["minor_adult_dt"]) ? Convert.ToDateTime(dr["minor_adult_dt"]) : Convert.ToDateTime("01/01/0001")).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dm.str_minor_dob = "";
                        dm.str_minor_adult_dt = "";
                    }

                }

            }

            sql = "SELECT * FROM MEMBER_MAST WHERE BRANCH_ID = 'MN' AND EMPLOYEE_ID = '" + Contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.contno = Contno;
                    dm.member_id = dr["member_id"].ToString();
                    dm.grdn_name = dr["grdn_name"].ToString();
                    dm.reln_id = dr["reln_id"].ToString();
                    dm.occup_id = dr["occup_id"].ToString();
                    dm.if_lti = !Convert.IsDBNull(dr["if_lti"]) ? Convert.ToInt32(dr["if_lti"]) : Convert.ToInt32("0");
                    if (if_lti == 0)
                    {
                        dm.lti = "NO";
                        dm.sign = "YES";
                    }
                    else
                    {
                        dm.lti = "YES";
                        dm.sign = "NO";
                    }
                    dm.sex = dr["sex"].ToString();
                    if (dm.sex == "M")
                        dm.sex = "Male";
                    else if (dm.sex == "F")
                        dm.sex = "Female";
                    else if (dm.sex == "O")
                        dm.sex = "Other";
                    dm.ac_name = dr["member_name"].ToString();
                    dm.ac_add1 = dr["mail_add1"].ToString();
                    dm.ac_add2 = dr["mail_add2"].ToString();
                    dm.ac_city = dr["mail_city"].ToString();
                    dm.ac_dist = dr["mail_dist"].ToString();
                    dm.ac_state = dr["mail_state"].ToString();
                    dm.ac_pin = dr["mail_pin"].ToString();

                }

            }
            sql = "SELECT * FROM Kyc_details WHERE CONT_NO = '" + Contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.Nom_name = dr["nom_name"].ToString();
                    dm.Nom_aadhar = dr["Nom_Aadhar"].ToString();
                    dm.Nom_Pan = dr["Nom_Pan"].ToString();
                    dm.nom_DoB = dr["Nom_Dob"].ToString();
                    dm.Nom_Reln = dr["Nom_Reln"].ToString();
                    dm.pan = dr["pan_No"].ToString();

                }

            }

            return dm;
        }
        public DepositMast GetDepositMastbycontNo(string contno)
        {
            DepositMast dm = new DepositMast();
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = 'MN' AND AC_HD = 'SB' AND CONTNO = '" + contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.ac_hd = dr["ac_hd"].ToString();
                    dm.ac_no = dr["ac_no"].ToString();
                    dm.branch_id = dr["branch_id"].ToString();
                    dm.contno = dr["contno"].ToString();
                    dm.ac_no = dr["ac_no"].ToString();
                }
            }
            else
            {
                dm = null;
            }
            return dm;
        }
        public List<DepositMast> GetDepositMastFDDetail(string achd, string contno)
        {
            string sql;
            List<DepositMast> dmlist = new List<DepositMast>();
            sql = "SELECT * FROM DEPOSIT_MAST WHERE AC_HD='FD' AND AC_CLOSED IS NULL AND CONTNO='" + contno + "' order by td_mat_date";
            config.Load_DTG(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    DepositMast dm = new DepositMast();

                    dm.ac_no = dr["ac_no"].ToString();
                    dm.td_face_val = Convert.ToDecimal(dr["td_face_val"]);
                    dm.td_mat_date = !Convert.IsDBNull(dr["td_mat_date"]) ? Convert.ToDateTime(dr["td_mat_date"]) : Convert.ToDateTime("01/01/0001");
                    dm.td_mat_val = !Convert.IsDBNull(dr["td_mat_val"]) ? Convert.ToDecimal(dr["td_mat_val"]) : Convert.ToDecimal("00");
                    dm.open_date = !Convert.IsDBNull(dr["open_date"]) ? Convert.ToDateTime(dr["open_date"]) : Convert.ToDateTime("01/01/0001");
                    dm.td_int_rate = Convert.ToDecimal(dr["td_int_rate"]);
                    dm.td_intfrq_mm = Convert.ToInt32(dr["td_intfrq_mm"]);
                    dm.td_inst_intr = Convert.ToDecimal(dr["td_inst_intr"]);
                    dm.td_term = Convert.ToString(!Convert.IsDBNull(dr["td_yy"]) ? Convert.ToInt32(dr["td_yy"]) : Convert.ToInt32("00")) + "Yr ";
                    dm.td_term = dm.td_term + Convert.ToString(!Convert.IsDBNull(dr["td_mm"]) ? Convert.ToInt32(dr["td_mm"]) : Convert.ToInt32("00")) + "Mn ";
                    dm.td_term = dm.td_term + Convert.ToString(!Convert.IsDBNull(dr["td_dd"]) ? Convert.ToInt32(dr["td_dd"]) : Convert.ToInt32("00")) + "Dy ";





                    dmlist.Add(dm);

                }
            }
            return dmlist;
        }

    }

}

