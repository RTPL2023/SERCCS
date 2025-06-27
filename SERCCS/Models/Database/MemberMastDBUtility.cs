using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class MemberMastDBUtility
    {
        DBConfig config = new DBConfig();

        String sql;

        public KycDetails getKycDetailsBySingleCont(string contno)
        {
            string sql = "Select * from KYC_DETAILS where CONT_NO='" + contno + "'";

            config.singleResult(sql);
            KycDetails kd = new KycDetails();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    kd.cont_no = dr["cont_no"].ToString();
                    kd.md_of_op = dr["md_of_op"].ToString();
                    kd.photo = dr["PHOTO"] != System.DBNull.Value ? (byte[])dr["PHOTO"] : null;
                    kd.sign = dr["SIGN"] != System.DBNull.Value ? (byte[])dr["SIGN"] : null;
                    kd.photo_j = dr["PHOTO_J"] != System.DBNull.Value ? (byte[])dr["PHOTO_J"] : null; /*(byte[])dr["PHOTO"];*/
                    kd.sign_j = dr["SIGN_J"] != System.DBNull.Value ? (byte[])dr["SIGN_J"] : null; /*(byte[])dr["SIGN"];*/
                    kd.aadhar_no = (dr["aadhar_no"]).ToString();
                    kd.mobile_no = (dr["mobile_no"]).ToString();
                    kd.pan_no = (dr["pan_no"]).ToString();
                    kd.email_id = (dr["email_id"]).ToString();
                    kd.user_id = (dr["User_id"]).ToString();
                    kd.create_date = !Convert.IsDBNull(dr["create_date"]) ? Convert.ToDateTime(dr["create_date"]) : Convert.ToDateTime("01/01/0001");
                    kd.Bank_Name = (dr["bank_name"]).ToString();
                    kd.ac_no = (dr["ac_no"]).ToString();
                    kd.ifsc = (dr["ifsc"]).ToString();
                    kd.pan_no = dr["pan_no"].ToString();
                    kd.Nom_Name = (dr["Nom_Name"]).ToString();
                    kd.Nom_AAdhar = (dr["Nom_AAdhar"]).ToString();
                    kd.Nom_Pan = (dr["Nom_Pan"]).ToString();
                    kd.Nom_Reln = (dr["Nom_Reln"]).ToString();
                    kd.Nom_DOB = !Convert.IsDBNull(dr["Nom_DOB"]) ? Convert.ToDateTime(dr["Nom_DOB"]) : Convert.ToDateTime("01/01/0001");
                    kd.Modified_By = (dr["Modified_By"]).ToString();
                    kd.Modified_On = !Convert.IsDBNull(dr["Modified_On"]) ? Convert.ToDateTime(dr["Modified_On"]) : Convert.ToDateTime("01/01/0001");
                    kd.Created_By = (dr["Created_By"]).ToString();
                    kd.srl = !Convert.IsDBNull(dr["srl"]) ? Convert.ToInt32(dr["srl"]) : Convert.ToInt32("00");
                }
            }
            return kd;
        }

    }
}
