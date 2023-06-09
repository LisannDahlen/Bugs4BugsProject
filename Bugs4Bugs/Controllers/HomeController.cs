﻿using Bugs4Bugs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bugs4Bugs.Controllers
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
            return View();
        }

        [HttpGet("/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("/OurMission")]
        public IActionResult OurMission()
        {
            return View();
        }

        [HttpGet("/GetStarted")]
        public IActionResult GetStarted()
        {
            return View();
        }
        
        [HttpGet("/OurProduct")]
        public IActionResult OurProduct()
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