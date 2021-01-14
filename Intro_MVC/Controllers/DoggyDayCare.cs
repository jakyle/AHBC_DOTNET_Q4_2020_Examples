using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Intro_MVC.Models.DoggyDayCare;
using Microsoft.AspNetCore.Mvc;

namespace Intro_MVC.Controllers
{
    public class DoggyDayCareController : Controller
    {
        // localhost:5001/DoggyDayCare/Form
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult FormResult(FormResultViewModel model)
        {
            // do some math and shit
            return View(model);
        }
    }
}
