using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test7Controller : Controller
    {
        public IActionResult Index()
        {

            ISession session = HttpContext.Session;

            session.SetInt32("age", 25);
            session.SetString("name", "luwei");

            return View();
        }

        public IActionResult Read()
        {
            ISession session = HttpContext.Session;
            int? age = session.GetInt32("age");

            if (age.HasValue)
            {
                ViewBag.age = age;
            }

            string name = session.GetString("name");
            ViewBag.name = name;

            return View();
        }

    }
}