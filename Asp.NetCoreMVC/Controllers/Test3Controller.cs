using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMVC.Controllers
{
    public class Test3Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.IntTestData = 500;
            ViewData["StringTestData"] = "这是一个字符串";

            ViewData["IntTestData"] = 100;
            //动态类型
            ViewBag.StringTestDate = "这是ViewBag的一个字符串";


            //传递列表数据
            List<string> lsData = new List<string>();
            lsData.Add("第一行列表");
            lsData.Add("第二行列表");
            lsData.Add("第三行列表");
            lsData.Add("第四行列表");

            ViewBag.listData = lsData;

            return View();
        }
    }
}