using SERCCS.Includes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Database;

namespace SERCCS.Models.Database
{
    public class Pay_Category_Master
    {
        DBConfig config = new DBConfig();      
        public string msg;
        public string code { get; set; }
        public string description { get; set; }

        public string SaveAllDetails(Pay_Category_Master det)
        {
            string msg = "";
            try
            {
                string sql = "SELECT * FROM PAY_CATEGORY_MASTER WHERE code = '" + det.code + "'";
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    msg= "Same Code Already Exists";
                }
                else
                {                   
                    config.Insert("PAY_CATEGORY_MASTER", new Dictionary<string, object>()
                    {
                    {"code", det.code },
                    {"description", det.description }
                    });
                    msg = "Saved Successfully";
                }
            }
            catch(Exception ex)
            {
                msg = "Error Occured";
            }
            return msg;                          
        }
        public string updatedata(Pay_Category_Master det)
        {
            string msg = "";
            try
            {
                string sql = "Select * from PAY_CATEGORY_MASTER where code = '" + det.code + "'";
                config.singleResult(sql); ;
                if (config.dt.Rows.Count > 0)
                {
                    config.Update("PAY_CATEGORY_MASTER", new Dictionary<String, object>()
                    {
                    { "description",  det.description},
                    }, new Dictionary<string, object>()
                    {
                    { "code",  det.code },
                    });
                    msg = "Updated Successfuly";
                }
                else
                {
                    msg = "Invalid Data";
                }
            }
            catch(Exception ex)
            {
                msg = "Unable To Update";
            }
            return msg;
        }
        public List<Pay_Category_Master> GetAllDetails()
        {
            string sql = "Select * from PAY_CATEGORY_MASTER order by code";
            config.singleResult(sql);
            List<Pay_Category_Master> bkl = new List<Pay_Category_Master>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    Pay_Category_Master bd = new Pay_Category_Master();
                    bd.code = Convert.ToString(dr["code"]);
                    bd.description = Convert.ToString(dr["description"]);                   
                    bkl.Add(bd);
                }
            }
            return bkl;
        }
    }
}
