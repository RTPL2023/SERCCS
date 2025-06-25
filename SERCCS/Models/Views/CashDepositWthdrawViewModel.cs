using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;

namespace SERCCS.Models.Views
{
    public class CashDepositWthdrawViewModel
    {
        public String BranchID { get; set; }
        public String AcHd { get; set; }
        public String AcNo { get; set; }
        public DateTime VchDate { get; set; }
        public String ContNo { get; set; }
        public String CounterNo { get; set; }
        public String PoNo { get; set; }  //po no
        public String ModeOfOprtn { get; set; }  //Mode of Operation
        public String LastBalance { get; set; }
        public String LastOpDate { get; set; }
        public String InsertMode { get; set; }
        public String WithAmount { get; set; }
        public String Name { get; set; }
        public String BalAmount { get; set; }
        public String DepositWithdrow { get; set; }
        public String MaxWithAmount { get; set; }

        public string ModeOfPayment { get; set; }
        public string totalAmt { get; set; }
        public string table { get; set; }

        public string Total { get; set; }

        //[Display(Name = "trans_date")]
        //[DataType(DataType.Date)]
        public String TransDate { get; set; }
        public String FromDate  {get; set; }

        public String ToDate { get; set; }

        public String PhotoImageUrl { get; set; }
        public String SigImageUrl { get; set; }
        public String btnTotal { get; set; }
        public String btnPrint { get; set; }
        public String btnSave { get; set; }
        public string msgbox { get; set; }
        public string totaltrn { get; set; }
        public string TotalDeposit { get; set; }
        public string tableelemebnt { get; set; }
        

    }
}
