﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult MainInfo()
        {
            return View();
        }

        public ViewResult ContactInfo()
        {
            return View();
        }
    }
}
