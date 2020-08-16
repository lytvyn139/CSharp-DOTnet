using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//adding
using PassGen.Models;
using Microsoft.AspNetCore.Http;
using System.Text;
//adding
namespace PassGen.Controllers
{
     public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("PasscodeNumber") == null)
            {
                HttpContext.Session.SetInt32("PasscodeNumber", 1);
            }
            if (HttpContext.Session.GetString("GeneratedPasscode") == null)
            {
                Random rand = new Random();
                StringBuilder builder = new StringBuilder();
                char ch;
                for (int i = 0; i < 14; i++)
                {
                    int option = rand.Next(0, 2);
                    if (option == 0)
                    {
                        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                        builder.Append(ch);
                    }
                    else
                    {
                        int RandomDigit = rand.Next(1, 10);
                        builder.Append(RandomDigit);
                    }
                }
                string GeneratedPasscode = builder.ToString();
                HttpContext.Session.SetString("GeneratedPasscode", GeneratedPasscode);
            }

            ViewBag.GeneratedPasscode = HttpContext.Session.GetString("GeneratedPasscode");
            ViewBag.PasscodeNumber = HttpContext.Session.GetInt32("PasscodeNumber");
            return View();
        }

        [HttpPost("")]
        public IActionResult GeneratePasscode()
        {
            int? Passcode = HttpContext.Session.GetInt32("PasscodeNumber"); 
            int NewPasscode = Passcode ?? default(int); 
            HttpContext.Session.SetInt32("PasscodeNumber", NewPasscode + 1); 
            Random rand = new Random();
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < 10; i++)
            {
                int option = rand.Next(0, 2);
                if (option == 0)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                    builder.Append(ch);
                }
                else
                {
                    int RandomDigit = rand.Next(1, 10);
                    builder.Append(RandomDigit);
                }
            }
            string GeneratedPasscode = builder.ToString();
            HttpContext.Session.SetString("GeneratedPasscode", GeneratedPasscode);
            return RedirectToAction("Index");
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
