﻿using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
