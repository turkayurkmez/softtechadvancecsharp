using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WhatTheFViewBag.Models;

namespace WhatTheFViewBag.Controllers
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
            ViewBag.VisitDate = DateTime.Now;
            ViewData["Name"] = "Türkay";
            TempData["LastName"] = "Ürkmez";
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