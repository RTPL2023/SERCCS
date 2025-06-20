using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;


namespace SERCCS.Models.Database
{
    public class ListLoanLtl
    {
     DBConfig config = new DBConfig();
     string sql;
     public Int32 list_no { get; set; }
     public DateTime ldate { get; set; }
     public String xyear { get; set; }
     public Int32 ch_no { get; set; }
     public String loan_id_from { get; set; }
     public String loan_to { get; set; }
     public String favour { get; set; }
     public Int32 amount { get; set; }
     public String payment_mode { get; set; }
     public String ac_hd { get; set; }
     public String refo  { get; set; }
     public String ref1 { get; set; }
     public String ref2 { get; set; }
     public String ref3 { get; set; }
     public String ref4 { get; set; }
     public String ref5 { get; set; }
     public String ref_l { get; set; }
     public String bank { get; set; }
     public Decimal ref_amount { get; set; }
     public Decimal ref_amount1 { get; set; }
     public Decimal ref_amount2 { get; set; }
    public Decimal ref_amount3 { get; set; }
    public Decimal ref_amount4 { get; set; }
    public Decimal ref_amount5 { get; set; }
    public Decimal ref_amount_l { get; set; }
    public String add_less { get; set; }
    public String created_by { get; set; }
    public DateTime created_on { get; set; }
    public String computer_name { get; set; }
    public String modified_by { get; set; }
    public DateTime modified_on { get; set; }
    public String mcomputer_name { get; set; }
    public String hasvalue { get; set; }

        
    }   
  }