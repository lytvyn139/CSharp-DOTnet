using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCoolSite.Models;

namespace MyCoolSite.Controllers
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
        
        //ADDED BLOCK
        public IActionResult Index()
        {
            string welcome = "Welcome to My Cool Site";
            return View("Index",welcome);
        }
        //localhost/process

        [HttpPost("process")] //if from <form> index.cshtml
        public IActionResult Process(Sandwich newSand)
        {
            Console.WriteLine(newSand.Name);
            return View("Results",newSand); //Views/Home/Results.cshtml
        }
    }
}
