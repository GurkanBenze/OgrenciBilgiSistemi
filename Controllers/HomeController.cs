﻿using Microsoft.AspNetCore.Mvc;
using OgrenciBilgiSistemi.Models;
using System.Diagnostics;

namespace OgrenciBilgiSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //endpoint - Action
        //Action => View döndürür (Sayfa döndürür. Yani belirttiğimiz sayfanın UI ekranlarında açılmasını sağlar.)
        public IActionResult Index()
        {
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