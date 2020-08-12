using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }

    [HttpGet("another")]
    public ViewResult Another()
    {
        return View();
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
        string[] users = new string[] 
        {
            "User1",
            "User2",
            "User3",
            "User4"
        };
        ViewBag.Users = users;
        return View();
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