using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class FunddepMast
    {
        DBConfig config = new DBConfig();
        public string ac_hd { get; set; }
        public string fund_desc { get; set; }
        public string int_appl { get; set; }
        public string int_achd { get; set; }
        public string ledger_tab { get; set; }
        public string acc_head_ledger_tab { get; set; }
        public string is_deposit { get; set; }
        public Decimal int_rate { get; set; }
        public Decimal bal_amount { get; set; }
        public Decimal int_bal { get; set; }
        public Decimal prin_bal { get; set; }
        public Decimal int_payable { get; set; }

        public bool xok { get; set; }


        //MEMBER_MAST
        public string member_id { get; set; }
        public string employee_id { get; set; }

                //DEPOSIT_MAST
        public string ac_no { get; set; }

        //CMTD LEDGER

        //DIVIDEND LEDGER

        //GF LEDGER

        //TF LEDGER

        //SHARE LEDGER



        


    }
}