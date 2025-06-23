using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Database;
using System.Data;
using SERCCS.Includes;

namespace SERCCS.Models.Database
{
    public class MembershipStatusMast
    {
        DBConfig config = new DBConfig();
        public string code { get; set; }
        public string description { get; set; }
        public string msg { get; set; }


        public string savedt(MembershipStatusMast st)
        {
            string sql = "SELECT * FROM MEMBERSHIP_STATUS_MASTER WHERE code = '" + st.code + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                return "Same Code Already Exists";
            }
            else
            {
                config.Insert("MEMBERSHIP_STATUS_MASTER", new Dictionary<string, object>()
                {
                { "code",  st.code },
                { "description", st.description },
                });
                string msg = "Saved";
                return (msg);
            }
        }
        public List<MembershipStatusMast> GetAllStudentDetailsList()
        {
            string sql = "Select * from MEMBERSHIP_STATUS_MASTER order by code";
            config.singleResult(sql);
            List<MembershipStatusMast> stdl = new List<MembershipStatusMast>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    MembershipStatusMast sdl = new MembershipStatusMast();

                    sdl.code = Convert.ToString(dr["code"]);
                    sdl.description = Convert.ToString(dr["description"]);
                    //std.result = !Convert.IsDBNull(dr["result"]) ? Convert.ToInt32(dr["result"]) : 0;
                    stdl.Add(sdl);
                }
            }
            return stdl;
        }
        public string updateBook(MembershipStatusMast det)
        {

            string sql = "Select * from MEMBERSHIP_STATUS_MASTER where code = '" + det.code + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                config.Update("MEMBERSHIP_STATUS_MASTER", new Dictionary<String, object>()
                {
                { "description",  det.description},
                }, new Dictionary<string, object>()
                {
                { "code",  det.code },
                });
                det.msg = "Updated Successfuly";
            }
            return det.msg;
        }
    }
}
