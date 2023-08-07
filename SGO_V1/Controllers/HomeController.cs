using Microsoft.AspNetCore.Mvc;
using SGO_V1.Models;
using System.Diagnostics;

namespace SGO_V1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Team()
		{
			return View();
		}

		public IActionResult Contact()
		{ 
			return View();
		}

		public IActionResult Donate()
		{
			return View();
		}

        public IActionResult Testimonials()
        {
            return View();
        }

        public IActionResult Index2()
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