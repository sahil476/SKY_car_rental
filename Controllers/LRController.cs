using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SKY_car_rental.Models;

namespace SKY_car_rental.Controllers
{
    public class LRController : Controller
    {

        LRModel objmodel = new LRModel();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {

            if (HttpContext.Session.GetString("UserSession") != null)
            {

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(LRModel user)
        {
            objmodel = new LRModel();
            bool res = objmodel.Login(user);

            if (res)
            {
                HttpContext.Session.SetString("email", user.Email);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "LR");


        }


        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("email") != null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(LRModel user)
        {
            objmodel = new LRModel();
            objmodel.InsertData(user);
            return RedirectToAction("Login", "LR");
        }
    }
}
