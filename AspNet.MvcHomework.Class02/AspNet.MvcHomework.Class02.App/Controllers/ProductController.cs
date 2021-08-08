using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.MvcHomework.Class02.App.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet("get-product/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            return Json(new
            {
                Id = id,
                Name = "someShoe"
            });
        }
        [HttpGet("get-product/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            return Json(new
            {
                Id = 1,
                Name = name,
            });
        }
    }
}
