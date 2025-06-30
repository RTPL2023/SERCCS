//using Newtonsoft.Json;
using SERCCS.Models.Views;
using SERCCS.Models.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using System.IO;

using Microsoft.AspNetCore.Mvc.Rendering;
using SERCCS.Includes;

using Microsoft.AspNetCore.Authorization;
using OfficeOpenXml;
using System.Reflection;
using System.ComponentModel;

using Vintasoft.Twain;
using System.Drawing.Printing;
using System.Drawing;



namespace SERCCS.Controllers
{
    
    public class DepositsController : Controller
    {
        const string ESC = "\u001B";
        const string BoldOn = ESC + "E" + "\u0001";
        const string BoldOff = ESC + "E" + "\0";
        private const string V = "#,##0";
        public char form_feed = Convert.ToChar(12);
        public DateTime xDate;
        public Double XBAL;
        public String xacno;
        public String XNAME;
        public String XCONT;
        public String xpo;
        public String QRY3;
        public String QRY4;
        public String XMSG;
        public String XDATE;
        public String _pono;
        public DateTime xinopdt;
        public DateTime xunclmdt;
        public decimal XAMT;
        String XXDATE;

        public String from_logon_date;
        UtilityController uc = new UtilityController();

        //****************************************************************Cash Deposit Withdraw Start**************************************//
        [HttpGet]
        public IActionResult CashDepositAndWithdrawn(CashDepositWthdrawViewModel model)
        {
            var user = User;
            model.BranchID = user.FindFirst("branch_id")?.Value;
            TvchDetail tvch = new TvchDetail();
            model.TransDate = DateTime.Now.ToString("dd/MM/yyyy").Replace("-", "/");
            tvch = tvch.getTvchDetailWithdrowCounter("", "SB", model.TransDate.Replace("/", "-"), "1");

            if (tvch != null)
            {
                xpo = tvch.trn_no.Substring(Math.Max(tvch.trn_no.Length - 4, 0), Math.Min(4, tvch.trn_no.Length));
                xpo = (Convert.ToInt32(xpo) + 1).ToString();
                model.PoNo = tvch.trn_no.Substring(0, Math.Max(tvch.trn_no.Length - 4, 0)) + xpo.PadLeft(4, '0');

            }
            else
            {
                xpo = "1";
                model.PoNo = "GDCWSB" + xpo.PadLeft(4, '0');

            }
            return View(model);
        }
        public JsonResult getdatabyContNofordepwith(CashDepositWthdrawViewModel model)
        {
            CashDepositWthdrawViewModel cv = new CashDepositWthdrawViewModel();
            cv = GetAccountDetailByControlNO(model.BranchID, model.ContNo, model.AcHd, model.TransDate);
            model.AcNo = cv.AcNo;
            model.Name = cv.Name;
            model.ModeOfOprtn = cv.ModeOfOprtn;
            model.LastOpDate = cv.LastOpDate;

            model.LastBalance = Convert.ToDecimal(cv.LastBalance).ToString("#,##0.00");
            model.MaxWithAmount = Convert.ToDecimal(cv.MaxWithAmount).ToString("#,##0.00");
            model.PoNo = GetPoNo(model.BranchID, model.CounterNo, model.DepositWithdrow, model.AcHd, model.TransDate);
            return Json(model);
        }
        public JsonResult getdatabyAcNofordepwith(CashDepositWthdrawViewModel model)
        {
            CashDepositWthdrawViewModel cv = new CashDepositWthdrawViewModel();
            cv = GetAccountDetailByAccountNO(model.BranchID, model.AcNo, model.AcHd, model.TransDate);
            model.ContNo = cv.ContNo;
            model.Name = cv.Name;
            model.ModeOfOprtn = cv.ModeOfOprtn;
            model.LastOpDate = cv.LastOpDate;
            model.LastBalance = Convert.ToDecimal(cv.LastBalance).ToString("#,##0.00");
            model.MaxWithAmount = Convert.ToDecimal(cv.MaxWithAmount).ToString("#,##0.00");
            model.PoNo = GetPoNo(model.BranchID, model.CounterNo, model.DepositWithdrow, model.AcHd, model.TransDate);
            return Json(model);
        }
        public JsonResult Getphotosignfordepwith(string ContNo)
        {
            CashDepositWthdrawViewModel model = new CashDepositWthdrawViewModel();
            KycDetails kd = new KycDetails();
            MemberMastDBUtility memMastDBUtility = new MemberMastDBUtility();

            kd = memMastDBUtility.getKycDetailsBySingleCont(ContNo);
            if (kd.photo != null && kd.sign != null)
            {

                model.PhotoImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.photo);

                model.SigImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.sign);
            }
            return Json(model);
        }
        public JsonResult SaveDepositWitdraw(CashDepositWthdrawViewModel model)
        {
            int i = 1;
            TvchDetail tv = new TvchDetail();
            if (model.DepositWithdrow == "Withdrawal")
            {
                tv.vch_drcr = "D";
            }
            else
            {
                tv.vch_drcr = "C";
            }




            string result = string.Empty;




            SaveData(model);
            DepositMast dm = new DepositMast();
            if (model.DepositWithdrow == "Withdrawal")
            {
                dm = dm.CheckStatus(model.AcHd, model.AcNo);
                if (dm.ac_closed == "T")
                {
                    dm.ac_closed = "C";
                    dm.ac_hd = model.AcHd;
                    dm.ac_no = model.AcNo;
                    dm.UpdateDepositMastForClosFlag(dm);
                }
            }


            model.msgbox = "Transaction Over";





            return Json(model.msgbox);
        }
        public JsonResult GetTotalList(CashDepositWthdrawViewModel model)
        {
            int i = 1;
            model.totalAmt = "0";
            model.table = "<tr><th>Srl</th><th>Counter No</th><th>PO No.</th><th> A/c No </th><th> Name </th><th> Amount (Rs.) </th></tr>";
            List<TvchDetail> lstTV = new List<TvchDetail>();
            lstTV = GetTotal(model);
            if (lstTV.Count > 0)
            {
                foreach (var a in lstTV)
                {
                    model.table = model.table + "<tr><td>" + i.ToString() + "</td><td>" + a.counter_no + "</td><td>" + a.trn_no + "</td><td>" + a.vch_pacno + "</td><td>" + a.vch_acname + "</td><td>" + a.vch_amt.ToString("0.00") + "</td></tr>";
                    model.totalAmt = (Convert.ToDecimal(model.totalAmt) + a.vch_amt).ToString("0.00");
                    i = i + 1;
                }
            }
            return Json(model);
        }




        public JsonResult CheckWithBal(string MaxWithAmount, string WithAmount)
        {
            decimal maxwithdraw = Convert.ToDecimal(MaxWithAmount);
            decimal withdrawAmt = Convert.ToDecimal(WithAmount);
            string res = CheckWithdrawAmount(maxwithdraw, withdrawAmt);
            return Json(res);

        }

        public string CheckWithdrawAmount(decimal maxwith, decimal with)
        {
            string result = string.Empty;
            if (with > 0 && with <= maxwith)
            {
                result = "Yes";
            }
            else
            {
                result = "No";

            }
            return result;
        }




        public CashDepositWthdrawViewModel GetAccountDetailByControlNO(string branchid, string contno, string achd, string transdate)
        {
            DepositMast dm;
            CashDepositWthdrawViewModel cashDepositWthdrawViewModel = new CashDepositWthdrawViewModel();



            if (achd == "SB" || achd == "FD")
            {

                DepositDBUtility depositDBUtility = new DepositDBUtility();
                dm = depositDBUtility.getDepositMastDetailByConNo(branchid, contno, achd);
                if (dm != null)
                {
                    cashDepositWthdrawViewModel.AcNo = dm.ac_no;
                    cashDepositWthdrawViewModel.Name = dm.ac_name;
                    if (dm.oprn_mode == "ANY")
                        cashDepositWthdrawViewModel.ModeOfOprtn = "Any One";
                    else if (dm.oprn_mode == "SING")
                        cashDepositWthdrawViewModel.ModeOfOprtn = "SINGLE";
                    else
                        cashDepositWthdrawViewModel.ModeOfOprtn = dm.oprn_mode;



                    if (achd == "SB")
                    {
                        DepositLedgerSB dlsb = new DepositLedgerSB();
                        DepLedgerSBDBUtility depLedgerSBDBUtility = new DepLedgerSBDBUtility();
                        dlsb = depLedgerSBDBUtility.getDepositLedgerDetailByAcno(branchid, dm.ac_no, achd);
                        if (dlsb != null)
                        {
                            cashDepositWthdrawViewModel.LastOpDate = dlsb.vch_date.ToString("dd-MM-yyyy").Replace("-", "/");
                            cashDepositWthdrawViewModel.LastBalance = dlsb.prin_bal.ToString();
                        }

                        //List<DepositLedgerTemp> tm = new List<DepositLedgerTemp>();
                        //DepLedgerTempDBUtility depLedgerTempDBUtility = new DepLedgerTempDBUtility();
                        //tm = depLedgerTempDBUtility.getDepositLedgerTempByAcnoForDepWith(branchid,dm.ac_no, achd);
                        //if (tm.Count>0)
                        //{
                        //    foreach(var a in tm)
                        //    {
                        //        if (a.dr_cr == "D")
                        //        {
                        //            cashDepositWthdrawViewModel.LastBalance = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) - a.prin_amount).ToString();
                        //            cashDepositWthdrawViewModel.LastOpDate = a.vch_date.ToString("dd-MM-yyyy").Replace("-", "/");
                        //        }
                        //        else
                        //        {
                        //            cashDepositWthdrawViewModel.LastBalance = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) + a.prin_amount).ToString();
                        //            cashDepositWthdrawViewModel.LastOpDate = a.vch_date.ToString("dd-MM-yyyy").Replace("-", "/");

                        //        }
                        //    }

                        //}
                        if (dm.ac_closed.ToString() == "T")
                            cashDepositWthdrawViewModel.MaxWithAmount = dlsb.prin_bal.ToString();
                        else
                            cashDepositWthdrawViewModel.MaxWithAmount = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) - 300).ToString();

                    }

                }
                else
                {
                    cashDepositWthdrawViewModel.msgbox = "Wrong Control NO";
                    ViewBag.ErrorMsg = "Wrong Control NO";
                }

            }
            else if (achd == "DIV" || achd == "SH" || achd == "CMTD" || achd == "MISC" || achd == "ADV" || achd == "PRF" || achd == "SBIPP" || achd == "LFC")
            {

                MemberMast mm = new MemberMast();
                mm = mm.getMemberMastDetailByConNo(contno);
                if (mm != null)
                {
                    //cashDepositWthdrawViewModel.AcNo = mm.member_id;
                    cashDepositWthdrawViewModel.Name = mm.member_name;
                    if (achd == "CMTD")
                    {
                        DepositLedgerSB dlsb = new DepositLedgerSB();
                        DepLedgerSBDBUtility depLedgerSBDBUtility = new DepLedgerSBDBUtility();
                        dlsb = depLedgerSBDBUtility.getDepositLedgerDetailByAcno(branchid, contno, achd);
                        if (dlsb != null)
                        {
                            cashDepositWthdrawViewModel.LastOpDate = dlsb.vch_date.ToString("dd-MM-yyyy");
                            cashDepositWthdrawViewModel.LastBalance = dlsb.prin_bal.ToString();
                            cashDepositWthdrawViewModel.MaxWithAmount = dlsb.prin_bal.ToString();
                        }
                    }
                }
                else
                {
                    cashDepositWthdrawViewModel.msgbox = "Wrong Control NO";
                    ViewBag.ErrorMsg = "Wrong Control NO";
                }

            }
            else
            {
                LoanMaster lm = new LoanMaster();
                lm = lm.getLoanMasterDetailByConno(contno, achd);
                if (lm != null)
                {
                    cashDepositWthdrawViewModel.AcNo = lm.loan_id;
                    cashDepositWthdrawViewModel.Name = lm.loanee_name;

                }
                else
                {
                    cashDepositWthdrawViewModel.msgbox = "Wrong Control NO";
                    ViewBag.ErrorMsg = "Wrong Control NO";
                }

            }


            cashDepositWthdrawViewModel.ContNo = contno;


            //if (!string.IsNullOrWhiteSpace(cashDepositWthdrawViewModel.ContNo))
            //{
            //    KycDetails kd = new KycDetails();
            //    MemberMastDBUtility memMastDBUtility = new MemberMastDBUtility();

            //    kd = memMastDBUtility.getKycDetailsBySingleCont(cashDepositWthdrawViewModel.ContNo);

            //    //cashDepositWthdrawViewModel.PhotoImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.photo);

            //    //cashDepositWthdrawViewModel.SigImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.sign);

            //}


            return cashDepositWthdrawViewModel;
        }

        public CashDepositWthdrawViewModel GetAccountDetailByAccountNO(string branchid, string acno, string achd, string transdate)
        {
            DepositMast dm;
            CashDepositWthdrawViewModel cashDepositWthdrawViewModel = new CashDepositWthdrawViewModel();

            if (acno != null && acno.Length > 0)
            {


                if (achd == "SB" || achd == "FD")
                {
                    DepositDBUtility depositDBUtility = new DepositDBUtility();
                    dm = depositDBUtility.getDepositMastDetailByAcno(branchid, acno, achd);
                    if (dm != null)
                    {
                        cashDepositWthdrawViewModel.ContNo = dm.contno;
                        cashDepositWthdrawViewModel.Name = dm.ac_name;
                        if (dm.oprn_mode == "ANY")
                            cashDepositWthdrawViewModel.ModeOfOprtn = "Any One";
                        else if (dm.oprn_mode == "SING")
                            cashDepositWthdrawViewModel.ModeOfOprtn = "SINGLE";
                        else
                            cashDepositWthdrawViewModel.ModeOfOprtn = dm.oprn_mode;


                        if (achd == "SB")
                        {
                            DepositLedgerSB dlsb = new DepositLedgerSB();
                            DepLedgerSBDBUtility depLedgerSBDBUtility = new DepLedgerSBDBUtility();
                            dlsb = depLedgerSBDBUtility.getDepositLedgerDetailByAcno(branchid, acno, achd);
                            if (dlsb != null)
                            {
                                cashDepositWthdrawViewModel.LastOpDate = dlsb.vch_date.ToString("dd-MM-yyyy").Replace("-", "/");
                                cashDepositWthdrawViewModel.LastBalance = dlsb.prin_bal.ToString();
                            }

                            //DepositLedgerTemp tm = new DepositLedgerTemp();
                            //List<DepositLedgerTemp> tml = new List<DepositLedgerTemp>();
                            //DepLedgerTempDBUtility depLedgerTempDBUtility = new DepLedgerTempDBUtility();
                            //tml = depLedgerTempDBUtility.getDepositLedgerTempListByAcno(branchid,acno, achd);
                            ////if (tml != null)
                            //if (tml.Count > 0)
                            //{
                            //    foreach (var dlt in tml)
                            //    {
                            //        if (dlt.dr_cr == "D")
                            //        {
                            //            cashDepositWthdrawViewModel.LastBalance = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) - dlt.prin_amount).ToString();
                            //            cashDepositWthdrawViewModel.LastOpDate = dlt.vch_date.ToString("dd-MM-yyyy").Replace("-","/");
                            //        }
                            //        else
                            //        {
                            //            cashDepositWthdrawViewModel.LastBalance = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) + dlt.prin_amount).ToString();
                            //            cashDepositWthdrawViewModel.LastOpDate = dlt.vch_date.ToString("dd-MM-yyyy").Replace("-","/");

                            //        }
                            //    }

                            //}
                            if (Convert.ToString(dm.ac_closed) == "T")
                                cashDepositWthdrawViewModel.MaxWithAmount = dlsb.prin_bal.ToString();
                            else
                                cashDepositWthdrawViewModel.MaxWithAmount = (Convert.ToDecimal(cashDepositWthdrawViewModel.LastBalance) - 300).ToString();

                        }
                        else if (achd == "FD")
                        {
                            DepositLedgerFd dlfd = new DepositLedgerFd();
                            DepositLedgerDbUtility depositLedgerDbUtility = new DepositLedgerDbUtility();
                            dlfd = depositLedgerDbUtility.GetFDLedgerDetail(acno, achd);
                            if (dlfd != null)
                            {
                                cashDepositWthdrawViewModel.LastOpDate = dlfd.vch_date.ToString("dd-MM-yyyy");
                                cashDepositWthdrawViewModel.LastBalance = dlfd.prin_bal.ToString();
                                cashDepositWthdrawViewModel.MaxWithAmount = dlfd.prin_bal.ToString();
                            }

                        }

                    }
                    //else
                    //{
                    //    cashDepositWthdrawViewModel.LastOpDate = "";

                    //    cashDepositWthdrawViewModel.LastBalance = "";

                    //    cashDepositWthdrawViewModel.MaxWithAmount = "";

                    //}

                }
                else if (achd == "DIV" || achd == "SH" || achd == "CMTD" || achd == "MISC" || achd == "ADV" || achd == "PRF" || achd == "SBIPP")
                {

                    MemberMast mm = new MemberMast();
                    mm = mm.getMemberMastDetailByAcno(acno);
                    if (mm != null)
                    {
                        cashDepositWthdrawViewModel.ContNo = mm.employee_id;
                        cashDepositWthdrawViewModel.Name = mm.member_name;

                    }

                    Ledger ld = new Ledger();
                    DepositLedgerDbUtility depositLedgerDbUtility = new DepositLedgerDbUtility();
                    ld = depositLedgerDbUtility.GetLedgerDetail(acno, achd, cashDepositWthdrawViewModel.ContNo);
                    if (ld != null)
                    {
                        cashDepositWthdrawViewModel.LastOpDate = ld.vch_date.ToString("dd-MM-yyyy");
                        cashDepositWthdrawViewModel.LastBalance = ld.prin_bal.ToString();
                        cashDepositWthdrawViewModel.MaxWithAmount = ld.prin_bal.ToString();
                    }

                    if (achd == "SBIPP")
                        cashDepositWthdrawViewModel.MaxWithAmount = "1000000";
                }
                else
                {
                    LoanMaster lm = new LoanMaster();
                    lm = lm.getLoanMasterDetailByAcno(acno, achd);
                    if (lm != null)
                    {
                        cashDepositWthdrawViewModel.ContNo = lm.employee_id;
                        cashDepositWthdrawViewModel.Name = lm.loanee_name;

                        LoanLedger lld = new LoanLedger();
                        LoanLedgerDBUtility loanLedgerDbUtility = new LoanLedgerDBUtility();
                        lld = loanLedgerDbUtility.GetLoanLedgerDetail(acno, achd, cashDepositWthdrawViewModel.ContNo, transdate);
                        if (lld != null)
                        {
                            cashDepositWthdrawViewModel.LastBalance = lld.prin_amount.ToString();
                            cashDepositWthdrawViewModel.MaxWithAmount = lld.prin_amount.ToString();
                            cashDepositWthdrawViewModel.WithAmount = lld.prin_amount.ToString();
                        }


                    }

                }


            }

            cashDepositWthdrawViewModel.AcNo = acno;

            //if (!string.IsNullOrWhiteSpace(cashDepositWthdrawViewModel.ContNo))
            //{
            //    KycDetails kd = new KycDetails();
            //    MemberMastDBUtility memMastDBUtility = new MemberMastDBUtility();

            //    kd = memMastDBUtility.getKycDetailsBySingleCont(cashDepositWthdrawViewModel.ContNo);

            //    //cashDepositWthdrawViewModel.PhotoImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.photo);

            //    //cashDepositWthdrawViewModel.SigImageUrl = "data:image/jpg;base64," + Convert.ToBase64String(kd.sign);

            //}


            return cashDepositWthdrawViewModel;
        }


        

       



        public JsonResult GeneratePoNo(string BranchID, string counterno, string depwith, string achd, string trndate)
        {
            TvchDetail tvch = new TvchDetail();
            if (depwith == "Withdrawal")
            {


                tvch = tvch.getTvchDetailWithdrowCounter(BranchID, achd, trndate.Replace("/", "-"), counterno);


            }
            else
            {
                tvch = tvch.getTvchDetailDepositCounter(BranchID, achd, trndate.Replace("/", "-"), counterno);

            }

            if (tvch != null)
            {
                xpo = tvch.trn_no.Substring(Math.Max(tvch.trn_no.Length - 4, 0), Math.Min(4, tvch.trn_no.Length));
                xpo = (Convert.ToInt32(xpo) + 1).ToString();
                _pono = tvch.trn_no.Substring(0, Math.Max(tvch.trn_no.Length - 4, 0)) + xpo.PadLeft(4, '0');

            }
            else
            {
                xpo = "1";

                if (achd == "SB")
                {
                    if (depwith == "Deposit")
                        _pono = "GDCDSB" + xpo.PadLeft(4, '0');

                    else
                        _pono = "GDCWSB" + xpo.PadLeft(4, '0');
                }


                else if (achd == "FD")
                {
                    if (depwith == "Deposit")

                        _pono = "GDCDFD" + xpo.PadLeft(4, '0');

                    else

                        _pono = "GDCWFD" + xpo.PadLeft(4, '0');
                }

                else if (achd == "SH")
                {
                    if (depwith == "Deposit")

                        _pono = "CMDSH" + xpo.PadLeft(4, '0');

                    else

                        _pono = "CMWSH" + xpo.PadLeft(4, '0');
                }
                else
                {
                    if (depwith == "Deposit")

                        _pono = "CMD" + achd.Trim() + xpo.PadLeft(4, '0');

                    else

                        _pono = "CMW" + achd.Trim() + xpo.PadLeft(4, '0');
                }


            }

            return Json(_pono);
        }


        public void SaveData(CashDepositWthdrawViewModel model)
        {
            double smstr_amount = 0;
            double smsbal = 0;


            TvchDetail tv = new TvchDetail();


            tv.branch_id = model.BranchID;
            tv.trn_date = Convert.ToDateTime(model.TransDate + " " + DateTime.Now.ToShortTimeString());
            tv.trn_shift = "G";
            tv.counter_no = Convert.ToInt32(model.CounterNo);
            tv.trn_no = model.PoNo;
            tv.trn_srl = 2;
            tv.created_by = User.Identity.Name;
            tv.created_on = DateTime.Now;
            tv.computer_name = Environment.MachineName.ToString();

            if (model.AcHd == "SB" || model.AcHd == "FD")
            {
                if (model.DepositWithdrow == "Withdrawal")
                {
                    tv.vch_drcr = "D";

                    if (model.AcHd == "SB") tv.insert_mode = "CW";
                    else tv.insert_mode = "MW";

                    tv.conf_flag = "P";

                    tv.is_self = "S";

                    tv.is_chq = "W";

                    tv.bearer_branch = model.Name;

                }

                else
                {
                    tv.vch_drcr = "C";

                    if (model.AcHd == "SB") tv.insert_mode = "CD";
                    else tv.insert_mode = "MD";


                    tv.conf_flag = "D";

                    tv.bearer_branch = model.Name;
                }
            }
            else
            {
                if (model.DepositWithdrow == "Withdrawal")
                {
                    tv.vch_drcr = "D";

                    tv.insert_mode = "MW";

                    tv.conf_flag = "P";


                }

                else
                {
                    tv.vch_drcr = "C";
                    tv.insert_mode = "MD";
                    tv.conf_flag = "D";

                }
            }

            tv.ac_hd = model.AcHd;
            tv.vch_pacno = model.AcNo;
            tv.vch_acname = model.Name;
            tv.vch_amt = Convert.ToDecimal(model.WithAmount);


            tv.SaveVoucher(tv); //sb,fd, and others

            //===========

            Ledger dlt = new Ledger();

            dlt = dlt.getLedgerDetail(model.BranchID, model.AcNo, model.AcHd, model.ContNo);

            if (dlt != null)
            {
                if (model.AcHd == "DIV")
                    XBAL = Convert.ToDouble(dlt.bal_amount);

                else
                {
                    if (model.AcHd == "SH")
                        if (Convert.ToDouble(dlt.bal_amount) > 0)
                            XBAL = Convert.ToDouble(dlt.bal_amount);
                        else
                            XBAL = 0;
                    else
                        XBAL = Convert.ToDouble(dlt.prin_bal);
                }
            }
            else
            {
                dlt = new Ledger();
                XBAL = 0;
            }


            dlt.branch_id = model.BranchID;
            dlt.created_by = User.Identity.Name;
            dlt.created_on = DateTime.Now;
            dlt.computer_name = Environment.MachineName.ToString();

            // if (model.AcHd != "SH") dlt.ac_hd = model.AcHd;
            dlt.ac_hd = model.AcHd;
            if (model.AcHd == "SB" || model.AcHd == "FD")
            {
                dlt.ac_no = model.AcNo;
                dlt.contno = model.ContNo;
            }
            else if (model.AcHd == "CMTD")
            {
                dlt.member_id = model.ContNo;

            }
            else if (model.AcHd == "DIV" || model.AcHd == "SH")
            {
                dlt.member_id = model.AcNo;

            }

            else
            {
                dlt.loan_id = model.AcNo;

            }

            dlt.vch_date = Convert.ToDateTime(model.TransDate + " " + DateTime.Now.ToShortTimeString());
            dlt.vch_no = model.PoNo;
            dlt.vch_srl = 0;
            dlt.vch_type = "C";
            dlt.vch_achd = model.AcHd;

            if (model.DepositWithdrow == "Withdrawal")
            {
                dlt.dr_cr = "D";
                if (model.AcHd == "SH" || model.AcHd == "DIV")
                {

                    dlt.tr_amount = Convert.ToDouble(model.WithAmount);
                    dlt.bal_amount = Convert.ToDecimal(XBAL) + Convert.ToDecimal(model.WithAmount);

                    smstr_amount = Convert.ToDouble(model.WithAmount);
                    smsbal = Convert.ToDouble(XBAL) + Convert.ToDouble(model.WithAmount);


                }
                else
                {
                    dlt.prin_amount = Convert.ToDecimal(model.WithAmount);
                    dlt.prin_bal = Convert.ToDecimal(XBAL) - Convert.ToDecimal(model.WithAmount);

                    smstr_amount = Convert.ToDouble(model.WithAmount);
                    smsbal = Convert.ToDouble(model.LastBalance) - Convert.ToDouble(model.WithAmount);

                }


                dlt.insert_mode = "CW";
                dlt.ref_ac_hd = "CASH";
                dlt.ref_pacno = model.AcHd + model.PoNo.Substring(Math.Max(model.PoNo.Length - 4, 0), Math.Min(4, model.PoNo.Length));

            }

            else
            {
                dlt.dr_cr = "C";
                if (model.AcHd != "SH")
                {
                    dlt.prin_amount = Convert.ToDecimal(model.WithAmount);
                    dlt.prin_bal = Convert.ToDecimal(XBAL) + Convert.ToDecimal(model.WithAmount);

                    smstr_amount = Convert.ToDouble(model.WithAmount);
                    smsbal = Convert.ToDouble(model.LastBalance) + Convert.ToDouble(model.WithAmount);
                }
                else
                {

                    if (model.WithAmount.Substring(model.WithAmount.Length - 1, 1) == "1")
                    {
                        dlt.tr_amount = Convert.ToDouble(model.WithAmount) - 1;
                        dlt.bal_amount = Convert.ToDecimal(XBAL) + Convert.ToDecimal(model.WithAmount) - 1;

                        smstr_amount = Convert.ToDouble(model.WithAmount) - 1;
                        smsbal = Convert.ToDouble(Convert.ToDecimal(XBAL) + Convert.ToDecimal(model.WithAmount) - 1);

                        Int64 xunit = Convert.ToInt64(((Convert.ToDecimal(model.WithAmount) - 1) / 10));
                        dlt.units = xunit;
                        dlt.face_val = 10;
                    }

                    else
                    {
                        dlt.tr_amount = Convert.ToDouble(model.WithAmount);
                        dlt.bal_amount = Convert.ToDecimal(XBAL) + Convert.ToDecimal(model.WithAmount);

                        smstr_amount = Convert.ToDouble(model.WithAmount);
                        smsbal = Convert.ToDouble(XBAL) + Convert.ToDouble(model.WithAmount);

                        dlt.units = Convert.ToInt64(Convert.ToDecimal(model.WithAmount) / 10);
                        dlt.face_val = 10;
                    }

                }

                dlt.insert_mode = "CD";
                dlt.ref_ac_hd = "CASH";
                dlt.ref_pacno = model.AcHd + model.PoNo.Substring(Math.Max(model.PoNo.Length - 4, 0), Math.Min(4, model.PoNo.Length));

            }


            if (model.AcHd == "SB") dlt.SaveDepositLedgerTemp(dlt);
            else if (model.AcHd == "FD") dlt.SaveLedger(dlt, "DEPOSIT_LEDGER_FD");
            else if (model.AcHd == "CMTD") dlt.SaveLedger(dlt, "CMTD_LEDGER");
            else if (model.AcHd == "DIV") dlt.SaveLedger(dlt, "DIVIDEND_LEDGER");
            else if (model.AcHd == "SH") dlt.SaveLedger(dlt, "SHARE_LEDGER");
            //else if (model.AcHd == "LTL") dlt.SaveLedger(dlt, "Loan_Ledger_Ltl");
            //else if (model.AcHd == "FES") dlt.SaveLedger(dlt, "SHARE_LEDGER");
            //else if (model.AcHd == "STL") dlt.SaveLedger(dlt, "SHARE_LEDGER");

            //13-07-2022
            if (model.AcHd == "SB")
            {
                //SendSMS(dlt.ac_no, dlt.contno, dlt.vch_date.ToString(), dlt.dr_cr, smstr_amount, smsbal);
            }

        }

        public IActionResult GetPrintFile(string DepositWithdrow, string CounterNo, string AcHd, string TransDate)
        {
            decimal total = 0;
            List<TvchDetail> lsttv = new List<TvchDetail>();
            TvchLedgerDBUtility tv = new TvchLedgerDBUtility();
            //  Boolean isDateRange = true;
            lsttv = tv.GetTotalByDateforPrint(DepositWithdrow, CounterNo, AcHd, TransDate);
            Directory.CreateDirectory("wwwroot\\TextFiles");
            using (StreamWriter sw = new StreamWriter("wwwroot\\TextFiles\\CASHDEPOSITANDWITHDRAWN.txt"))
            {
                int Pg = 1;
                int Ln = 0;

                sw.WriteLine("C.L.W. CO-OPERATIVE CREDIT SOCIETY LTD.".ToString().PadLeft(48)); //Print #1, Chr(27)
                sw.WriteLine("CHITTARANJAN".ToString().PadLeft(35));
                sw.WriteLine("LIST OF CASH DEPOSIT AND WITHDRAWN".ToString().PadLeft(47));
                sw.WriteLine("");
                sw.WriteLine(AcHd.ToString().PadRight(4) + "CASH".ToString().PadRight(8) + DepositWithdrow.ToString().PadRight(10) + "SCROLL FOR".ToString().PadRight(2)
                    + TransDate.PadRight(12) + ":".ToString().PadRight(4) + "COUNTER:".ToString().PadRight(10) + CounterNo.ToString());
                sw.WriteLine("");
                sw.WriteLine("Counter  " + "P.O. No.".ToString().PadLeft(14) + "A/c No.".ToString().PadLeft(13) + "Name".ToString().PadLeft(21) + "Amount".ToString().PadLeft(30));
                sw.WriteLine("-------".ToString().PadLeft(6) + "------------".ToString().PadLeft(18) + "------------".ToString().PadLeft(16) + "------------".ToString().PadLeft(21) + "------------".ToString().PadLeft(29));
                sw.WriteLine("");
                Ln = 7;
                foreach (var tvch in lsttv)
                {
                    if (Ln > Pg * 65)
                    {
                        sw.WriteLine(form_feed);
                        sw.WriteLine(BoldOn);
                        Pg = Pg + 1;
                        Ln = Ln + 7;
                        sw.WriteLine("C.L.W. CO-OPERATIVE CREDIT SOCIETY LTD.".ToString().PadLeft(48)); //Print #1, Chr(27)
                        sw.WriteLine("CHITTARANJAN".ToString().PadLeft(35));
                        sw.WriteLine("LIST OF CASH DEPOSIT AND WITHDRAWN".ToString().PadLeft(47));
                        sw.WriteLine("");
                        sw.WriteLine(AcHd.ToString().PadLeft(4) + "CASH".ToString().PadLeft(8) + DepositWithdrow.ToString().PadLeft(10) + "SCROLL FOR".ToString().PadLeft(2)
                        + TransDate.PadRight(12) + ":".ToString().PadRight(4) + "COUNTER:".ToString().PadRight(10) + CounterNo.ToString());
                        sw.WriteLine("");
                        sw.WriteLine("Counter  " + "P.O. No.".ToString().PadLeft(14) + "A/c No.".ToString().PadLeft(13) + "Name".ToString().PadLeft(21) + "Amount".ToString().PadLeft(30));
                        sw.WriteLine("-------".ToString().PadLeft(6) + "------------".ToString().PadLeft(18) + "------------".ToString().PadLeft(16) + "------------".ToString().PadLeft(21) + "------------".ToString().PadLeft(29));
                        sw.WriteLine("");
                    }
                    sw.WriteLine("  " + tvch.counter_no.ToString().PadLeft(1)
                          + tvch.trn_no.PadLeft(21)
                          + tvch.vch_pacno.PadLeft(12)
                          + tvch.vch_acname.PadLeft(32)
                          + tvch.vch_amt.ToString().PadLeft(19)
                       );
                    Ln = Ln + 1;
                    total = total + Convert.ToDecimal(tvch.vch_amt);
                }
                Ln = Ln + 10;
                if (Ln > Pg * 65)
                {
                    sw.WriteLine(form_feed);
                    sw.WriteLine(BoldOn);
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("TOTAL Rs.  " + total.ToString());
                    // sw.WriteLine(" (" + numtoword(model.Total)) + ")");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("Section Incharge Secretary");
                }
                else
                {
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("TOTAL Rs.  " + total.ToString());
                    //  sw.WriteLine(" (" + numtoword(model.Total)) + ")");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("  ");
                    sw.WriteLine("Section Incharge Secretary");
                }
                sw.WriteLine(form_feed);
                //   total = total + tvch.vch_amt;
            }
            UtilityController u = new UtilityController();
            var memory = u.DownloadTextFiles("CASHDEPOSITANDWITHDRAWN.txt", "wwwroot\\TextFiles");
            if (System.IO.File.Exists("wwwroot\\TextFiles\\CASHDEPOSITANDWITHDRAWN.txt"))
            {
                System.IO.File.Delete("wwwroot\\TextFiles\\CASHDEPOSITANDWITHDRAWN.txt");
            }
            return File(memory.ToArray(), "text/plain", "CASH_DEPOSIT_AND_WITHDRAWN_" + AcHd + "_" + CounterNo + "_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".txt");
        }

        public List<TvchDetail> GetTotal(CashDepositWthdrawViewModel model)
        {
            String qry;
            List<TvchDetail> lstTV = new List<TvchDetail>();
            if (model.DepositWithdrow == "Withdrawal")
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY') ";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + "  AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW' AND COUNTER_NO <>'7' order by COUNTER_NO,TRN_NO";

                }
                else
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY') ";//and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND ";

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='D' AND ";

                    qry = qry + "AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CW'";

                    else
                        qry = qry + " AND INSERT_MODE='MW'";



                    qry = qry + " AND COUNTER_NO='" + model.CounterNo + "' order by COUNTER_NO,TRN_NO";

                }
            }
            else
            {
                if (model.CounterNo == "All")
                {
                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";

                    qry = qry + " TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND   TRN_SHIFT ='G' AND VCH_DRCR='C' AND AC_HD='" + model.AcHd + "'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD' order by COUNTER_NO,TRN_NO";
                    else
                        qry = qry + " AND INSERT_MODE='MD' order by COUNTER_NO,TRN_NO";

                }

                else
                {

                    qry = "SELECT * FROM TVCH_DETAIL WHERE BRANCH_ID='MN' AND ";
                    qry = qry + "TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY') , 'DD/MM/YYYY')= TO_DATE('" + model.TransDate + "', 'DD/MM/YYYY')";// and TO_DATE(TO_CHAR(TRN_DATE, 'DD/MM/YYYY'), 'DD/MM/YYYY')<TO_DATE('" & XDATE & "', 'DD/MM/YYYY') AND "

                    qry = qry + " AND TRN_SHIFT='G' AND VCH_DRCR='C'";

                    if (model.AcHd == "SB")
                        qry = qry + " AND INSERT_MODE='CD'AND AC_HD='" + model.AcHd + "'";

                    else
                        qry = qry + " AND INSERT_MODE='MD'AND AC_HD='" + model.AcHd + "'";

                    qry = qry + " AND COUNTER_NO=" + model.CounterNo + "order by COUNTER_NO,TRN_NO";
                }
            }

            DepositLedgerDbUtility depositLedgerDbUtility = new DepositLedgerDbUtility();
            lstTV = depositLedgerDbUtility.GetTotalDeposit(qry);


            return lstTV;

        }

        public String GetPoNo(string BranchID, string counterno, string depwith, string achd, string trndate)
        {
            TvchDetail tvch = new TvchDetail();
            if (depwith == "Withdrawal")
            {


                tvch = tvch.getTvchDetailWithdrowCounter(BranchID, achd, trndate.Replace("/", "-"), counterno);


            }
            else
            {
                tvch = tvch.getTvchDetailDepositCounter(BranchID, achd, trndate.Replace("/", "-"), counterno);

            }

            if (tvch != null)
            {
                xpo = tvch.trn_no.Substring(Math.Max(tvch.trn_no.Length - 4, 0), Math.Min(4, tvch.trn_no.Length));
                xpo = (Convert.ToInt32(xpo) + 1).ToString();
                _pono = tvch.trn_no.Substring(0, Math.Max(tvch.trn_no.Length - 4, 0)) + xpo.PadLeft(4, '0');

            }
            else
            {
                xpo = "1";

                if (achd == "SB")
                {
                    if (depwith == "Deposit")
                        _pono = "GDCDSB" + xpo.PadLeft(4, '0');

                    else
                        _pono = "GDCWSB" + xpo.PadLeft(4, '0');
                }


                else if (achd == "FD")
                {
                    if (depwith == "Deposit")

                        _pono = "GDCDFD" + xpo.PadLeft(4, '0');

                    else

                        _pono = "GDCWFD" + xpo.PadLeft(4, '0');
                }

                else if (achd == "SH")
                {
                    if (depwith == "Deposit")

                        _pono = "CMDSH" + xpo.PadLeft(4, '0');

                    else

                        _pono = "CMWSH" + xpo.PadLeft(4, '0');
                }
                else
                {
                    if (depwith == "Deposit")

                        _pono = "CMD" + achd.Trim() + xpo.PadLeft(4, '0');

                    else

                        _pono = "CMW" + achd.Trim() + xpo.PadLeft(4, '0');
                }


            }

            return (_pono);
        }



        //13-07-2022
        public void SendSMS(String ac_no, String contno, String vch_date, String dr_cr, Double tr_amount, Double bal_amount)
        {

            string smsurl = String.Empty;
            String phoneno = String.Empty;
            String msg = String.Empty;

            KycDetails kd = new KycDetails();
            phoneno = kd.getKycMobilenoByCont(contno);


            if (!string.IsNullOrEmpty(phoneno))
            {
                string vdate = Convert.ToDateTime(vch_date).ToString("dd/MM/yyyy").Replace("-", "/");
                if (dr_cr == "C")
                    msg = "Dear Member, INR " + tr_amount.ToString("0.00") + " deposited to your A/c No " + ac_no + " on " + vdate + ". Available balance " + bal_amount.ToString("0.00") + ". -CHITTARANJAN LWCSL";

                //msg = "Dear Member, INR " + tr_amount + " deposited to your A/c No xxx" + ac_no + " on " + vch_date + ". Available balance " + bal_amount + ".-CLWCCS";
                else
                    msg = "Dear Member, INR " + tr_amount.ToString("0.00") + " withdrawn from your A/c No " + ac_no + " on " + vdate + ". Available balance " + bal_amount.ToString("0.00") + ". -CHITTARANJAN LWCSL";
                //msg = "Dear Member, INR " + tr_amount + " withdrawn from your A/c No xxx" + ac_no + " on " + vch_date + ". Available balance " + bal_amount + ".-CLWCCS";

                //  msg = "Dear Member, INR 200 deposited to your A/c No xx3212 on 12-07-2022. Available balance 23000.00.-CLWCCS";

                try
                {

                    using (WebClient client = new WebClient())
                    {
                        // smsurl =  "http://sms.digilexa.in/http-api.php?username=CHITTARANJAN&password=CLWCCS@r76&senderid=CLWCCS&route=7&number=9432102878&message=" + msg;
                        //smsurl = "http://sms.digilexa.in/http-api.php?username=CHITTARANJAN&password=CLWCCS@r76&senderid=CLWCCS&route=7&number=" + phoneno + "&message=" + msg;

                        smsurl = "http://sms.digilexa.in/http-api.php?username=CHITTARANJAN&password=CCSCLW@r76&senderid=CCSCLW&route=7&number=" + phoneno + "&message=" + msg;
                        string result = client.DownloadString(smsurl);



                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        //****************************************************************Cash Deposit Withdraw End**************************************//





































        //*******************************************AccountOpening***********************************************************

        [HttpGet]
        public IActionResult AccountOpening(AccountOpeningViewModel model)
        {
            model.ac_hd_desc = uc.getAcHdDescForSB();
            model.md_of_op_desc = uc.getOprnMode();
            model.ac_category_desc = uc.getStatusDesc();
            model.opendate = DateTime.Now.ToShortDateString();
            model.branchid = "GRC";
            return View(model);
        }

        public JsonResult GetDetailByContNo(string achd, string contno,string branchid)
        {
            DepositMast dm = new DepositMast();
            dm = dm.GetDepositOrMemberMastbyContNo(branchid, achd, contno);
            return Json(dm);
        }
        public JsonResult SaveDepositMast(AccountOpeningViewModel model)
        {
            string msg = "";
            DepositMast dpm = new DepositMast();
            msg = dpm.GetAcnoByContnoForAcOpening(model.contno);
            if (msg == null)
            {
                dpm = dpm.GetDepositMastByAcNo(model.branchid, model.achd, model.acno);
                if (dpm != null)
                {
                    msg = dpm.msg;
                }
                else
                {
                    try
                    {
                        DepositMast dm = new DepositMast();
                        dm.branch_id = model.branchid;
                        dm.ac_hd = model.achd;
                        dm.ac_no = model.acno;
                        dm.created_by = User.Identity.Name;
                        dm.created_on = DateTime.Now;
                        dm.computer_name = Environment.MachineName.ToString();
                        dm.open_date = Convert.ToDateTime(model.opendate);
                        dm.spl_status = model.splstatus;
                        dm.contno = model.contno;
                        if (model.chqfacility == "YES")
                            dm.chq_facility = "1";
                        else
                            dm.chq_facility = "0";
                        dm.oprn_mode = model.oprnmode;
                        dm.ac_name = model.acname;
                        dm.ac_add1 = model.acadd1;
                        dm.ac_add2 = model.acadd2;
                        dm.ac_city = model.accity;
                        dm.ac_dist = model.acdist;
                        dm.ac_state = model.acstate;
                        dm.ac_pin = model.acpin;
                        if (model.isminor == "YES")
                        {
                            dm.is_minor = "1";
                            dm.minor_dob = Convert.ToDateTime(model.minordob);
                            dm.minor_adult_dt = Convert.ToDateTime(model.minoradultdt);
                        }
                        dm.SaveDepositMast(dm);
                        DepositCustomer dc = new DepositCustomer();
                        dc.cust_srl = Convert.ToInt32(model.srl1);
                        dc.branch_id = model.branchid;
                        dc.ac_hd = model.achd;
                        dc.ac_no = model.acno;
                        dc.member_id = model.memberid1;
                        if (model.sign1 == "YES")
                            dc.sign_flag = "S";
                        else
                            dc.sign_flag = "L";
                        dc.SaveDepositCustomer(dc);
                        if (model.srl2 != null && model.srl2 != "")
                        {
                            if (model.memberid2 != null && model.memberid2 != "")
                            {
                                dc.cust_srl = Convert.ToInt32(model.srl2);
                                dc.branch_id = model.branchid;
                                dc.ac_hd = model.achd;
                                dc.ac_no = model.acno;
                                dc.member_id = model.memberid2;
                                if (model.sign1 == "YES")
                                    dc.sign_flag = "S";
                                else
                                    dc.sign_flag = "L";
                                dc.SaveDepositCustomer(dc);
                            }
                        }
                        msg = "Saved Successfully";
                    }
                    catch (Exception ex)
                    {
                        msg = "Unable To Save " + Convert.ToString(ex);
                    }

                }
            }
            return Json(msg);
        }
        public JsonResult GetDetailByAcNo(string achd, string acno,string branchid)
        {
            DepositMast dm = new DepositMast();
            dm = dm.GetDepositOrMemberMastbyACNo(branchid, achd, acno);
            return Json(dm);
        }

        //************************************end of account openning***********************************************************

    }
}
