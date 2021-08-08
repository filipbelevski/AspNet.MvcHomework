using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.MvcHomework.Class02.App.Controllers
{
    [Route("homework/{controller}")]
    public class MovieController : Controller
    {
        [HttpGet("get-movies/{date:DateTime}")]
        public IActionResult GetMovies(DateTime date)
        {

            return Json(new
            {
                Date = date.ToShortDateString()
            });
        }
        [HttpGet("get-available/{isAvailable:bool}")]
        public IActionResult GetAvailable(bool isAvailable)
        {
            if (isAvailable)
            {
                return Json(new
                {
                    Name = "Suicide Squad 2",
                    Available = true
                });
            }
            else
            {
                return Json(new
                {
                    Name = "Guardians of the galaxy",
                    Available = false
                });
            }
        }
    }
}
