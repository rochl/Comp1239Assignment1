﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }

    }
}
