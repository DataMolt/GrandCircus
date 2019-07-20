using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Asessment5c.Models;

namespace Asessment5c.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISession _session;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            if (_session.GetInt32("Quantity") == null)
            {
                _session.SetInt32("Quantity", 0);
            }
            return View();
        }

        public IActionResult Item()
        {
            return View();
        }

        public IActionResult Add()
        {
            int add = (int)_session.GetInt32("Quantity");
            add++;
            _session.SetInt32("Quantity", add);
            ViewData["Quantity"] = _session.GetInt32("Quantity");
            return View("Item");
        }

        public IActionResult Subtract()
        {
            int subtract = (int)_session.GetInt32("Quantity");
            if (subtract != 0)
            {
                subtract--;
            }
            _session.SetInt32("Quantity", subtract);
            ViewData["Quantity"] = _session.GetInt32("Quantity");
            return View("Item");
        }

        public IActionResult Checkout()
        {
            ViewData["Quantity"] = _session.GetInt32("Quantity");
            return View();
        }

        public IActionResult Continue()
        {
            return View("Item");
        }

        public IActionResult Reset()
        {
            _session.SetInt32("Quantity", 0);
            return View("Item");
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
