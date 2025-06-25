using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SERCCS.Models.Views
{
    public class UsersViewModel
    {
        public string user_id { get; set; }
        public string allocated_branch_id { get; set; }
        public string user_name { get; set; }
        public string user_role { get; set; }
        public string user_password { get; set; }
        public string email_id { get; set; }
        public IEnumerable<SelectListItem> brmst { get; set; }

    }
}
