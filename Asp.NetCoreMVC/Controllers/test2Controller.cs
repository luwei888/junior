using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test2Controller:Controller
    {
        public IActionResult ResultJson()
        {
            JsonResult result = new JsonResult(new { username = "luwei" });

            return result;

        }

        public IActionResult ShowView()
        {
            return View("~/Views/home/Contact");
        }

    }
}
