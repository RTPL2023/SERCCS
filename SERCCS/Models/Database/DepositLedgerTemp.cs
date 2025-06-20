using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class DepositLedgerTemp
    {

        DBConfig config = new DBConfig();
        public String branch_id { get; set; }
        public String ac_hd { get; set; }
        public String ac_no { get; set; }
        public DateTime vch_date { get; set; }
        public String vch_no { get; set; }
        public Int64 vch_srl { get; set; }
        public String vch_type { get; set; }
        public String vch_achd { get; set; }
        public String dr_cr { get; set; }
        public String contno { get; set; }
        public String chq_no { get; set; }
        public DateTime chq_dt { get; set; }
        public String bankcd { get; set; }
        public String chq_oprmode { get; set; }
        public decimal prin_amount { get; set; }
        public decimal int_amount { get; set; }
        public decimal prin_bal { get; set; }
        public decimal int_bal { get; set; }
        public String chq_bearer { get; set; }
        public String ref_ac_hd { get; set; }
        public String ref_pacno { get; set; }
        public String ref_oth { get; set; }
        public String insert_mode { get; set; }
        public String created_by { get; set; }
        public DateTime created_on { get; set; }
        public String computer_name { get; set; }
        public String modified_by { get; set; }
        public DateTime modified_on { get; set; }

        public String mcomputer_name { get; set; }
        public String pan_number { get; set; }
        //  public double tr_amount { get; set; }

        public void DeleteFromDepositLedgerTemp(DepositLedgerTemp dlt)
        {
            string vchdate = Convert.ToString(Convert.ToDateTime(dlt.vch_date).ToShortDateString().Replace("-", "/"));
            string sql;


            sql = "Delete from deposit_ledger_temp where  prin_amount=" + dlt.prin_amount + " and ac_no='" + dlt.ac_no + "' and vch_no='" + dlt.vch_no + "' and ac_hd='" + dlt.ac_hd + "' and TO_CHAR(VCH_DATE, 'DD/MM/YYYY')= '" + vchdate + "' and dr_cr='" + dlt.dr_cr + "'";
            config.Execute_Query(sql);


        }
        public void UpdateDepositLedgerTem(DepositLedgerTemp dlt)
        {
            string vchdate = Convert.ToString(Convert.ToDateTime(dlt.vch_date).ToShortDateString().Replace("-", "/"));
            string sql;


            sql = "update deposit_ledger_temp set  prin_amount=" + dlt.prin_amount + ",ac_no='" + dlt.ac_no + "',  modified_by='" + dlt.modified_by + "', modified_on = to_date('" + dlt.modified_on.ToShortDateString() + "','DD/MM/YYYY'), mcomputer_name='" + dlt.mcomputer_name + "' where vch_no='" + dlt.vch_no + "' and ac_hd='" + dlt.vch_achd + "' and TO_CHAR(VCH_DATE, 'DD/MM/YYYY')= '" + vchdate + "' and vch_srl=" + dlt.vch_srl + " and dr_cr='" + dlt.dr_cr + "'";
            config.Execute_Query(sql);


        }


    }



}