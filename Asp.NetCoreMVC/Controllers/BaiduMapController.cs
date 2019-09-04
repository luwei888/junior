using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.NetCoreMVC.Controllers
{
    public class BaiduMapController : Controller
    {
        public IActionResult Index()
        {

            ViewData["CityList"] = new List<SelectListItem>
            {
                new SelectListItem(){Selected = true,Text = "北京",Value="1" },
                new SelectListItem(){Selected= true,Text = "天津",Value = "2"},
                new SelectListItem(){Selected = true,Text = "重庆",Value = "3"}
            };

            return View();
        }

        public IActionResult ShowCustomer(int id)
        {
            Customer customer = new Customer() { Id = id, Name = "luwei", Email = "luwei.jin@outlook.com" };

            ViewData["Customer"] = customer;

            return View();
        }

    }
}