using Microsoft.AspNetCore.Mvc;
using SKY_car_rental.Models;
using System.Diagnostics;

namespace SKY_car_rental.Controllers
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

        public IActionResult Cars()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Payment2()
        {
            return View();
        }
        public IActionResult Payment3()
        {
            return View();
        }
        public IActionResult Payment4()
        {
            return View();
        }
        public IActionResult Payment5()
        {
            return View();
        }
        public IActionResult Payment6()
        {
            return View();
        }
        public IActionResult Payment7()
        {
            return View();
        }
        public IActionResult Payment8()
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
