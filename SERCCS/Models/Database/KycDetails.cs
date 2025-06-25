using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class KycDetails
    {
        DBConfig config = new DBConfig();

        public String cont_no { get; set; }
        public String aadhar_no { get; set; }
        public String pan_no { get; set; }
        public String mobile_no { get; set; }
        public String email_id { get; set; }
        public Byte[] photo { get; set; }
        public Byte[] sign { get; set; }
        public DateTime create_date { get; set; }
        public String user_id { get; set; }
        public Byte[] photo_j { get; set; }
        public Byte[] sign_j { get; set; }
        public string Bank_Name { get; set; }
        public string ifsc { get; set; }
        public string ac_no { get; set; }
        public string md_of_op { get; set; }

        public string Nom_Name { get; set; }
        public string Nom_Reln { get; set; }
        public string Nom_AAdhar { get; set; }
        public string Nom_Pan { get; set; }
        public DateTime Nom_DOB { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public DateTime Modified_On { get; set; }
        public string member_id { get; set; }
        public string member_name { get; set; }
        public Int32 srl { get; set; }

        public Int32 Count { get; set; }
        public String getKycMobilenoByCont(string contno)
        {
            string sql = "Select mobile_no from KYC_DETAILS where CONT_NO='" + contno + "'";
            KycDetails kd = new KycDetails();
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                kd.mobile_no = dr["mobile_no"].ToString();

            }
            return kd.mobile_no;
        }
    }
}