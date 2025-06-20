using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class DepositTransfer
    {

        public string dr_cr { get; set; }
        public string ac_no { get; set; }
        public string vch_acname { get; set; }
        public string print_amount { get; set; }
        public string vch_no { get; set; }
        public string vch_date { get; set; }


        public string vch_drcr { get; set; }

        public string vch_pacno { get; set; }

        public string contno { get; set; }
        public string vch_amt { get; set; }

        public string trn_no { get; set; }
        public string trn_date { get; set; }
             public string ref_oth { get; set; }              
    }
}
