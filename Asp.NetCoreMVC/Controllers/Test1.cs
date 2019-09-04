using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVC.Controllers
{
    //引入命名空间
    [Controller]
    public class Test1:Controller
    {
        public IActionResult SayHello()
        {
            return Content("hello!");
        }

    }
}
