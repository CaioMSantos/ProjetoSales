﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoSalesMVC.Controllers
{
    public class SalesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
