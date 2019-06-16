using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test4Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = "luwei";
            List<string> listData = new List<string>();
            listData.Add("第一行数据");
            listData.Add("第二行数据");
            listData.Add("第三行数据");
            listData.Add("第四行数据");

            ViewBag.lsData = listData;
            return View();
        }

        public IActionResult checkUser(
            string username, string userPassword,
            string username1, string userPassword1)
        {
            return Content($"用户{username}:密码{userPassword},用户1{username1}:{userPassword1}");
        }
    }
}