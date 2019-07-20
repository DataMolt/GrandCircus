using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assessment5a.Models;

namespace Assessment5a.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            if (login.Password == "open sesame")
            {
                return RedirectToAction("Welcome", "Home", login);
            }
            else
            {
                return RedirectToAction("WrongPassword", "Home");
            }
        }

        public IActionResult Welcome(LoginModel login)
        {
            ViewBag.Name = login.Name.ToUpper();
            ViewBag.Length = login.Name.Length;
            return View();
        }

        public IActionResult WrongPassword(LoginModel login)
        {
            return View(login);
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
