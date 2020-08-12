using Microsoft.AspNetCore.Mvc;
using System;
namespace RedirectApp.Controllers     
{
    public class RedirectController : Controller   
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            //localhost:5000/hello
            Console.WriteLine("Hello there, redirecting");
            //return RedirectToAction("Index"); //takes the action name as param

            
            var param = new {username="IURII", location="chicago"};
            return RedirectToAction("HelloUser", param ); //takes the action name as param
            //will redirect to http://localhost:5000/users/IURII/chicago
        }


        [HttpGet("users/{username}/{location}")]
            public string HelloUser(string username, string location)
            {
                if(location == "chicago")
                {
                    return $"Heloo {username} from {location}, so how do you like C# stack so far";
                }   
                    return $"{username} ohhh it you agaain from {location}";
            }
    }
}