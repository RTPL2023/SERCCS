using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class LoanData
    {
        DBConfig config = new DBConfig();
        string sql;
        public string employee_id { get; set; }
        public string Loanachd { get; set; }
        public string ltl_no { get; set; }
        public Int32 ltl_inst { get; set; }
        public DateTime ltl_rec_date { get; set; }
        public DateTime ltl_close_date { get; set; }
        public string ltl_stop { get; set; }
        public string ltl_nr { get; set; }
        public Int32 ltl_nr_number { get; set; }
        public string stl_no { get; set; }
        public Int32 stl_inst { get; set; }
        public DateTime stl_rec_date { get; set; }
        public DateTime stl_close_date { get; set; }
        public string stl_stop { get; set; }
        public string stl_nr { get; set; }
        public Int32 stl_nr_number { get; set; }
        public string created_by { get; set; }
        public DateTime created_on { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public string mcomputer_name { get; set; }

       
    }
        
}
    
