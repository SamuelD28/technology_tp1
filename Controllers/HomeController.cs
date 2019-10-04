using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using technology_tp1.Models;

namespace technology_tp1.Controllers
{
    public class HomeController : Controller
    {
        private IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
           _localizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewData["Welcome"] = _localizer["Welcome"];
            return View();
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
