using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.msg = "This is a message coming from ActionMethod";
            ViewBag.date = DateTime.Now.ToShortDateString();
            return View();
        }
        public IActionResult Index1()
        {
            ViewData["msg"] = "This is from AM";
            ViewData["date"] = DateTime.Now.ToString();
            return View();
        }
    }
}
