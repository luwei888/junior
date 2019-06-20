using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test7Controller : Controller
    {
        private readonly IMemoryCache _cache;

        public Test7Controller(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            ISession session = HttpContext.Session;

            session.SetInt32("age", 25);
            session.SetString("name", "luwei");

            _cache.Set("age", 30);
            _cache.Set("name", "luwei");

            return View();
        }

        public IActionResult Read()
        {
            //ISession session = HttpContext.Session;
            //int? age = session.GetInt32("age");

            //if (age.HasValue)
            //{
            //    ViewBag.age = age;
            //}

            //string name = session.GetString("name");
            //ViewBag.name = name;

            int age =_cache.Get<int>("age");
            ViewBag.age = age;
            return View();
        }

    }
}