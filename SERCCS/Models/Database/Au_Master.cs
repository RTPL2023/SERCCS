using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class Au_Master
    {
        DBConfig config = new DBConfig();
        public string au { get; set; }
        public string name { get; set; }
        public string created_by { get; set; }
        public DateTime create_date { get; set; }
        public string modified_by { get; set; }
        public DateTime modified_date { get; set; }

        public string saveAuMaster(Au_Master aum)
        {
            string msg = "";
            config.Insert("AU_Master", new Dictionary<string, object>()
            {
            { "au", aum.au },
            { "name", aum.name },
            { "created_by", aum.created_by },
            { "create_date", aum.create_date },
            });
            msg = "Saved Successfully";
            return msg;
        }

        public List<Au_Master> GetAuList()
        {
            string sql = "Select * from AU_Master order by Au";
            config.singleResult(sql);
            List<Au_Master> auml = new List<Au_Master>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    Au_Master aum = new Au_Master();
                    aum.au = Convert.ToString(dr["au"]);
                    aum.name = Convert.ToString(dr["name"]);
                    auml.Add(aum);
                }
            }
            return auml;
        }
    }
}
