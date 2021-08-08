using AspNet.MvcHomework.Class02.App.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.MvcHomework.Class02.App.Controllers
{
    [Route("pizza/{controller}")]
    public class OrderController : Controller
    {
        [HttpGet("create-order")]
        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost("create-order")]
        public IActionResult CreateOrder(Order order)
        {

            return RedirectToAction("Index", "Home");

        }
    }
}
