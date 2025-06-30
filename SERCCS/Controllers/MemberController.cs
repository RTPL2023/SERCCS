using SERCCS.Models.Views;
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



        [Authorize]
        [HttpGet]
        public IActionResult MemberMaster(MemberMasterViewModel mmv)
        {
            List<MemberMast> mml = new List<MemberMast>();
             UtilityController uc = new UtilityController();
            var user = User;
            mmv.branchid = user.FindFirst("branch_id")?.Value;
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
        public JsonResult GetRetirementDate(string birthdate,int retirage)
        {

            string retirementdt = Convert.ToDateTime(Convert.ToDateTime(birthdate).ToString("dd/MM/yyyy")).AddDays(retirage * 365 + (retirage/4)).ToString("dd/MM/yyyy").Replace("-", "/");
            int year = Convert.ToDateTime(retirementdt).Year;
            int month = Convert.ToDateTime(retirementdt).Month;
            int day = DateTime.DaysInMonth(year, month);
            string mm = "";
            if (Convert.ToString(month).Length < 2)
            {
                mm = "0" + Convert.ToString(month);
            }
            else
            {
                mm = Convert.ToString(month);
            }
            retirementdt = Convert.ToString(day) + "/" + mm + "/" + Convert.ToString(year);
            return Json(retirementdt);
        }
        public JsonResult SaveMemberDetails(MemberMasterViewModel model)
        {
            MemberMast det = new MemberMast();

            det.employee_id = model.employeeid;
            det.branch_id = model.branchid;
            det.ra = Convert.ToInt32(model.retirage);
            det.buno = model.buno;
            det.status = model.memstatus;
            det.member_date = Convert.ToDateTime(model.memberdate);
            det.payment_mode = model.paycategory;
            det.member_type = model.shtype;
            det.member_name = model.membername.ToUpper();
            det.grdn_name = model.grdnname.ToUpper();
            det.reln_id = model.relnid;
            det.mail_hno = model.mailhno;
            det.mail_add1 = model.mailadd1;
            det.mail_add2 = model.mailadd2;
            det.mail_city = model.mailcity;
            det.mail_state = model.mailstate;
            det.mail_dist = model.maildist;
            det.mail_pin = model.mailpin;
            det.perm_hno = model.permhno;
            det.perm_add1 = model.permadd1;
            det.perm_add2 = model.permadd2;
            det.perm_city = model.permcity;
            det.perm_dist = model.permdist;
            det.perm_state = model.permstate;
            det.perm_pin = model.permpin;
            det.birth_date = Convert.ToDateTime(model.birthdate);
            det.caste_id = model.casteid;
            det.sex = model.sex;
            det.relgn_id = model.relgnid;
            // det.married=Convert.ToInt32(model.married);
            // det.if_lti=Convert.ToInt32(model.iflti);
            det.date_of_joining = Convert.ToDateTime(model.dateofjoining);
            det.date_of_retirement = Convert.ToDateTime(model.dateofretirement);
            det.date_of_remember = Convert.ToDateTime(model.dateofremember);
            det.id_mark = model.idmark;
            // det.is_dead=Convert.ToString( model.isdead);
            // det.strexpiry_date = Convert.ToString(model.expirydate);
            // det.member_retired=Convert.ToString( model.memberretired);
            // det.member_transfered =Convert.ToString( model.membertransfered);
            det.do50pwcm = Convert.ToDateTime(model.wd50dt);
            if (model.sex == "MALE")
            {
                det.sex = "M";
            }
            else if (model.sex == "FEMALE")
            {
                det.sex = "F";
            }
            else
            {
                det.sex = "O";
            }
            if (model.memberretired == true)
            {
                det.member_retired = "Y";
            }
            else
            {
                det.member_retired = "";
            }
            if (model.membertransfered == true)
            {
                det.member_transfered = "Y";
            }
            else
            {
                det.member_transfered = "";
            }

            if (model.memberclosed == true)
            {
                det.member_closed = "C";
                det.member_clos_dt = Convert.ToDateTime(model.memberclosdt);
            }
            else
            {

                det.member_closed = "";
                det.member_clos_dt = null;

            }
            if (model.isdead == true)
            {
                det.is_dead = "D";
                det.exp_date = Convert.ToDateTime(model.expirydate);
            }
            else
            {
                det.is_dead = "A";
                det.exp_date = null;

            }
            if (model.married == true)
            {
                det.married = 1;
            }
            else
            {
                det.married = 0;
            }
            if (model.iflti == true)
            {
                det.if_lti = 1;
            }
            else
            {
                det.if_lti = 0;
            }

            string msg = det.saveupdateMember(det);
            return Json(msg);
        }

        
    }
}
