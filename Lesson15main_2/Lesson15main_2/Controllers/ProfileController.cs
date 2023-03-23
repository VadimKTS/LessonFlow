using Lesson15main_2.Dto;
using Lesson15main_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson15main_2.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //var httpContext = ControllerContext.HttpContext;
            //var _httpContextOne = HttpContext.Request;

            //var tom = new Person("Vadik", 197);
            //return Json(tom);
            //return Content("Hello)))");
            return Redirect("~/Profile/Road");
        }

        public IActionResult Road() 
        {

            return View();
            //return Content("My name Profile Road");
        }

        
    }
}