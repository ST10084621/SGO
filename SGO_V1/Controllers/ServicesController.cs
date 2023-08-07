using Microsoft.AspNetCore.Mvc;

namespace SGO_V1.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Rehab()
        {
            return View();
        }

        public IActionResult MissionarySchool()
        {
            return View();
        }

        public IActionResult OtherServices()
        { 
            return View();
        }
    }
}
