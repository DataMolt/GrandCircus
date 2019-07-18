using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrandCircus_Class44.Controllers
{
    public class GetSetController : Controller
    {
        private readonly ISession _session;

        public GetSetController(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Get()
        {
            return View();
        }

        public IActionResult Set()
        {
            ViewData["Ticks"] = DateTime.Now.Ticks;
            TempData["Ticks"] = DateTime.Now.Ticks;
            _session.SetString("Ticks", DateTime.Now.Ticks.ToString());
            ViewData["Cool"] = _session.GetString("Ticks");
            return RedirectToAction("Get");
        }
    }
}