using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class ClaimRegister
    {
        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String employee_id { get; set; }
        public String claim_issued { get; set; }
        public DateTime claim_date { get; set; }
        public string str_claim_date { get; set; }
        public String lnr_issued { get; set; }
        public DateTime lnr_date { get; set; }
        public String loanid_ltl { get; set; }
        public DateTime loandate_ltl { get; set; }
        public Decimal loanamt_ltl { get; set; }
        public Decimal loanint_ltl { get; set; }
        public String ref_loanid_ltl{ get; set; }
        public DateTime ref_loandate_ltl { get; set; }
        public String loanid_con { get; set; }
        public DateTime loandate_con { get; set; }
        public Decimal loanamt_con { get; set; }
        public Decimal loanint_con { get; set; }
        public String loanid_fes { get; set; }
        public DateTime loandate_fes { get; set; }
        public Decimal loanamt_fes { get; set; }
        public Decimal loanint_fes { get; set; }
        public Decimal total_claim { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }
        public String mcomputer_name { get; set; }
        public String claim_no { get; set; }

        public String ref_no { get; set; }
        public String issued_to { get; set; }
        public String office_address { get; set; }
        public String ledger_folio { get; set; }
        public String claim_type { get; set; }

      
    }
}