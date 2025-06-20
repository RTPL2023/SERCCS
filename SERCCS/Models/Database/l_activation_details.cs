using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using System.Text;
using SERCCS.Models.Views;

namespace SERCCS.Models.Database
{
    public class l_activation_details
    {
        DBConfig config = new DBConfig();
        public string l_date { get; set; }
        public DateTime create_date { get; set; }
        public string str_create_date { get; set; }
        public string valid_upto { get; set; }
        

       

    }
}
