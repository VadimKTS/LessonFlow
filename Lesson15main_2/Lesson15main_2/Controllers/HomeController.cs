using Lesson15main_2.Dto;
using Lesson15main_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Lesson15main_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

		GoodsViewModel[] goods;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            goods = new GoodsViewModel[]
            {
                new GoodsViewModel ( 1, "qwe", 2, "Bel", "Prom" ),
                new GoodsViewModel( 2, "qwer", 5, "Bel", "Prom" ),
                new GoodsViewModel( 3, "qwert", 89, "Bel", "Prom" )
            };
        }

		public IActionResult Index()
        {
            return View();
        }

		[HttpGet]
		public IActionResult Form2() => View();


		[HttpPost]
		public string Form2( PersonViewModel person )
		{
            if (ModelState.IsValid)
            {
                if (person.Password.Equals(person.ConfirmPassword))
                {
                    return $"User Name: {person.UserName}      Password: {person.Password}        Confirm Password: {person.ConfirmPassword}      Adress: {person.Adress}";
                }
                else 
                {
                    return "Пароли несовпадают";
                }
            }
            else
            {
                return "Ошибка ввода данных";
            }
			
		}
		public IActionResult Goods()
        {
            return View( goods );
        }

        public IActionResult Privacy()
        {
			//return View();
			//var httpContext = ControllerContext.HttpContext;
			//var _httpContextOne = HttpContext.Request;

			//ViewData["Vadik"] = true;
			//ViewData["Message"] = "Hello! It is ViewData-message";
			//ViewData["Number"] = 15;

			//ViewBag.MessageSecond = "Hello! It is ViewData-message";
			//ViewBag.Names = new string[] { "Simba", "Pumba", "Timon" };
			//var tom = new Person("Vadik", 197);

			var cars = new string[] { "Audi", "BMW", "Mercedes-Benz" };
			return View(cars);

			//return Json(tom);
			//return Content("Hello)))");


			//return Redirect("~/Profile/Privacy");
			//return StatusCode(402);
			//return NotFound();
			//return Unauthorized();
			//return BadRequest("Bad");
		}

        [HttpGet]
        public IActionResult Form() => View();

        

        [HttpPost]
        public string Form(string username, string password, int age, string info) 
        {
            return $"User Name: {username}      Password: {password}        Age: {age}      Info: {info}";
        }
        //---------------------------------  Lesson 16 HomeWork Task 1  ----------------------------------------------

         [HttpGet]
         public IActionResult Login() => View();

         [HttpPost]
         public IActionResult Login(string username, string password)
         {
             if (username.Equals("Vadik") && password.Equals("qwerty")) { return Redirect("~/Home/Index"); }
             else { return NotFound("Неверный логин или пароль!!!\nHTTP ERROR 404"); }
         }
        // -----------------------------------------------------------------------------------------------------------
        //public IActionResult GetMessage()
        //{
        //    return PartialView("_GetMessage");
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}