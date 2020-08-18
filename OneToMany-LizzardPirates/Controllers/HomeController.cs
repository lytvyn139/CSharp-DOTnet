using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LizardPirates.Models;
using Microsoft.EntityFrameworkCore;

using LizardPirates.Contexts; //added
namespace LizardPirates.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        private MyContext dBContext;
        public HomeController(MyContext context)
        {
            dBContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        //PROCESS
        [HttpPost("process")]
        public IActionResult Process(Lizard newbie)
        {
            if(ModelState.IsValid)
            {
                dBContext.Lizards.Add(newbie);
                dBContext.SaveChanges();
                return RedirectToAction("Lizards");
            }
            else 
            {
                return View("Index"); //error message 
            }
        }

        //SHOW ALL LIZARDS
        [HttpGet("Lizards")]
        public IActionResult Lizards()
        {
                     //order by name
            List<Lizard> Crew = dBContext.Lizards
                .Include(l => l.MyPets )
                .ToList();
            ViewBag.Pets = dBContext.Pets
                .Include(p => p.Owner)
                .ToList();

            // //order by name
            // List<Lizard> Crew = dBContext.Lizards
            //         .OrderBy(l => l.Name).ToList();


            //order by creationg aka ID
            // List<Lizard> Crew = dBContext.Lizards
            //         .ToList();

            
            // //order by type
            // List<Lizard> Crew = dBContext.Lizards
            //     .OrderByDescending(l => l.Name)
            //     .ThenBy(l => l.PirateRole)
            //     .ToList();

            // order by tresure PirateRole + TreasureChests
            // List<Lizard> Crew = dBContext.Lizards
            //     .OrderByDescending(l => l.PirateRole)
            //     .ThenBy(l => l.TreasureChests)
            //     .ToList();

            // order by tresure chest size
            // List<Lizard> Crew = dBContext.Lizards
            //     .OrderByDescending(l => l.TreasureChests)
            //     .ToList();
    
            //display pirateRole sailor
            // List<Lizard> Crew = dBContext.Lizards
            //     .Where(l => l.PirateRole == "sailor")
            //     .ToList();

            //display everything starts with G
            // List<Lizard> Crew = dBContext.Lizards
            //     .Where(l => l.Name.StartsWith("G"))
            //     .ToList();
            
            //display only first 3
            // List<Lizard> Crew = dBContext.Lizards
            //     .Take(3)
            //     .ToList();

            return View(Crew);
        }

        
        //EDIT ROUTE
        [HttpGet("edit/{lizardId}")] //lower key var comming from a rout
        public IActionResult Edit(int lizardId)
        {
            //Queries the data base for the lizard that has same id as lizardId
            Lizard Edit = dBContext.Lizards.FirstOrDefault(l => l.LizardId == lizardId); //Lizard table 
            //LizardId it's a class in Lizard.cs
            return View (Edit);
        }
         
        //UPDATE ROUTE
        [HttpPost("update")]
        public IActionResult Update(Lizard update)
        {
            if(ModelState.IsValid)
            {
                Lizard lToUpdate = dBContext.Lizards.FirstOrDefault(l => l.LizardId == update.LizardId);
                lToUpdate.Name = update.Name;
                lToUpdate.LizardType = update.LizardType;
                lToUpdate.PirateRole = update.PirateRole;
                lToUpdate.TreasureChests = update.TreasureChests;
                //lToUpdate.UpdatedAt = DateTime.Now();
                dBContext.SaveChanges();
                return RedirectToAction("Lizards");
            }
            else
            {
                return View("Edit", update);
            }
        }
       
        //DELETE 
        [HttpGet("delete/{lizardId}")]
        public IActionResult Delete(int lizardId)
        {
            Lizard walkThePlank = dBContext.Lizards.FirstOrDefault(l => l.LizardId == lizardId);
            dBContext.Lizards.Remove(walkThePlank);
            dBContext.SaveChanges();
            return RedirectToAction("Lizards");
        }

        //PET ROUTES
        [HttpGet("new/pet")]
        public IActionResult NewPet(int lizardId)
        {
          ViewBag.Lizards = dBContext.Lizards.ToList();
          return View();
        }

        [HttpPost("create/pet")]
        public IActionResult CreatePet(Pet newPet)
        {
          if(ModelState.IsValid)
          {
            dBContext.Pets.Add(newPet);
            dBContext.SaveChanges();
            return Redirect("/lizards");
          }
          else 
          {
            ViewBag.Lizards = dBContext.Lizards.ToList();
            return View("NewPet");
          }
          
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
