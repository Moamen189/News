﻿using Microsoft.AspNetCore.Mvc;

namespace News.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
