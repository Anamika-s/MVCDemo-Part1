using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
            Customer customer = new Customer()
            { Id = 1, Name = "Ajay" };
            ViewBag.customer = customer;
            return View();
        }
    }
}
