using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThreeHousesLibrary.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Commoner()
        {
            return View();
        }

        public IActionResult Noble()
        {
            return View();
        }
    }
}