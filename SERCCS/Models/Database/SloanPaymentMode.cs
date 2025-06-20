using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class SloanPaymentMode
    {
        DBConfig config = new DBConfig();
        public DateTime ldate { get; set; }
        public String sldate { get; set; }
        public String loan_id { get; set; }
        public String loan_id_2 { get; set; }
        public String employee_id { get; set; }
        public String payment_mode { get; set; }
        public String list_no { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String loan_id_first { get; set; }
        public String loan_idlast { get; set; }

       
    }
}