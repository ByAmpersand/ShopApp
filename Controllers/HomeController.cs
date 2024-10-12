using Microsoft.AspNetCore.Mvc;
using ShopApp.Models;
using System.Diagnostics;
using ShopApp.Data;

namespace ShopApp.Controllers
{
    public class HomeController : Controller    
    {
        private readonly ILogger<HomeController> _logger;
		private readonly ApplicationDbContext context;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
			this.context = context;
		}

        public IActionResult Index()
        {
            //this method operate to load data in view 

            var items = context.Products.ToList();

            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
