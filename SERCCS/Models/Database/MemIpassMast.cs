using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class MemIpassMast
    {
        DBConfig config = new DBConfig();
        public string branch_id { get; set; }
        public string caste_id { get; set; }
        public string sex { get; set; }
        public DateTime birth_date { get; set; }
        public DateTime date_of_retirement { get; set; }
        public string member_id { get; set; }
        public string tag { get; set; }
        public string member_name { get; set; }
        public string employee_id { get; set; }
        public string ipass_id { get; set; }
        public string bu_no { get; set; }
        public string sb_ac_no { get; set; }
        public Int32 sb_amt { get; set; }
        public Int32 cmtd_amt { get; set; }
        public Int32 vcmtd { get; set; }
        public Int32 male { get; set; }
        public Int32 female { get; set; }
        public Int32 trans { get; set; }
        public Int32 gen { get; set; }
        public Int32 sc { get; set; }
        public Int32 st { get; set; }
        public Int32 obc { get; set; }


        public Int32 m_gen { get; set; }
        public Int32 f_gen { get; set; }
        public Int32 t_gen { get; set; }
        public Int32 m_sc { get; set; }
        public Int32 f_sc { get; set; }
        public Int32 t_sc { get; set; }
        public Int32 m_st { get; set; }
        public Int32 f_st { get; set; }
        public Int32 t_st { get; set; }
        public Int32 m_obc { get; set; }
        public Int32 f_obc { get; set; }
        public Int32 t_obc { get; set; }
        public Int32 tot_mem { get; set; }
        public Int32 tot_mem_count { get; set; }

      


        
    }
}