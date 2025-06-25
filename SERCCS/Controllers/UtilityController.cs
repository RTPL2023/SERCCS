using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERCCS.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SERCCS.Models.Views;

namespace SERCCS.Controllers
{
    public class UtilityController : Controller
    {
        public IEnumerable<SelectListItem> getshareType()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            MemtypeMast mtm = new MemtypeMast();
            m.shtypes = mtm.getshareType().ToList().Select(x => new SelectListItem
            {
                Value = x.code.ToString(),
                Text = x.description.ToString()
            }); ;

            return m.shtypes;
        }
        public IEnumerable<SelectListItem> getpaycategoryMaster()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            MemtypeMast mtm = new MemtypeMast();
            m.paycategorys = mtm.getpayCategoryMaster().ToList().Select(x => new SelectListItem
            {
                Value = x.code.ToString(),
                Text = x.description.ToString()
            }); ;

            return m.paycategorys;
        }      
        public IEnumerable<SelectListItem> getMembershipStatus()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            MemtypeMast mtm = new MemtypeMast();
            m.memstatuss = mtm.getmembershipStatus().ToList().Select(x => new SelectListItem
            {
                Value = x.code.ToString(),
                Text = x.description.ToString()
            }); ;

            return m.memstatuss;
        }
        public IEnumerable<SelectListItem> getRelnMastDetails()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            RelnMast rm = new RelnMast();

            m.relns = rm.getRelnMast().ToList().Select(x => new SelectListItem
            {
                Value = x.reln_id.ToString(),
                Text = x.reln_name.ToString()
            }); ;

            return m.relns;
        }
        public IEnumerable<SelectListItem> getCasteMastDetails()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            CasteMast cm = new CasteMast();
            m.castes = cm.getCasteMast().ToList().Select(x => new SelectListItem
            {
                Value = x.caste_id.ToString(),
                Text = x.caste_name.ToString()
            }); ;

            return m.castes;

        }
        public IEnumerable<SelectListItem> getReligionMastDetails()
        {
            MemberMasterViewModel m = new MemberMasterViewModel();
            ReligionMast rm = new ReligionMast();

            m.relgns = rm.getReligionMast().ToList().Select(x => new SelectListItem
            {
                Value = x.relgn_id.ToString(),
                Text = x.relgn_name.ToString()
            }); ;

            return m.relgns;
        }
        public IEnumerable<SelectListItem> getbranchmast()
        {
            UsersViewModel uvm = new UsersViewModel();
            BranchMast mtm = new BranchMast();
            uvm.brmst = mtm.getbranch().ToList().Select(x => new SelectListItem
            {
                Value = x.branch_id.ToString(),
                Text = x.branch_name.ToString()
            }); ;
            return uvm.brmst;
        }

    }
}
