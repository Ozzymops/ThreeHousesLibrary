﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeHousesLibrary.Models;

namespace ThreeHousesLibrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Characters()
        {
            return View();
        }

        public IActionResult Crests()
        {
            return View();
        }

        public IActionResult Classes()
        {
            return View();
        }

        public IActionResult Abilities()
        {
            return View();
        }

        public IActionResult CombatArtsAndSpells()
        {
            return View();
        }

        public IActionResult Routes()
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
