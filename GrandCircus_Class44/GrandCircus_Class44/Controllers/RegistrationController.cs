using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrandCircus_Class44.Models;
using Microsoft.AspNetCore.Mvc;

namespace GrandCircus_Class44.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registration(RegistrationModel registration)
        {
            if (!ModelState.IsValid)
            {
                return View(registration);
            }

            return RedirectToAction("AddUser", "Registration");
        }

        public IActionResult AddUser(RegistrationModel registration)
        {
            return View(registration);
        }
    }
}