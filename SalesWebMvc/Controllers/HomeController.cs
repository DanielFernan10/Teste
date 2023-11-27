﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System.Diagnostics;
using SalesWebMvc.Models.ViewModel;

namespace SalesWebMvc.Controllers
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
            ViewData["Menssage"] = "Salles web MVC app from C# course";
            ViewData["Aluno"] = "Daniel Fernandes";
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
