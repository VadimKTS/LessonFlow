using Lesson15main_2.Dto;
using Lesson15main_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson15main_2.Controllers
{
	public class InventoryController : Controller
	{
		private readonly ILogger<HomeController> _logger;


		GoodsInventoryModel[] goodsInventory;
		public InventoryController(ILogger<HomeController> logger)
		{
			_logger = logger;

			goodsInventory = new GoodsInventoryModel[]
			{
				new GoodsInventoryModel ( 1, "Milk", 100, 100 ),
				new GoodsInventoryModel( 2, "Potato", 500, 550 ),
				new GoodsInventoryModel( 3, "Meat", 67, 60 )
			};
		}

		public IActionResult Inventory() => View( goodsInventory );
		 
		[HttpGet]
		public IActionResult Authorization() => View();

		[HttpPost]
		public IActionResult Authorization(string userName, string password)
        {
            if ( userName.Equals("admin") && password.Equals("admin")) { return Redirect("~/Inventory/Inventory"); }
			else { return Redirect("~/Inventory/Registration"); }
        }

		public IActionResult Registration() => View();
    }
}