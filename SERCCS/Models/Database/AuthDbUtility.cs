using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using SERCCS.Includes;
using SERCCS.Controllers;

namespace SERCCS.Models.Database
{
    public class AuthDbUtility
    {
        DBConfig config = new DBConfig();

        String sql;

        public Users getRole(String _UserName)
        {
            Users u = new Users();
            //String _role = String.Empty;
            sql = "SELECT * from Users WHERE User_Id = '" + _UserName + "' ";
            try
            {
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    u.user_role = config.dt.Rows[0]["USER_ROLE"].ToString();                                     
                    u.allocated_branch_id = config.dt.Rows[0]["allocated_branch_id"].ToString();                                     
                }
                return u;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }           
        }

        public int getLoggin(string userid, string password)
        {           
            int RetValue = 0;
            string encpwd = SERCCSUility.Encryptdata(password);
            try
            {                
                sql = "SELECT * FROM Users WHERE User_Id = '" + userid + "' and User_Password = '" + encpwd + "'";
                Users ld = new Users();
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    DataRow dr = (DataRow)config.dt.Rows[0];
                    if (Convert.ToInt32(dr["blocked"]) == 1)
                    {
                        RetValue = 2;
                    }
                    else
                    {
                        RetValue = 1;
                        config.Insert("login_details", new Dictionary<string, object>()
                        {
                        { "user_id", userid },
                        { "logged_in",0},
                        { "login_datetime", DateTime.Now },
                        });
                    }
                }
                else
                {
                    RetValue = 3;
                }
            }
            catch
            {
                RetValue = -1;
            }
            return Convert.ToInt32(RetValue);
        }

        public void setlogout(string _UserName)
        {
            sql = "SELECT * FROM login_details WHERE USER_ID = '" + _UserName + "' order by login_datetime";
            config.singleResult(sql);
            logindetails ld = new logindetails();
            if (config.dt.Rows.Count > 0)
            {
                DataRow dr = (DataRow)config.dt.Rows[config.dt.Rows.Count - 1];
                ld.login_datetime = Convert.ToDateTime(dr["login_datetime"]);
                config.Update("login_details", new Dictionary<string, object>()
                {
                { "logout_datetime", DateTime.Now},
                { "logged_in", 0 }
                }, new Dictionary<string, object>()
                {
                { "USER_ID", _UserName},
                { "login_datetime", ld.login_datetime}
                });
            }
        }

    }
}