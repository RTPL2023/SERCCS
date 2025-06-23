using FinPro.Models.Views;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SERCCS.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERCCS.Controllers
{
    public class MemberController : Controller
    {



        //[Authorize]
        [HttpGet]
        public IActionResult MemberMaster(MemberMasterViewModel mmv)
        {
            List<MemberMast> mml = new List<MemberMast>();
             UtilityController uc = new UtilityController();

            mmv.shtypes = uc.getshareType();
            mmv.paycategorys = uc.getpaycategoryMaster();
            mmv.memstatuss = uc.getMembershipStatus();
            mmv.relns = uc.getRelnMastDetails();
            mmv.castes = uc.getCasteMastDetails();
            mmv.relgns = uc.getReligionMastDetails();
          
            return View(mmv);

        }
        public JsonResult getDataByEmployeeId(MemberMasterViewModel model)
        {
            MemberMast mm = new MemberMast();
            var data =mm.GetRecByEmployeeId(model.employeeid,"GRC");


            return Json(data);
        }
    }
}
