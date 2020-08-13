using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
    [HttpGet("")]     
    public IActionResult Index()
    {
        return View();
    }
    }
}