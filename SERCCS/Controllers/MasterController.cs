using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Views;
using SERCCS.Models.Database;

namespace SERCCS.Controllers
{
    public class MasterController : Controller
    {
        /***************************************AU Master Start***************************************/
        [HttpGet]
        public ActionResult AuMaster(AuMasterViewModel model)
        {
            return View(model);
        }

        public JsonResult SaveAuMaster(AuMasterViewModel model)
        {
            Au_Master aum = new Au_Master();
            aum.au = model.au;
            aum.name = model.name.ToUpper();
            //aum.created_by = User.Identity.Name.ToUpper();
            aum.created_by = "RISHI";
            aum.create_date = DateTime.Now;
            model.msg = aum.saveAuMaster(aum);
            return Json(model.msg);
        }

        public JsonResult GeList()
        {
            Au_Master amu = new Au_Master();
            List<Au_Master> auml = new List<Au_Master>();
            auml = amu.GetAuList();
            string fd = "";
            if(auml.Count > 0)
            {
                fd = "<tr><th>AU</th><th>Name</th></tr>";
                foreach(var a in auml)
                {
                    fd = fd + "<tr><td>" + a.au + "</td><td>" + a.name + "</td></tr>";
                }
            }
            return Json(fd);
        }

        /***************************************AU Master End***************************************/

    }
}
