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

        public String getRole(String _UserName)
        {
            String _role = String.Empty;
            sql = "SELECT User_Role from Users WHERE User_Id = '" + _UserName + "' ";
            try
            {
                config.singleResult(sql);
                if (config.dt.Rows.Count > 0)
                {
                    _role = config.dt.Rows[0]["USER_ROLE"].ToString();                                     
                }
                return _role;
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

    }
}