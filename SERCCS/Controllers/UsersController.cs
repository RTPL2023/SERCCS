using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using SERCCS.Includes;
using Microsoft.AspNetCore.Authorization;

namespace SERCCS.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        /***************************************Users Master Start***************************************/
        [HttpGet]
        public IActionResult UsersMaster(UsersViewModel model)
        {
            UtilityController u = new UtilityController();
            model.brmst = u.getbranchmast();
            return View(model);
        }
        public JsonResult SaveUserMaster(UsersViewModel model)
        {
            Users u = new Users();
            u.allocated_branch_id = model.allocated_branch_id.ToUpper();
            u.user_id = model.user_id.ToUpper();
            u.user_name = model.user_name.ToUpper();
            u.user_password = SERCCSUility.Encryptdata(model.user_password);            
            u.email_id = model.email_id;
            u.user_role = model.user_role;            
            u.created_by = User.Identity.Name.ToUpper();            
            u.created_on = DateTime.Now;            
            model.msg = u.SaveDetails(u);
            return Json(model.msg);
        }
        public JsonResult GetAllUsersDetails()
        {
            Users u = new Users();
            List<Users> ul = new List<Users>();
            ul = u.getList();
            string fd = string.Empty;
            int i = 1;
            if (ul.Count > 0)
            {
                foreach (var a in ul)
                {
                    string blk = "";                   
                    if(a.blocked == 1)
                    {
                        blk = "YES";
                    }
                    else
                    {
                        blk = "NO";
                    }
                    string psw = SERCCSUility.Decryptdata(a.user_password); ;
                    if (i == 1)
                    {
                        fd = "<tr><th>SR No</th><th>Branch</th><th>User Role</th><th>UserId</th><th>User Name</th><th style =\"display:none\">Password</th><th>EmailId</th><th>Blocked</th></tr>";
                        fd = fd + "<tr><td>" + Convert.ToString(i) + "</td><td>" + a.allocated_branch_id + "</td><td>" + a.user_role + "</td><td>" + a.user_id + "</td><td>" + a.user_name + "</td><td style =\"display:none\">" + psw + "</td><td>" + a.email_id + "</td><td>" + blk+ "</td></tr>";
                    }
                    else
                    {
                        fd = fd + "<tr><td>" + Convert.ToString(i) + "</td><td>" + a.allocated_branch_id + "</td><td>" + a.user_role + "</td><td>" + a.user_id + "</td><td>" + a.user_name + "</td><td style =\"display:none\">" + psw + "</td><td>" + a.email_id + "</td><td>" + blk + "</td></tr>";
                    }
                    i = i + 1;
                }
            }
            else
            {
                fd = "";
            }
            return Json(fd);
        }
        public JsonResult UpdateUserMaster(UsersViewModel model)
        {
            Users u = new Users();
            u.allocated_branch_id = model.allocated_branch_id.ToUpper();
            u.user_id = model.user_id.ToUpper();
            u.user_name = model.user_name.ToUpper();
            u.user_password = SERCCSUility.Encryptdata(model.user_password);
            u.email_id = model.email_id;
            u.user_role = model.user_role;
            if(model.blocked == true)
            {
                u.blocked = 1;
            }
            else
            {
                u.blocked = 0;
            }
            u.modified_by = User.Identity.Name.ToUpper();
            u.modified_on = DateTime.Now;
            model.msg = u.UpdateDetails(u);
            return Json(model.msg);
        }
        public JsonResult GetUserDetailsByUserId(UsersViewModel model)
        {
            Users u = new Users();
            u = u.getdetails(model.user_id.ToUpper());
            if(u.msg != "No Data Found")
            {
                model.allocated_branch_id = u.allocated_branch_id;
                model.user_name = u.user_name;
                model.user_password = SERCCSUility.Decryptdata(u.user_password);
                model.email_id = u.email_id;
                model.user_role = u.user_role;
                if (u.blocked == 1)
                {
                    model.blocked = true;
                }
                else
                {
                    model.blocked = false;
                }
            }
            else
            {
                model.msg = u.msg;
            }           
            return Json(model);
        }

        /***************************************Users Master End***************************************/
    }
}
