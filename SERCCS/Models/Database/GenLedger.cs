using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Models.Database
{
    public class GenLedger
    {
        public string trn_date { get; set; }
        public string ac_hd { get; set; }
        public string dr_cr { get; set; }

        public string cash_journal { get; set; }
        public string trn_no { get; set; }
        public string vch_no { get; set; }
        public string particulars { get; set; }
        public int amt { get; set; }
        public int bal { get; set; }
        public string msgbox { get; set; }
    }
}
