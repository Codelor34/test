﻿using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
            Console.WriteLine("Phuc");
        }
    }
}
