using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class TempMemberMast
    {
        DBConfig config = new DBConfig();

        String sql;
        public string branch_id { get; set; }
        public string member_id { get; set; }
        public string employer_cd { get; set; }
        public string employer_branch { get; set; }
        public string t_no { get; set; }
        public string book_no { get; set; }
        public string employee_id { get; set; } //control no
        public DateTime member_date { get; set; }
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
        public DateTime birth_date { get; set; }
        public Nullable<DateTime> Nominal_birth_date { get; set; }
        public string caste_id { get; set; }
        public string sex { get; set; }
        public string relgn_id { get; set; }
        public string occup_id { get; set; }
        public Int32 married { get; set; }
        public Int32 if_lti { get; set; }
        public string serv_status { get; set; }
        public string dept_cd { get; set; }
        public string desig_cd { get; set; }
        public DateTime date_of_joining { get; set; }
        public Nullable<DateTime> Nominal_date_of_joining { get; set; }
        public DateTime date_of_retirement { get; set; }
        public Nullable<DateTime> Nominal_date_of_retirement { get; set; }
        public string pan_no { get; set; }
        public string id_mark { get; set; }
        public string remarks { get; set; }
        public string is_dead { get; set; }
        public DateTime expiry_date { get; set; }
        public Nullable<DateTime> Nominal_expiry_date { get; set; }
        public string member_closed { get; set; }
        public DateTime member_closdt { get; set; }
        public Nullable<DateTime> Nominal_member_closdt { get; set; }
        public decimal tf_buffer { get; set; }
        public string member_retired { get; set; }
        public string member_transfered { get; set; }
        public decimal sbamt { get; set; }
        public string cmtdno { get; set; }
        public string cmtdamt { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }
        public string sign_flag { get; set; }

        public Int64 queue_id { get; set; }
        public Int32 intr_srl { get; set; }
        public string intr_member_id { get; set; }
        public string intr_name { get; set; }

        public MemberNominee mn { get; set; }

        public MemberIntroducer mi { get; set; }

        public string ipass { get; set; }
        public string contno_11d { get; set; }
       
    }
}
