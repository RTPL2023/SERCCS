using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SERCCS.Models.Views
{
    public class BranchMasterViewModel
    {
        public string branch_id { get; set; }
        public string branch_name { get; set; }
        public string branch_add1 { get; set; }
        public string branch_add2 { get; set; }
        public string branch_phone { get; set; }
        public string branch_sname { get; set; }
        public string branch_defa { get; set; }
        public string msg { get; set; }       
    }
}
