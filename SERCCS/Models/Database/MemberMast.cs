using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;


namespace SERCCS.Models.Database
{
    public class MemberMast
    {
        DBConfig config = new DBConfig();

        String sql;
        public string cnt { get; set; }
        public string branch_id { get; set; }
        public string employer_cd { get; set; }
        public string employer_branch { get; set; }
        public string au { get; set; }
        public string buno { get; set; }
        public string employee_id { get; set; }
        public string member_type { get; set; }
        public string mem_category { get; set; }
        public string member_first_nm { get; set; }
        public string member_last_nm { get; set; }
        public string member_name { get; set; }
        public string payment_mode { get; set; }
        public string grdn_name { get; set; }
        public string reln_id { get; set; }
        public string mail_hno { get; set; }
        public string mail_add1 { get; set; }
        public string mail_add2 { get; set; }
        public string mail_city { get; set; }
        public string mail_dist { get; set; }
        public string mail_state { get; set; }
        public string mail_pin { get; set; }
        public string perm_hno { get; set; }
        public string perm_add1 { get; set; }
        public string perm_add2 { get; set; }
        public string perm_city { get; set; }
        public string perm_dist { get; set; }
        public string perm_state { get; set; }
        public string perm_pin { get; set; }
        public string phone_no { get; set; }
        public string blood_group { get; set; }
        public string caste_id { get; set; }
        public string sex { get; set; }
        public string relgn_id { get; set; }
        public string occup_id { get; set; }
        public int married { get; set; }
        public bool blmarried { get; set; }
        public int if_lti { get; set; }
        public bool blif_lti { get; set; }
        public string status { get; set; }
        public string dept_cd { get; set; }
        public string desig_cd { get; set; }
        public DateTime birth_date { get; set; }
        public DateTime date_of_joining { get; set; }
        public DateTime date_of_retirement { get; set; }
        public DateTime member_date { get; set; }
        public DateTime expiry_date { get; set; }
        public DateTime member_closdt { get; set; }
        public DateTime do50pwcm { get; set; }
        public DateTime date_of_remember { get; set; }

        public string strbirth_date { get; set; }

        public string strdate_of_joining { get; set; }
        public string strdate_of_retirement { get; set; }
        public string strmember_date { get; set; }
        public string strexpiry_date { get; set; }
        public string strmember_closdt { get; set; }
        public string strdate_of_remember { get; set; }

        public string strdo50pwcm { get; set; }
        public string pan_no { get; set; }
        public string id_mark { get; set; }
        public string remarks { get; set; }
        public string is_dead { get; set; }
        public bool blis_dead { get; set; }
        public string member_closed { get; set; }
        public bool blmember_closed { get; set; }
        public int tf_buffer { get; set; }
        public string member_retired { get; set; }
        public bool blmember_retired { get; set; }
       
        public decimal sbamt { get; set; }
        public string cmtdno { get; set; }
        public decimal cmtdamt { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public int ra { get; set; }
        public string su { get; set; }
        public string empid_type { get; set; }
        public string member_transfered { get; set; }
        public bool membertransfered { get; set; }

        public MemberMast GetRecByEmployeeId(String EmployeeId, string branch)
        {
            MemberMast mm = new MemberMast();
            string sql = "select * from MEMBER_MAST where branch_id='" + branch + "' AND EMPLOYEE_ID='" + EmployeeId + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    mm.branch_id = dr["branch_id"].ToString();
                    mm.employer_cd = dr["EMPLOYER_CD"].ToString();
                    mm.employer_branch = dr["employer_branch"].ToString();
                    mm.au = dr["au"].ToString();
                    mm.buno = dr["buno"].ToString();
                    mm.member_date = !Convert.IsDBNull(dr["member_date"]) ? Convert.ToDateTime(dr["member_date"]) : Convert.ToDateTime("01/01/0001");
                    mm.birth_date = !Convert.IsDBNull(dr["birth_date"]) ? Convert.ToDateTime(dr["birth_date"]) : Convert.ToDateTime("01/01/0001");
                    mm.date_of_joining = !Convert.IsDBNull(dr["date_of_joining"]) ? Convert.ToDateTime(dr["date_of_joining"]) : Convert.ToDateTime("01/01/0001");
                    mm.date_of_retirement = !Convert.IsDBNull(dr["date_of_retirement"]) ? Convert.ToDateTime(dr["date_of_retirement"]) : Convert.ToDateTime("01/01/0001");
                    mm.date_of_remember = !Convert.IsDBNull(dr["DATE_OF_REMEMBER"]) ? Convert.ToDateTime(dr["DATE_OF_REMEMBER"]) : Convert.ToDateTime("01/01/0001");
                    mm.do50pwcm = !Convert.IsDBNull(dr["do50pwcm"]) ? Convert.ToDateTime(dr["do50pwcm"]) : Convert.ToDateTime("01/01/0001");
                    mm.member_closdt = !Convert.IsDBNull(dr["member_closdt"]) ? Convert.ToDateTime(dr["member_closdt"]) : Convert.ToDateTime("01/01/0001");
                    mm.expiry_date = !Convert.IsDBNull(dr["expiry_date"]) ? Convert.ToDateTime(dr["expiry_date"]) : Convert.ToDateTime("01/01/0001");
                    mm.strmember_date = mm.member_date.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strmember_date == "01/01/0001")
                    {
                        mm.strmember_date = "";
                    }
                    mm.strbirth_date = mm.birth_date.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strbirth_date == "01/01/0001")
                    {
                        mm.strbirth_date = "";
                    }
                    mm.strdate_of_joining = mm.date_of_joining.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strdate_of_joining == "01/01/0001")
                    {
                        mm.strdate_of_joining = "";
                    }
                    mm.strdate_of_retirement = mm.date_of_retirement.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.date_of_retirement.ToString("dd/MM/yyyy") == "01/01/0001")
                    {
                        mm.strdate_of_retirement = "";
                    }
                    mm.strdate_of_remember = mm.date_of_remember.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strdate_of_remember == "01/01/0001")
                    {
                        mm.strdate_of_remember = "";
                    }
                    mm.strdo50pwcm = mm.do50pwcm.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.do50pwcm.ToString("dd/MM/yyyy") == "01/01/0001")
                    {
                        mm.strdo50pwcm = "";
                    }
                    mm.strmember_closdt = mm.member_closdt.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strmember_closdt == "01/01/0001")
                    {
                        mm.strmember_closdt = "";
                    }
                    mm.strexpiry_date = mm.expiry_date.ToString("dd/MM/yyyy").Replace("-", "/");
                    if (mm.strexpiry_date == "01/01/0001")
                    {
                        mm.strexpiry_date = "";
                    }
                    mm.member_type = dr["MEMBER_TYPE"].ToString();
                    mm.mem_category = dr["MEM_CATEGORY"].ToString();
                    mm.member_first_nm = dr["MEMBER_FIRST_NM"].ToString();
                    mm.member_last_nm = dr["MEMBER_LAST_NM"].ToString();
                    mm.member_name = dr["MEMBER_NAME"].ToString();
                    mm.payment_mode = dr["PAYMENT_MODE"].ToString();
                    mm.grdn_name = dr["GRDN_NAME"].ToString();
                    mm.reln_id = dr["RELN_ID"].ToString();
                    mm.caste_id = dr["caste_id"].ToString();
                    mm.relgn_id = dr["relgn_id"].ToString();
                    mm.mail_hno = dr["MAIL_HNO"].ToString();
                    mm.mail_add1 = dr["mail_add1"].ToString();
                    mm.mail_add2 = dr["mail_add2"].ToString();
                    mm.mail_city = dr["mail_city"].ToString();
                    mm.mail_dist = dr["mail_dist"].ToString();
                    mm.mail_state = dr["MAIL_STATE"].ToString();
                    mm.mail_pin = dr["MAIL_PIN"].ToString();
                    mm.perm_hno = dr["perm_hno"].ToString();
                    mm.perm_add1 = dr["perm_add1"].ToString();
                    mm.perm_add2 = dr["perm_add2"].ToString();
                    mm.perm_city = dr["perm_city"].ToString();
                    mm.perm_dist = dr["perm_dist"].ToString();
                    mm.perm_state = dr["perm_state"].ToString();
                    mm.perm_pin = dr["perm_pin"].ToString();
                    mm.phone_no = dr["phone_no"].ToString();
                    mm.ra = Convert.ToInt32(dr["ra"]);
                    mm.blood_group = dr["blood_group"].ToString();
                    mm.sex = dr["sex"].ToString();
                    if (mm.sex == "M")
                    {
                        mm.sex = "MALE";
                    }
                    else if (mm.sex == "F")
                    {
                        mm.sex = "FEMALE";
                    }
                    else
                    {
                        mm.sex = "OTHER";
                    }
                    mm.status = dr["status"].ToString();
                    mm.remarks = dr["remarks"].ToString();
                    mm.reln_id = dr["reln_id"].ToString();
                    mm.relgn_id = dr["relgn_id"].ToString();
                    mm.phone_no = dr["phone_no"].ToString();
                    mm.grdn_name = dr["grdn_name"].ToString();
                    mm.if_lti = !Convert.IsDBNull(dr["if_lti"]) ? Convert.ToInt32(dr["if_lti"]) : Convert.ToInt32("0");
                    if (mm.if_lti == 1)
                        mm.blif_lti = true;
                    else
                        mm.blif_lti = false;
                    mm.married = !Convert.IsDBNull(dr["married"]) ? Convert.ToInt32(dr["married"]) : Convert.ToInt32("0");

                    if (mm.married == 1)
                        mm.blmarried = true;
                    else
                        mm.blmarried = false;
                    //if (mm.status == "CT")
                    //    mm.membertransfered = true;
                    //else
                    //    mm.membertransfered = false;
                    mm.member_transfered = Convert.ToString(dr["MEMBER_TRANSFERED"]);

                    if (mm.member_transfered == "Y")
                        mm.membertransfered = true;
                    else
                        mm.membertransfered = false;
                    mm.member_retired = Convert.ToString(dr["member_retired"]);
                    if (mm.member_retired == "Y")
                        mm.blmember_retired = true;
                    else
                        mm.blmember_retired = false;
                    mm.member_closed = Convert.ToString(dr["member_closed"]);

                    if (mm.member_closed == "C")
                        mm.blmember_closed = true;
                    else
                        mm.blmember_closed = false;
                    mm.is_dead = Convert.ToString(dr["is_dead"]);

                    if (mm.is_dead == "D")
                        mm.blis_dead = true;
                    else
                        mm.blis_dead = false;
                }
            }
            return mm;
        }

    }
}

