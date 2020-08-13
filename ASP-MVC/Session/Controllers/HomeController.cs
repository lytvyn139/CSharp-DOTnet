using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Session.Models;


//ADD
using Microsoft.AspNetCore.Http;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //ADDED BLOCK
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null)
            {
                HttpContext.Session.SetInt32("Count", 0);
            }
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            return View();
        }
        //ADD
        [HttpGet("add")]
        public IActionResult Add()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count ++;
            HttpContext.Session.SetInt32("Count", (int)count);
            //return Redirect("/"); //redirect goes to specific URL
            return RedirectToAction("Index"); //pointing to method name
        }

        //SUB
        [HttpGet("sub")]
        public IActionResult Sub()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count --;
            HttpContext.Session.SetInt32("Count", (int)count);
            //return Redirect("/"); //redirect goes to specific URL
            return RedirectToAction("Index"); //pointing to method name
        }

        //REST
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Remove("Count");
            return Redirect("/");
            // HttpContext.Session.Clear(); clears whole session
        }


        //END OF ADDED BLOCK



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
