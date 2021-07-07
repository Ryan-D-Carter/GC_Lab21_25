using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GC_Lab21_25.Models;

namespace GC_Lab21_25.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult RegistrationPage()
        {
            return View(new Movie());
        }

        public IActionResult Results(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View("RegistrationPage", movie);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
