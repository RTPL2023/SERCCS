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

        public IEnumerable<SelectListItem> ac_hd_desc { get; set; }

        public IEnumerable<SelectListItem> ac_category_desc { get; set; }

        public IEnumerable<SelectListItem> md_of_op_desc { get; set; }
        public string branchid { get; set; }
        public string achd { get; set; }
        public string acno { get; set; }
        public string contno { get; set; }
        public string opendate { get; set; }
        public string memberid_introducer1 { get; set; }
        public string memberid_introducer2 { get; set; }
        public string acname { get; set; }
        public string acadd1 { get; set; }
        public string acadd2 { get; set; }
        public string acstate { get; set; }
        public string accity { get; set; }
        public string acdist { get; set; }
        public string acpin { get; set; }
        public string splstatus { get; set; }
        public string ddagentcode { get; set; }
        public string acregddate { get; set; }
        public string chqfacility { get; set; }
        public string oprnmode { get; set; }
        public string isminor { get; set; }
        public string minordob { get; set; }
        public string minoradultdt { get; set; }
        public string tddd { get; set; }
        public string tdmm { get; set; }
        public string tdyy { get; set; }
        public string tdfaceval { get; set; }
        public string tdinstintr { get; set; }
        public string tdintrate { get; set; }
        public string tdmatdate { get; set; }
        public string tdmatval { get; set; }
        public string tdintfrqmm { get; set; }
        public string tdcertno { get; set; }
        public string tdcertissued { get; set; }
        public string tdpledged { get; set; }
        public string tdpledgeachd { get; set; }
        public string tdpledgeloanid { get; set; }
        public string periodicint { get; set; }
        public string tdrenewdate { get; set; }
        public string tdrenewflag { get; set; }
        public string acclosed { get; set; }
        public string acclosdate { get; set; }
        public string tdclosintpay { get; set; }
        public string tdclosrate { get; set; }
        public string tdclospaymode { get; set; }
        public string remarks { get; set; }
        public string bookno { get; set; }
        public string tno { get; set; }
        public string deptcd { get; set; }
        public string createdby { get; set; }
        public string createdon { get; set; }
        public string computername { get; set; }
        public string modifiedby { get; set; }
        public string modifiedon { get; set; }
        public string mcomputername { get; set; }
        public string txtfd { get; set; }
        public string statusbar1 { get; set; }
        public string tag { get; set; }
        public string srl { get; set; }
        public string custsrl { get; set; }
        public string srl1 { get; set; }
        public string memberid1 { get; set; }
        public string membername1 { get; set; }
        public string guardianname1 { get; set; }
        public string relation1 { get; set; }
        public string sex1 { get; set; }
        public string occupation1 { get; set; }
        public string sign1 { get; set; }
        public string lti1 { get; set; }
        public string panno1 { get; set; }
        public string srl2 { get; set; }
        public string memberid2 { get; set; }
        public string membername2 { get; set; }
        public string guardianname2 { get; set; }
        public string relation2 { get; set; }
        public string sex2 { get; set; }
        public string occupation2 { get; set; }
        public string sign2 { get; set; }
        public string lti2 { get; set; }
        public string panno2 { get; set; }
        public string mode { get; set; }
        public string customerid1 { get; set; }
        public string nomid1 { get; set; }
        public string nameofnominee1 { get; set; }
        public string customerid2 { get; set; }
        public string nomid2 { get; set; }
        public string nameofnominee2 { get; set; }
        public string introducertype1 { get; set; }
        public string depositac1 { get; set; }
        public string acno1 { get; set; }
        public string memno1 { get; set; }
        public string srlintroducer1 { get; set; }
        public string srlintroducer2 { get; set; }
        public string nameofintroducer1 { get; set; }
        public string witness1 { get; set; }
        public string introducertype2 { get; set; }
        public string depositac2 { get; set; }
        public string acno2 { get; set; }
        public string memno2 { get; set; }
        public string nameofintroducer2 { get; set; }
        public string nomdob { get; set; }
        public string nomname { get; set; }
        public string nomreln { get; set; }
        public string nompan { get; set; }
        public string nomaadhar { get; set; }
        public string nomsrl1 { get; set; }
        public string nomsrl2 { get; set; }

        public string witness2 { get; set; }
        public string msgbox { get; set; }


    }
}
