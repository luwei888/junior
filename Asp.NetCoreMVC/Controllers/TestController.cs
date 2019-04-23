using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC.Controllers
{
    //引入Controller基类，包含常用的对象方法，方便获取数据，输出信息
    public class TestController : Controller
    {
        public IActionResult SayHello()
        {
            //查找索引方式，key的名称
            string value = Request.Query["name"];
            //Request.Form["key"] 获取表单
            //Request.Cookies[""] 获取cookies
            //Request.Headers[""] 获取 header

            //获取，移除，设置
            //HttpContext.Session.SetString("name", "feige");
            //HttpContext.Session.SetInt32("age", 24);
            //HttpContext.Session.GetString("name");
            //HttpContext.Session.Remove("name");
            //int? age = HttpContext.Session.GetInt32("age");
            return Content("hello" + value);
        }
    }
}
