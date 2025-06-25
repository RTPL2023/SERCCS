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
        public IActionResult AuMaster(AuMasterViewModel model)
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

        /***************************************Share Holder Type Master Start***************************************/
        [HttpGet]
        public IActionResult ShareTypeMaster(ShareTypeMasterViewModel model)
        {
            return View(model);
        }
        public JsonResult savedata(ShareTypeMasterViewModel model)
        {
            sh_holder_type_master dt = new sh_holder_type_master();
            string ans = dt.savedata(model);
            return Json(ans);
        }
        public JsonResult updatedata(ShareTypeMasterViewModel model)
        {
            sh_holder_type_master det = new sh_holder_type_master();
            det.description = model.description;
            det.code = model.code;
            string msg = det.updatedata(model);
            return Json(msg);
        }      
        public JsonResult GetAllDetails()
        {
            sh_holder_type_master det = new sh_holder_type_master();
            List<sh_holder_type_master> model = new List<sh_holder_type_master>();
            model = det.getlistofdemotable();
            string fd = string.Empty;
            int i = 1;
            if (model.Count > 0)
            {
                fd = "<tr><th>Code</th><th>Description</th></tr>";
                foreach (var a in model)
                {
                    fd += "<tr><td>" + a.code + "</td><td>" + a.description + "</td></tr>";
                }               
            }
            else
            {
                fd = "";
            }
            return Json(fd);
        }
        /***************************************Share Holder Type End***************************************/

        /***************************************Membership Status Mast Start***************************************/
        [HttpGet]
        public IActionResult MemberShipStatusMaster()
        {
            return View();
        }
        public JsonResult SaveMembershipStatus(MembershipStatusMasterViewModel svm)
        {
            MembershipStatusMast st = new MembershipStatusMast();
            string a = "";
            st.code = svm.code.ToUpper();
            st.description = svm.description.ToUpper();
            a = st.savedt(st);
            return Json(a);
        }
        public JsonResult GetAllStudentDetailsList()
        {
            MembershipStatusMast sdl = new MembershipStatusMast();
            List<MembershipStatusMast> std3 = new List<MembershipStatusMast>();
            std3 = sdl.GetAllStudentDetailsList();
            string sd = string.Empty;
            int i = 1;
            if (std3.Count > 0)
            {
                foreach (var c in std3)
                {
                    if (i == 1)
                    {
                        sd = "<tr><th>code</th><th>description</th></tr>";
                        sd = sd + "<tr><td>" + c.code + "</td><td>" + c.description + "</td></tr>";
                    }
                    else
                    {
                        sd = sd + "<tr><td>" + c.code + "</td><td>" + c.description + "</td></tr>";
                    }
                    i = i + 1;
                }
            }
            else
            {
                sd = "";
            }
            return Json(sd);
        }
        public JsonResult UpdateDetails(MembershipStatusMasterViewModel model)
        {
            MembershipStatusMast det = new MembershipStatusMast();
            det.code = model.code.ToUpper();
            det.description = model.description.ToUpper();
            string msg = det.updateBook(det);
            return Json(msg);
        }
        /***************************************Membership Status Mast End***************************************/

        /***************************************Pay Category Mast Start***************************************/
        [HttpGet]
        public IActionResult PayCategoryMaster(PayCategoryMastViewModel model)
        {
            return View(model);
        }
        public JsonResult SaveAllDetails(PayCategoryMastViewModel model)
        {
            Pay_Category_Master det = new Pay_Category_Master();

            det.code = model.code.ToUpper();
            det.description = model.description.ToUpper();






            string msg = det.SaveAllDetails(det);
            return Json(msg);
        }
        public JsonResult updateDetailsForPayCategory(PayCategoryMastViewModel model)
        {
            Pay_Category_Master det = new Pay_Category_Master();
            det.code = model.code.ToUpper();
            det.description = model.description.ToUpper();
            string msg = det.updatedata(det);
            return Json(msg);  
        }
        public JsonResult GetAllDetailsForPayCategory()
        {
            Pay_Category_Master bk = new Pay_Category_Master();
            List<Pay_Category_Master> bkl = new List<Pay_Category_Master>();
            bkl = bk.GetAllDetails();
            string bd = string.Empty;
            int i = 1;
            if (bkl.Count > 0)
            {
                foreach (var a in bkl)
                {
                    if (i == 1)
                    {
                        bd = "<tr><th>Code</th><th>Description</th></tr>";
                        bd = bd + "<tr><td>" + a.code + "</td><td>" + a.description + "</td></tr>";
                    }
                    else
                    {
                        bd = bd + "<tr><td>" + a.code + "</td><td>" + a.description + "</td></tr>";
                    }
                    i = i + 1;
                }
            }
            else
            {
                bd = "";
            }
            return Json(bd);

        }

        /***************************************Pay Category Mast End***************************************/

        /***************************************Branch Mast Start***************************************/
        [HttpGet]
        public IActionResult BranchMaster(BranchMasterViewModel model)
        {
            return View(model);
        }
        public JsonResult SaveBranchMaster(BranchMasterViewModel model)
        {
            BranchMast bm = new BranchMast();
            bm.branch_id = model.branch_id.ToUpper();
            bm.branch_name = model.branch_name.ToUpper();
            if(model.branch_add1 != null)
            {
                bm.branch_add1 = model.branch_add1.ToUpper();
            }
            if(model.branch_add2 != null)
            {
                bm.branch_add2 = model.branch_add2.ToUpper();
            }           
            bm.branch_phone = model.branch_phone;
            if(model.branch_sname != null)
            {
                bm.branch_sname = model.branch_sname.ToUpper();
            }
            if(model.branch_defa != null)
            {
                bm.branch_defa = model.branch_defa.ToUpper();
            }           
            model.msg = bm.CheckAndSaveBranchMaster(bm);
            return Json(model.msg);
        }
        public JsonResult GetBranchMasterDetails()
        {
            BranchMast bm = new BranchMast();
            List<BranchMast> bml = new List<BranchMast>();
            bml = bm.getAllBranchList();
            string fd = string.Empty;
            int i = 1;
            if (bml.Count > 0)
            {
                foreach (var a in bml)
                {
                    if (i == 1)
                    {
                        fd = "<tr><th>SR No</th><th>Branch Code</th><th>Branch Name</th><th>Address 1</th><th>Address 2</th><th>Branch Phone</th><th>Branch SName</th><th>Branch DEFA</th></tr>";
                        fd = fd + "<tr><td>" + Convert.ToString(i) + "</td><td>" + a.branch_id + "</td><td>" + a.branch_name + "</td><td>" + a.branch_add1 + "</td><td>" + a.branch_add2 + "</td><td>" + a.branch_phone + "</td><td>" + a.branch_sname + "</td><td>" + a.branch_defa + "</td></tr>";
                    }
                    else
                    {
                        fd = fd + "<tr><td>" + Convert.ToString(i) + "</td><td>" + a.branch_id + "</td><td>" + a.branch_name + "</td><td>" + a.branch_add1 + "</td><td>" + a.branch_add2 + "</td><td>" + a.branch_phone + "</td><td>" + a.branch_sname + "</td><td>" + a.branch_defa + "</td></tr>";
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

        /***************************************Branch Mast End***************************************/
    }
}
