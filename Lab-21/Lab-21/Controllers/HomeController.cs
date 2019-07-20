using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab_21.Models;
using Lab_21.Data;

namespace Lab_21.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository _repository;

        public HomeController(IDataRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Registration(int id, RegistrationModel registration)
        {
            if (!ModelState.IsValid)
            {
                return View(registration);
            }


            _repository.Add(registration);
            _repository.Save(id, registration);

            return RedirectToAction("AddUser", "Home");
        }

        public IActionResult AddUser(int id)
        {
            var registration = _repository.Get(id);
            return View(registration);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
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
