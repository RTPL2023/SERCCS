using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

namespace SERCCS.Models.Database
{
    public class BranchMast
    {
        DBConfig config = new DBConfig();
        //string sql;
        public string branch_id { get; set; }
        public string branch_name { get; set; }
        public string branch_add1 { get; set; }
        public string branch_add2 { get; set; }
        public string branch_phone { get; set; }
        public string branch_sname { get; set; }
        public string branch_defa { get; set; }
        public string msg { get; set; }

        public string CheckAndSaveBranchMaster(BranchMast bm)
        {
            string msg = "";
            string sql = "Select * from BRANCH_MAST where Branch_id='" + bm.branch_id + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                try
                {
                    config.Update("BRANCH_MAST", new Dictionary<String, object>()
                    {
                        { "branch_name",   bm.branch_name },
                        { "branch_add1",   bm.branch_add1 },
                        { "branch_add2",   bm.branch_add2 },
                        { "branch_phone",  bm.branch_phone },
                        { "branch_sname",  bm.branch_sname },
                        { "branch_defa",   bm.branch_defa },
                    }, new Dictionary<string, object>()
                    {
                        { "branch_id",     bm.branch_id },
                    });
                    msg = "Updated Successfully";
                }
                catch (Exception ex)
                {
                    msg = "Unable To Update";
                }               
            }
            else
            {
                try
                {
                    config.Insert("BRANCH_MAST", new Dictionary<string, object>()
                    {
                        { "branch_id",     bm.branch_id },
                        { "branch_name",   bm.branch_name },
                        { "branch_add1",   bm.branch_add1 },
                        { "branch_add2",   bm.branch_add2 },
                        { "branch_phone",  bm.branch_phone },
                        { "branch_sname",  bm.branch_sname },
                        { "branch_defa",   bm.branch_defa},
                    });
                    msg = "Saved Successfully";
                }
                catch (Exception ex)
                {
                    msg = "Unable To Save";
                }                
            }            
            return msg;
        }
        public List<BranchMast> getAllBranchList()
        {
            string sql = "Select * from BRANCH_MAST order by branch_id";
            config.singleResult(sql);
            List<BranchMast> bmpl = new List<BranchMast>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    BranchMast bm = new BranchMast();
                    bm.branch_id = Convert.ToString(dr["branch_id"]);
                    bm.branch_name = Convert.ToString(dr["branch_name"]);
                    bm.branch_add1 = Convert.ToString(dr["branch_add1"]);
                    bm.branch_add2 = Convert.ToString(dr["branch_add2"]);
                    bm.branch_phone = Convert.ToString(dr["branch_phone"]);
                    bm.branch_sname = Convert.ToString(dr["branch_sname"]);
                    bm.branch_defa = Convert.ToString(dr["branch_defa"]);
                    bmpl.Add(bm);
                }
            }
            return bmpl;
        }
        public List<BranchMast> getbranch()
        {
            string sql;
            sql = "select * from BRANCH_MAST ORDER BY branch_id";
            config.singleResult(sql);
            List<BranchMast> bml = new List<BranchMast>();

            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    BranchMast bm = new BranchMast();
                    bm.branch_id = dr["branch_id"].ToString();
                    bm.branch_name = dr["branch_name"].ToString();
                    bml.Add(bm);
                }
            }
            return bml;
        }
    }
}