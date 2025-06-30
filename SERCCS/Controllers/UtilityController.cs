using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERCCS.Models.Database;
using SERCCS.Models.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;



namespace SERCCS.Controllers
{
    [Authorize]
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

        public IEnumerable<SelectListItem> getAcHdDescForSB()
        {
            AccountOpeningViewModel m = new AccountOpeningViewModel();
            DepTypeMast dtm = new DepTypeMast();

            m.ac_hd_desc = dtm.getAchdfromDeptypeMastForSB().ToList().Select(x => new SelectListItem
            {
                Value = x.ac_hd.ToString(),
                Text = x.dep_desc.ToString()
            }); ;

            return m.ac_hd_desc;
        }
        public IEnumerable<SelectListItem> getAcHdDesc()
        {
            AccountOpeningViewModel m = new AccountOpeningViewModel();
            DepTypeMast dtm = new DepTypeMast();

            m.ac_hd_desc = dtm.getAchdfromDeptypeMast().ToList().Select(x => new SelectListItem
            {
                Value = x.ac_hd.ToString(),
                Text = x.dep_desc.ToString()
            }); ;

            return m.ac_hd_desc;
        }

        public IEnumerable<SelectListItem> getStatusDesc()
        {
            AccountOpeningViewModel m = new AccountOpeningViewModel();
            DepositSplStatMast dssm = new DepositSplStatMast();

            m.ac_category_desc = dssm.getStatusDescfromDepositSplStatMast().ToList().Select(x => new SelectListItem
            {
                Value = x.spl_status.ToString(),
                Text = x.status_desc.ToString()
            }); ;

            return m.ac_category_desc;
        }

        public IEnumerable<SelectListItem> getOprnMode()
        {
            AccountOpeningViewModel m = new AccountOpeningViewModel();
            DepositOprnMast dom = new DepositOprnMast();

            m.md_of_op_desc = dom.getOprnModeFromDepositOprnMast().ToList().Select(x => new SelectListItem
            {
                Value = x.oprn_mode.ToString(),
                Text = x.oprn_desc.ToString()
            }); ;

            return m.md_of_op_desc;
        }
        public MemoryStream DownloadTextFiles(string filename, string uploadPath)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), uploadPath, filename);
            var memory = new MemoryStream();
            if (System.IO.File.Exists(path))
            {
                var net = new System.Net.WebClient();
                var data = net.DownloadData(path);
                var content = new System.IO.MemoryStream(data);
                memory = content;
            }
            memory.Position = 0;
            return memory;
        }
    }
}
