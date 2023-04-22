using AutoMapper;
using Lesson15main_2.Dto;
using Lesson15main_2.Models;
using Lesson15main_2.Models.EFDto;
using Lesson15main_2.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Lesson15main_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        GoodsViewModel[] goods;

        private ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;

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
        public string Form2(PersonViewModel person)
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
            return View(goods);
        }

        //      public IActionResult Privacy()
        //      {
        //	//return View();
        //	//var httpContext = ControllerContext.HttpContext;
        //	//var _httpContextOne = HttpContext.Request;

        //	//ViewData["Vadik"] = true;
        //	//ViewData["Message"] = "Hello! It is ViewData-message";
        //	//ViewData["Number"] = 15;

        //	//ViewBag.MessageSecond = "Hello! It is ViewData-message";
        //	//ViewBag.Names = new string[] { "Simba", "Pumba", "Timon" };
        //	//var tom = new Person("Vadik", 197);

        //	var cars = new string[] { "Audi", "BMW", "Mercedes-Benz" };
        //	return View(cars);

        //	//return Json(tom);
        //	//return Content("Hello)))");


        //	//return Redirect("~/Profile/Privacy");
        //	//return StatusCode(402);
        //	//return NotFound();
        //	//return Unauthorized();
        //	//return BadRequest("Bad");
        //}

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



        //public async Task<IActionResult> Privacy()
        //{
        //    var users = db.Users.ToList();
        //    return View(users);
        //}

        public IActionResult Privacy()
        {
            var users = db.Users.Include(m => m.Manufacture).ToList();  //исправить и разобраться с автомаппером. Сделать МИГРАЦИЮ
            return View(users);
        }
        //public IEnumerable<User> GetAll() //для настройки automapper
        //{
        //    return db.Users.ToList();
        //}

        public IActionResult Create()
        {
            var manufactures = db.Manufactures.ToList();
            IEnumerable<SelectListItem> manufactureItems = manufactures.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name
            });
            ViewBag.Manufacture = manufactureItems;
            //ViewBag.Manufacture = manufactures;

            return View();
        }
        

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<User, Manufacture>().ReverseMap());

            //var mapper = config.CreateMapper();
            //// or
            ////var mapper = new Mapper(config);
            ////OrderDto dto = mapper.Map<OrderDto>(order);
            
            //User user = mapper.Map<User, Manufacture>(model.ManufactureId);

            var manufacture = db.Manufactures.FirstOrDefault(m => m.Id == model.ManufactureId);

            var user = new User
            {
                Id = db.Users.Max(n => n.Id) + 1,
                Name = model.Name,
                LastName = model.LastName,
                Age = model.Age,
                Address = model.Address,
                ManufactureId = manufacture.Id,
            };

            db.Users.Add(user);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }



        //[HttpPost]
        //public async Task<IActionResult> Create(User user)
        //{
        //    db.Users.Add(user);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {

                var manufactures = db.Manufactures.ToList();
                IEnumerable<SelectListItem> manufactureItems = manufactures.Select(m => new SelectListItem
                {
                    Value = m.Id.ToString(),
                    Text = m.Name
                });
                ViewBag.Manufacture = manufactureItems;

                User user = db.Users.FirstOrDefault(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();

        }

        

        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            db.Users.Update(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                User user = db.Users.FirstOrDefault(p => p.Id == id);
                if (user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    return RedirectToAction("Privacy");
                }
            }
            return NotFound();
        }
    }
}