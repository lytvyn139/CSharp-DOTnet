using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dojodachi.Models;

using Microsoft.AspNetCore.Http; //ADDED
namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        
        //ADDED
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Fullness") == null)
            {
                HttpContext.Session.SetInt32("Fullness", 20);
            }
            if(HttpContext.Session.GetInt32("Happiness") == null)
            {
                HttpContext.Session.SetInt32("Happiness", 20);
            }
            if (HttpContext.Session.GetInt32("Work") == null)
            {
                HttpContext.Session.SetInt32("Work", 4);
            }
            if (HttpContext.Session.GetInt32("Energy") == null)
            {
                HttpContext.Session.SetInt32("Energy", 50);
            }
              
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Work = HttpContext.Session.GetInt32("Work");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            return View();
        }
        
        [HttpGet("feed")]
        public IActionResult Feed()
        {
            int? countFullness = HttpContext.Session.GetInt32("Fullness");
            countFullness += 5;
            HttpContext.Session.SetInt32("Fullness", (int)countFullness);
            return RedirectToAction("Index"); 
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            int? counterHappy = HttpContext.Session.GetInt32("Happiness");
            counterHappy -= 5;
            if (counterHappy == 0) 
            {
                counterHappy += 5;
            }
            HttpContext.Session.SetInt32("Happiness", (int)counterHappy);
            return RedirectToAction("Index"); 
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            int? counterMeals = HttpContext.Session.GetInt32("Work");
            counterMeals -= 1;
             if (counterMeals == 0) 
            {
                counterMeals += 1;
            }
            HttpContext.Session.SetInt32("Work", (int)counterMeals);
            return RedirectToAction("Index"); 
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            int? counterEnergy = HttpContext.Session.GetInt32("Energy");
            counterEnergy += 7;
            HttpContext.Session.SetInt32("Energy", (int)counterEnergy);
            return RedirectToAction("Index"); 
        }

        //REST
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Remove("Fullness");
            HttpContext.Session.Remove("Happiness");
            HttpContext.Session.Remove("Work");
            HttpContext.Session.Remove("Energy");
            return Redirect("/");
        }

        [HttpGet("utilize")]
        public IActionResult Utilize()
        {
             return View("utilize");
        }

    }
}
