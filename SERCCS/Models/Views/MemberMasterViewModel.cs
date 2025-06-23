using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinPro.Models.Views
{
    public class MemberMasterViewModel
    {
        
        public string branchid { get; set; }
       
        public string retirage { get; set; }
        public string buno { get; set; }
       
      
        public string employeeid { get; set; } //control no
        public string memberdate { get; set; }
        public string membertype { get; set; }
        public string paycategory { get; set; }
        public string shtype { get; set; }
      
      
        public string membername { get; set; }
        
        public string grdnname { get; set; }
        public string relnid { get; set; }
        public string mailhno { get; set; }
        public string mailadd1 { get; set; }
        public string mailadd2 { get; set; }
        public string mailcity { get; set; }
        public string maildist { get; set; }
        public string mailstate { get; set; }
        public string mailpin { get; set; }
        public string permhno { get; set; }
        public string permadd1 { get; set; }
        public string permadd2 { get; set; }
        public string permcity { get; set; }
        public string permdist { get; set; }
        public string permstate { get; set; }
        public string permpin { get; set; }
       
        public string birthdate { get; set; }
        public string casteid { get; set; }
        public string sex { get; set; }
        public string relgnid { get; set; }
        public string occupid { get; set; }
        public bool married { get; set; }
        public bool iflti { get; set; }
        public string servstatus { get; set; }
        public string deptcd { get; set; }
        public string desigcd { get; set; }
        public string dateofjoining { get; set; }
        public string wd50dt { get; set; }
        public string dateofretirement { get; set; }
        public string dateofremember { get; set; }
        public string panno { get; set; }
      
        public string idmark { get; set; }
        public string remarks { get; set; }
        public bool isdead { get; set; }
        public string expirydate { get; set; }
        public bool memberclosed { get; set; }
        public string memberclosdt { get; set; }
        public string tfbuffer { get; set; }
        public bool memberretired { get; set; }
        public bool membertransfered { get; set; }
        public string sbamt { get; set; }
        public string cmtdno { get; set; }
        public string cmtdamt { get; set; }
        public string createdby { get; set; }
        public string createon { get; set; }
        public string computername { get; set; }
        public string modifiedby { get; set; }
        public string modifiedon { get; set; }
        public string mcomputername { get; set; }
        public string c11 { get; set; }
        public string ipass { get; set; }
        public string nomname { get; set; }
        public string nomadd1 { get; set; }
        public string nomadd2 { get; set; }
        public string nomcity { get; set; }
        public string nombirthdate { get; set; }
        public string nomdist { get; set; }
        public string nomstate { get; set; }
        public string nompin { get; set; }
        public string nomrelnid { get; set; }
        public string society { get; set; }
        public string label58 { get; set; }
        public string message { get; set; }
        public string statusbar1 { get; set; }
        public string txtgrid { get; set; }
        public string branchdefa { get; set; }



        //************************Member Nominee*********************************

        public string nombirthdt { get; set; }
       
        public String nomhno { get; set; }
        public String nomsrl { get; set; }
      
        public string createdon { get; set; }
       public string slno { get; set; }

        //***************Member Introducer**************************************

       
        public string intrsrl1 { get; set; }
        public String intrmemberid1 { get; set; }
        public String intrname1 { get; set; }
        public string intrsrl2 { get; set; }
        public String intrmemberid2 { get; set; }
        public String intrname2 { get; set; }
        public String memstatus { get; set; }

        //public MemtypeMast CurrentMemType { get; set; }
        public IEnumerable<SelectListItem> paycategorys { get; set; }
        public IEnumerable<SelectListItem> memstatuss { get; set; }
        public IEnumerable<SelectListItem> relns { get; set; }
        public IEnumerable<SelectListItem> castes { get; set; }
        public IEnumerable<SelectListItem> relgns { get; set; }
        public IEnumerable<SelectListItem> occups { get; set; }
        public IEnumerable<SelectListItem> shtypes { get; set; }
        //public BranchMast currentBranchDefa { get; set; }
        //public IEnumerable<SelectListItem> BranchDefas { get; set; }
        //public MemcategoryMast currentMemCategory { get; set; }
        //public IEnumerable<SelectListItem> MemCategorys { get; set; }
        //public EmployerMast currentEmployerCd { get; set; }
        //public IEnumerable<SelectListItem> EmployerCds { get; set; }
        //public EmployerBranchMast currentEmployerBrName { get; set; }
        //public IEnumerable<SelectListItem> EmployerBrNames { get; set; }
        //public CasteMast currentCasteMast { get; set; }
        //public IEnumerable<SelectListItem> Castes { get; set; }
        //public ReligionMast currentRelgnMast { get; set; }
        //public IEnumerable<SelectListItem> Relgns { get; set; }
        //public OccupMast currentOccupMast { get; set; }
        //public IEnumerable<SelectListItem> Occups { get; set; }
        //public DeptMast currentDeptMast { get; set; }
        //public IEnumerable<SelectListItem> Depts { get; set; }
        //public DesigMast currentDesigMast { get; set; }
        //public IEnumerable<SelectListItem> Desigs { get; set; }
        //public RelnMast currentRelnName { get; set; }
        //public IEnumerable<SelectListItem> Relns { get; set; }

        //public ServStatusMast currentServStatus { get; set; }
        public IEnumerable<SelectListItem> servstatuss { get; set; }
        



        public String mode { get; set; }

    }
}
