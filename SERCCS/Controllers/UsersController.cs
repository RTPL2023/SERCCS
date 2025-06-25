using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Views;

namespace SERCCS.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult UsersMaster(UsersViewModel model)
        {
            UtilityController u = new UtilityController();
            model.brmst = u.getbranchmast();
            return View(model);
        }
    }
}
