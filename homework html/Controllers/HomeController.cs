﻿using homework_html.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homework_html.Controllers
{
    public class HomeController : Controller
    {
       



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Single()
        {
            return View();
        }
    }
}