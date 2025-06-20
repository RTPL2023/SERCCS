using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;
using SERCCS.Models.Views;
namespace SERCCS.Models.Database
{
    public class TempVchEntry
    {
        DBConfig config = new DBConfig();
        public String drcr { get; set; }
        public DateTime vch_dt { get; set; }
        public Int32 srl    { get; set; }
        public string ac_hd { get; set; }
        public string vch_pacno { get; set; }
        public String paid_to_rcv_frm { get; set; }
        public decimal amount { get; set; }
        public String ref_achd { get; set; }
        public String ref_acno { get; set; }
        public String ref_ac_particulars { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String m_computer_name { get; set; }
        public String vch_no { get; set; }



        
    }
}
