using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SERCCS.Models.Database;

namespace SERCCS.Models.Views
{
    public class AccountOpeningViewModel
    {

        public IEnumerable<SelectListItem> Ac_Hd_DESC { get; set; }

        public IEnumerable<SelectListItem> Ac_Category_DESC { get; set; }

        public IEnumerable<SelectListItem> Md_Of_Op_DESC { get; set; }
        public string BranchId { get; set; }
        public string AcHd { get; set; }
        public string AcNo { get; set; }
        public string ContNo { get; set; }
        public string OpenDate { get; set; }
        public string MemberId_introducer1 { get; set; }
        public string MemberId_introducer2 { get; set; }
        public string AcName { get; set; }
        public string AcAdd1 { get; set; }
        public string AcAdd2 { get; set; }
        public string AcState { get; set; }
        public string AcCity { get; set; }
        public string AcDist { get; set; }
        public string AcPin { get; set; }
        public string SplStatus { get; set; }
        public string DdAgentCode { get; set; }
        public string AcRegdDate { get; set; }
        public string ChqFacility { get; set; }
        public string OprnMode { get; set; }
        public string IsMinor { get; set; }
        public string MinorDob { get; set; }
        public string MinorAdultDt { get; set; }
        public string TdDd { get; set; }
        public string TdMm { get; set; }
        public string TdYy { get; set; }
        public string TdFaceVal { get; set; }
        public string TdInstIntr { get; set; }
        public string TdIntRate { get; set; }
        public string TdMatDate { get; set; }
        public string TdMatVal { get; set; }
        public string TdIntfrqMm { get; set; }
        public string TdCertNo { get; set; }
        public string TdCertIssued { get; set; }
        public string TdPledged { get; set; }
        public string TdPledgeAcHd { get; set; }
        public string TdPledgeLoanId { get; set; }
        public string PeriodicInt { get; set; }
        public string TdRenewDate { get; set; }
        public string TdRenewFlag { get; set; }
        public string AcClosed { get; set; }
        public string AcClosDate { get; set; }
        public string TdClosIntPay { get; set; }
        public string TdClosRate { get; set; }
        public string TdClosPaymode { get; set; }
        public string Remarks { get; set; }
        public string BookNo { get; set; }
        public string TNo { get; set; }
        public string DeptCd { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string ComputerName { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string McomputerName { get; set; }
        public string TxtFd { get; set; }
        public string StatusBar1 { get; set; }
        public string Tag { get; set; }
        public string srl { get; set; }
        public string CustSrl { get; set; }
        public string Srl1 { get; set; }
        public string MemberId1 { get; set; }
        public string MemberName1 { get; set; }
        public string GuardianName1 { get; set; }
        public string Relation1 { get; set; }
        public string Sex1 { get; set; }
        public string Occupation1 { get; set; }
        public string Sign1 { get; set; }
        public string Lti1 { get; set; }
        public string PanNo1 { get; set; }
        public string Srl2 { get; set; }
        public string MemberId2 { get; set; }
        public string MemberName2 { get; set; }
        public string GuardianName2 { get; set; }
        public string Relation2 { get; set; }
        public string Sex2 { get; set; }
        public string Occupation2 { get; set; }
        public string Sign2 { get; set; }
        public string Lti2 { get; set; }
        public string PanNo2 { get; set; }
        public string mode { get; set; }
        public string CustomerId1 { get; set; }
        public string NomId1 { get; set; }
        public string NameofNominee1 { get; set; }
        public string CustomerId2 { get; set; }
        public string NomId2 { get; set; }
        public string NameofNominee2 { get; set; }
        public string IntroducerType1 { get; set; }
        public string DepositAC1 { get; set; }
        public string ACNo1 { get; set; }
        public string MemNo1 { get; set; }
        public string srlintroducer1 { get; set; }
        public string srlintroducer2 { get; set; }
        public string NameofIntroducer1 { get; set; }
        public string Witness1 { get; set; }
        public string IntroducerType2 { get; set; }
        public string DepositAC2 { get; set; }
        public string ACNo2 { get; set; }
        public string MemNo2 { get; set; }
        public string NameofIntroducer2 { get; set; }
        public string NomDob { get; set; }
        public string NomName { get; set; }
        public string NomReln { get; set; }
        public string NomPan { get; set; }
        public string NomAadhar { get; set; }
        public string NomSrl1 { get; set; }
        public string NomSrl2 { get; set; }

        public string Witness2 { get; set; }
        public string msgbox { get; set; }


    }
}
