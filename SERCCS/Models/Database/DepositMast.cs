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


        
    }

}

