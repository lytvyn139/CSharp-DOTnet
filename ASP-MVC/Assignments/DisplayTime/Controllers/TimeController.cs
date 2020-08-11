using Microsoft.AspNetCore.Mvc;
namespace DisplayTime.Controllers
{
    public class ClockController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Clock()
        {
            //Views/Clock/index.cshtml
            return View("index");
        }
    }
}