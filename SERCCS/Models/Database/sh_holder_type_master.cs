using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Includes;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using System.Data;

namespace SERCCS.Models.Database
{

    public class sh_holder_type_master
    {
        DBConfig config = new DBConfig();
        public string code { get; set; }
        public string description { get; set; }
        public string msg { get; set; }

        public string savedata(ShareTypeMasterViewModel model)
        {
            string sql = "";
            sql = "select * from sh_type_master where code ='" + model.code.ToUpper() + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                return "same code already exists";
            }
            else
            {
                sql = "";
                sql+= "insert into sh_type_master (code,description) values ( '" + model.code.ToUpper()+ "' , '"+model.description.ToUpper()+"' )";
                config.Execute_Query(sql);
                return "saved successfully";
            }         
        }

        public string updatedata(ShareTypeMasterViewModel model)
        {
            string sql = "update sh_type_master set  description = '" + model.description.ToUpper() + "' where code = '"+ model.code.ToUpper() +"' ";
            config.Execute_Query(sql);
            model.msg = "updated ";
            return model.msg;
        }


        public List<sh_holder_type_master> getlistofdemotable()
        {
            string sql = "select * from sh_type_master";
            config.singleResult(sql);
            List<sh_holder_type_master> model = new List<sh_holder_type_master>();
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    sh_holder_type_master dcd = new sh_holder_type_master();
                    dcd.code = Convert.ToString(dr["code"]);
                    dcd.description = Convert.ToString(dr["description"]);                  
                    model.Add(dcd);
                }
            }
            return model;
        }

        public sh_holder_type_master getdetails(string code)
        {
            sh_holder_type_master dcd = new sh_holder_type_master();
            string sql = "Select * from sh_holder_type_master_db where code = '" + code + "'";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                foreach (DataRow dr in config.dt.Rows)
                {
                    dcd.code = Convert.ToString(dr["code"]);
                    dcd.description = Convert.ToString(dr["description"]);                  
                }
            }
            else
            {
                dcd.msg = "Not Found";
            }
            return dcd;
        }
    }
}