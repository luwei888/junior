using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC.Controllers
{
    //[NonController] 改为不是控制器
    //引入Controller基类，包含常用的对象方法，方便获取数据，输出信息
    public class TestController:Controller
    {
        public IActionResult sayHello()
        {
            string value = Request.Query["key1"];
            HttpContext.Session.SetString("name", "luwei");
            return Content("hello!"+value);
        }
    }
}
