using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ThreeHousesLibrary.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Byleth()
        {
            return View();
        }
    }
}