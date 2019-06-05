using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class ActionResultController : Controller
    {
        public IActionResult ReturnJson()
        {
            //JsonResult result = new JsonResult(new { username = "zhangsan" });
            //return result;
            return Json(new { username = "zhangsan" });
        }
    }
}