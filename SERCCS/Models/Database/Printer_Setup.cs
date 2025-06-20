using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;


namespace SERCCS.Models.Database
{
    public class Printer_Setup
    {
        DBConfig config = new DBConfig();

        String sql;
        public string description { get; set; }
        public string name { get; set; }
        public string created_by { get; set; }
        public DateTime create_date { get; set; }
        public string computer_name { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_date { get; set; }
        public string m_computer_name { get; set; }
        public string msg { get; set; }


        
    }
}
