using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERCCS.Includes;
using System.Data;

//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace SERCCS.Models.Database
{
    public class Users
    {
        DBConfig config = new DBConfig();
        public Int32 Id {get; set;} 
        public string allocated_branch_id {get; set;} 
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_role { get; set; }            
        public string email_id { get; set; }            
        public string created_by { get; set; }            
        public string modified_by { get; set; }            
        public DateTime created_on { get; set; }            
        public DateTime modified_on { get; set; }            
        public int blocked { get; set; }
        public string msg { get; set; }

        public string SaveDetails(Users u)
        {
            string msg = "";
            string sql = "Select * from Users where User_Id='" + u.user_id + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[0];
                u.allocated_branch_id = Convert.ToString(dr["allocated_branch_id"]);
                msg = "Same UserId Already Exists Under " + u.allocated_branch_id + " Branch";
            }
            else
            {
                try
                {
                    config.Insert("Users", new Dictionary<string, object>()
                    {
                        { "allocated_branch_id",     u.allocated_branch_id },
                        { "user_id",   u.user_id },
                        { "user_name",   u.user_name },
                        { "user_role",   u.user_role },
                        { "user_password",  u.user_password },
                        { "email_id",  u.email_id },                       
                        { "created_by",   u.created_by},
                        { "created_on",   u.created_on},
                    });
                    msg = "Saved Successfully";
                }
                catch (Exception ex)
                {
                    msg = "Unable To Update";
                }
            }
            return msg;
        }
        public List<Users> getList()
        {
            string sql = "Select * from Users order by created_on desc";
            config.singleResult(sql);
            List<Users> uml = new List<Users>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    Users u = new Users();
                    u.allocated_branch_id = Convert.ToString(dr["allocated_branch_id"]);
                    u.user_id = Convert.ToString(dr["user_id"]);
                    u.user_name = Convert.ToString(dr["user_name"]);
                    u.user_password = Convert.ToString(dr["user_password"]);
                    u.user_role = Convert.ToString(dr["user_role"]);
                    u.email_id = Convert.ToString(dr["email_id"]);
                    u.blocked = Convert.ToInt32(dr["Blocked"]);
                    uml.Add(u);
                }
            }
            return uml;
        }
        public string UpdateDetails(Users u)
        {
            string msg = "";
            try
            {
                config.Update("Users", new Dictionary<String, object>()
                {
                    { "allocated_branch_id",     u.allocated_branch_id },                    
                    { "user_name",   u.user_name },
                    { "user_role",   u.user_role },
                    { "user_password",  u.user_password },
                    { "email_id",  u.email_id },
                    { "Blocked",  u.blocked },
                    { "modified_by",   u.modified_by},
                    { "modified_on",   u.modified_on},
                }, new Dictionary<string, object>()
                {
                { "user_id",   u.user_id },
                });
                msg = "Updated Successfuly";
            }
            catch (Exception ex)
            {
                msg = "Unable To Update";
            }
            return msg;
        }
        public Users getdetails(string u_id)
        {
            Users u = new Users();
            string sql = "Select * from Users where user_id = '" + u_id + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    u.allocated_branch_id = Convert.ToString(dr["allocated_branch_id"]);
                    u.user_id = Convert.ToString(dr["user_id"]);
                    u.user_name = Convert.ToString(dr["user_name"]);
                    u.user_password = Convert.ToString(dr["user_password"]);
                    u.user_role = Convert.ToString(dr["user_role"]);
                    u.email_id = Convert.ToString(dr["email_id"]);
                    u.blocked = Convert.ToInt32(dr["Blocked"]);
                }
            }
            else
            {
                u.msg = "No Data Found";
            }
            return u;
        }

    }
}