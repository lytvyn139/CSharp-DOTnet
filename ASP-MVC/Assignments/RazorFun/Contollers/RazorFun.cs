using Microsoft.AspNetCore.Mvc;

namespace RazonFun.Controllers     
{
    public class RazonFun: Controller   
    {

    [HttpGet("")]
    public ViewResult Index()
    {
        return View();
    }
   
}
}

