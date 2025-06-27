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
        public string opening_branch { get; set; }

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
        public string nom_name { get; set; }
        public string nom_dob { get; set; }
        public string nom_reln { get; set; }
        public string nom_pan { get; set; }
        public string nom_aadhar { get; set; }
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
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = '"+branchid+"' AND AC_HD = '" + achd + "' AND CONTNO = '" + Contno + "'";
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
                    dm.spl_status = Convert.ToString(dr["spl_status"]);
                    dm.oprn_mode = Convert.ToString(dr["oprn_mode"]);
                    dm.chq_facility = Convert.ToString(dr["chq_facility"]);
                    if (dm.chq_facility == "1")
                    {
                        dm.chq_facility = "YES";
                    }
                    else
                    {
                        dm.chq_facility = "NO";

                    }
                 
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

            sql = "SELECT * FROM MEMBER_MAST WHERE BRANCH_ID = '"+branchid+"' AND EMPLOYEE_ID = '" + Contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.contno = Contno;
                    
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
                    dm.nom_name = dr["nom_name"].ToString();
                    dm.nom_aadhar = dr["nom_aadhar"].ToString();
                    dm.nom_pan = dr["nom_pan"].ToString();
                    dm.nom_dob = dr["nom_dob"].ToString();
                    dm.nom_reln = dr["nom_reln"].ToString();
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
        public string GetAcnoByContnoForAcOpening(string cont_no)
        {
            string sql;
            sql = "select * from DEPOSIT_MAST WHERE AC_HD = 'SB' AND CONTNO='" + cont_no + "'";
            config.singleResult(sql);
            DepositMast dm = new DepositMast();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.ac_no = dr["ac_no"].ToString();
                    dm.msg = "This Member Is Already a Savings Account Holder. A/C No : " + dm.ac_no;
                }
            }
            else
            {
                dm.msg = null;
            }
            return dm.msg;
        }
        public DepositMast GetDepositMastByAcNo(String branchid, string achd, string acno)
        {
            DepositMast dm = new DepositMast();

            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = '"+ branchid + "' AND AC_HD = '" + achd + "' AND AC_NO = '" + acno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.ac_hd = dr["ac_hd"].ToString();
                    dm.ac_no = dr["ac_no"].ToString();
                    dm.branch_id = dr["branch_id"].ToString();
                    dm.contno = dr["contno"].ToString();
                    dm.open_date = Convert.ToDateTime(dr["open_date"]);
                    dm.oprn_mode = dr["oprn_mode"].ToString();
                    dm.chq_facility = dr["chq_facility"].ToString();
                    dm.is_minor = dr["is_minor"].ToString();
                    dm.minor_adult_dt = !Convert.IsDBNull(dr["minor_adult_dt"]) ? Convert.ToDateTime(dr["minor_adult_dt"]) : Convert.ToDateTime("01/01/0001");
                    dm.ac_no = dr["ac_no"].ToString();
                    dm.ac_name = dr["ac_name"].ToString();
                    dm.ac_add1 = dr["ac_add1"].ToString();
                    dm.ac_add2 = dr["ac_add2"].ToString();
                    dm.ac_city = dr["ac_city"].ToString();
                    dm.ac_dist = dr["ac_dist"].ToString();
                    dm.ac_state = dr["ac_state"].ToString();
                    dm.ac_pin = dr["ac_pin"].ToString();
                    dm.spl_status = dr["spl_status"].ToString();
                    dm.td_term = dm.td_term + ((Convert.ToString(dr["td_yy"])).Length > 0 ? (Convert.ToString(dr["td_yy"]) + "Yr") : "");
                    dm.td_term = dm.td_term + ((Convert.ToString(dr["td_mm"])).Length > 0 ? (Convert.ToString(dr["td_mm"]) + "Mn") : "");
                    dm.td_term = dm.td_term + ((Convert.ToString(dr["td_dd"])).Length > 0 ? (Convert.ToString(dr["td_dd"]) + "Dy") : "");
                    dm.td_face_val = Convert.ToDecimal(dr["td_face_val"].ToString() == "" ? "0" : dr["td_face_val"].ToString());
                    dm.td_int_rate = Convert.ToDecimal(dr["td_int_rate"].ToString() == "" ? "0" : dr["td_int_rate"].ToString());
                    dm.td_intfrq_mm = Convert.ToInt32(dr["td_intfrq_mm"].ToString() == "" ? "0" : dr["td_intfrq_mm"].ToString());
                    dm.td_inst_intr = Convert.ToDecimal(dr["td_inst_intr"].ToString() == "" ? "0" : dr["td_inst_intr"].ToString());
                    dm.td_mat_date = !Convert.IsDBNull(dr["td_mat_date"]) ? Convert.ToDateTime(dr["td_mat_date"]) : Convert.ToDateTime("01/01/0001");
                    dm.td_mat_val = Convert.ToDecimal(dr["td_mat_val"].ToString() == "" ? "0" : dr["td_mat_val"].ToString());
                    dm.ac_closed = dr["ac_closed"].ToString();
                    dm.ac_clos_date = dr["ac_clos_date"].ToString();
                    dm.msg1 = "Data Found";
                    if (achd == "FD")
                    {
                        dm.msg = "Account No already exist for Fixed Deposit";
                    }
                    if (achd == "SB")
                    {
                        dm.msg = "Account No already blocked to : " + dm.contno;
                    }
                }
            }
            else
            {
                dm = null;
            }
            return dm;
        }
        public void SaveDepositMast(DepositMast dm)
        {
            try
            {
                config.Insert("Deposit_Mast", new Dictionary<String, object>()
                {
                    { "branch_id",dm.branch_id },
                    { "ac_hd",dm.ac_hd },
                    { "ac_no",dm.ac_no },
                    { "contno",dm.contno },
                    { "created_by",dm.created_by },
                    { "created_on",dm.created_on },
                    { "computer_name",dm.computer_name },
                    { "open_date",dm.open_date },
                    { "spl_status",dm.spl_status },
                    { "chq_facility",dm.chq_facility },
                    { "oprn_mode",dm.oprn_mode },
                    { "ac_name",dm.ac_name },
                    { "ac_add1",dm.ac_add1 },
                    { "ac_add2",dm.ac_add2 },
                    { "ac_city",dm.ac_city },
                    { "ac_dist",dm.ac_dist },
                    { "ac_state",dm.ac_state },
                    { "ac_pin",dm.ac_pin },
                    { "is_minor",dm.is_minor },
                    { "minor_dob",dm.minor_dob },
                    { "minor_adult_dt",dm.minor_adult_dt },
                    { "OPENING_BRANCH",dm.branch_id },
                });
            }
            catch (Exception ex)
            {
                msg = "Unable To Save. Error : " + Convert.ToString(ex);
            }
        }
        public DepositMast GetDepositOrMemberMastbyACNo(string branchid, string achd, string Acno)
        {
            DepositMast dm = new DepositMast();
            string sql = "SELECT * FROM DEPOSIT_MAST WHERE BRANCH_ID = '"+ branchid + "' AND AC_HD = '" + achd + "' AND ac_no = '" + Acno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.contno = Convert.ToString(dr["contno"]);
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
                    dm.spl_status = Convert.ToString(dr["spl_status"]);
                    dm.oprn_mode = Convert.ToString(dr["oprn_mode"]);
                    dm.chq_facility = Convert.ToString(dr["chq_facility"]);
                    if (dm.chq_facility == "1")
                    {
                        dm.chq_facility = "YES";
                    }
                    else
                    {
                        dm.chq_facility = "NO";
                    }
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
            sql = "SELECT * FROM MEMBER_MAST WHERE BRANCH_ID = '"+branchid+"' AND EMPLOYEE_ID = '" + dm.contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
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
            sql = "SELECT * FROM Kyc_details WHERE CONT_NO = '" + dm.contno + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dm.nom_name = dr["nom_name"].ToString();
                    dm.nom_aadhar = dr["Nom_Aadhar"].ToString();
                    dm.nom_pan = dr["Nom_Pan"].ToString();
                    dm.nom_dob = dr["Nom_Dob"].ToString();
                    dm.nom_reln = dr["Nom_Reln"].ToString();
                    dm.pan = dr["pan_No"].ToString();
                }
            }
            return dm;
        }
    }

}

