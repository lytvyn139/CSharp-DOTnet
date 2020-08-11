using Microsoft.AspNetCore.Mvc;

namespace PortfolioController.Controllers     
{
    public class PortfolioController: Controller   
    {


    [HttpGet("")]
    public IActionResult  Index()
    {
        return View();
    }

    //http://localhost:5000/projects
    [HttpGet("projects")]
    public IActionResult  Project()
    {
        return View();
    }
    //http://localhost:5000/contact
    [HttpGet("contact")]
    public IActionResult  Contact()
    {
        return View();
    }
    //http://localhost:5000/Razor
     [HttpGet("razor")]
    public IActionResult  Razor()
    {
        return View();
    }
}
}

