using Microsoft.AspNetCore.Mvc;
using System;


namespace SandwichController.Controllers     
{
    public class SandwichController: Controller   
    {

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string name, string proteinOne, string proteinTwo,  string bread, string instr)
    {
        Console.WriteLine($"{name}, \n {proteinOne} \n {proteinTwo} \n {bread} \b {instr} ");
        ViewBag.Name = name;
        ViewBag.One = proteinOne;
        ViewBag.Two = proteinTwo;
        ViewBag.Bread = bread;
        ViewBag.Instructions = instr;
        ViewBag.CreatedAt = DateTime.Now;
        return View("Sandwich"); //Sandwich.cshml
    }

}
}

