﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AisMKIT.Models;
using NLog;

namespace AisMKIT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        //Test
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            List<string> countries = new List<string> { "Кыргызстан", "Россия" };
            logger.Debug("Hello from Home Controller...");
            return View(countries);
        }

        public IActionResult DepDCAE()
        {
            return View();
        }

        public IActionResult DepSI()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            logger.Debug("Hello from Privacy Controller...");
            return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
