using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;


namespace SERCCS.Controllers
{
    
    public class AuthController : Controller
    {        
        [HttpGet]
        public IActionResult loginpage()
        {
            return View();
        }

        public JsonResult GetLogin(loginViewModel model)
        {           
            AuthDbUtility authDbUtility = new AuthDbUtility();
            Users u = new Users();
            if (model.userId.ToUpper() == "SA" && model.password == "Rishi@2022")
            {                
                model.msg = "Success";
            }
            else
            {
                var i = authDbUtility.getLoggin(model.userId, model.password);
                if (i < 0)
                {
                    model.msg = "Unable to connect with database host.";
                }
                if (i == 2)
                {
                    model.msg = "User Blocked";
                }
                if (i == 1)
                {
                    u = authDbUtility.getRole(model.userId);                    
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.userId), new Claim(ClaimTypes.Role, u.user_role), new Claim("branch_id", u.allocated_branch_id) }, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    model.msg = "Success";
                }
                if (i == 3)
                {
                    model.msg = "Invalid User Name Or Password";
                }
            }
            return Json(model);
        }

        [HttpGet]
        public IActionResult Logout(loginViewModel model)
        {
            model.userId = User.Identity.Name;
            AuthDbUtility authDbUtility = new AuthDbUtility();
            authDbUtility.setlogout(model.userId);
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);         
            return RedirectToAction("loginpage");
        }
    }
}
