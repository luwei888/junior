using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test5Controller : Controller
    {
        public IActionResult Index()
        {
            UserModel model = new UserModel()
            {
                UserName = "luwei",
                TrueName = "路炜",
                Telephone = "15736262776"
            };

            return View(model);
        }

        public class UserModel
        {
            [DisplayName("用户名")]
            public string UserName { get; set; }
            [DisplayName("真实名字")]
            public string TrueName { get; set; }
            public string Telephone { get; set; }
        }

    }
}