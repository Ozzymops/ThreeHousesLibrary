using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThreeHousesLibrary.Controllers
{
    public class CharacterController : Controller
    {
        // Unaffiliated
        public IActionResult Byleth()
        {
            return View();
        }

        public IActionResult Jeralt()
        {
            return View();
        }

        public IActionResult Sothis()
        {
            return View();
        }

        // Black Eagles
        // Blue Lions
        // Golden Deer
        // Church of Seiros
    }
}