using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC.Controllers
{
    public class test2Controller:Controller
    {
        public IActionResult resultJson()
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
