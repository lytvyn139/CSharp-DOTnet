# Entity Framework Core

## Tools: dotnet-ef
Before we can start working with Entity Framework, we need to install the following tool...
```
dotnet tool install dotnet-ef --global
```
## New app
```
dotnet new mvc --no-https -o CRUDelicious
```

## Adding Packages
The "Pomelo" package will be the provider that let's us connect our project to a MySQL database. We also need to get the EntityFrameworkCode.Design package.
Note: Each time we start a new project we will need to run these commands to install EntityFramework.
```cs
cd CRUDelicious
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.5
```

## Making a Model

Once installed we need to create a model Models/Dish.cs that we can use to be a table in our database.
``` cs
using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models 
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        
        [Required(ErrorMessage="Chef's name is required")]
        public string Name {get;set;}

        [Required(ErrorMessage="Dish name is required")]
        public string DishName {get; set;}

        [Required(ErrorMessage="Calories are required")]
        [Range(1, 3000)]
        public int Calories {get; set;}

        [Required(ErrorMessage="Tastiness is required")]
        [Range(1,5)]
        public int Tastiness {get; set;}

        [Required(ErrorMessage="Description is required")]
        public string Description {get;set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}

```

## Making a Contexts

Next we need to create a context class Contexts/MyContext.cs... 
``` cs
//MyContex.cs in kinda middleware . this is the file we will use to connect to our database.
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;
namespace CRUDelicious.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes { get; set; } //DbSet = tables
        // this is the variable we will use to connect to the MySQL table
    }
}

```
## Modifying Startup
``` cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Microsoft.EntityFrameworkCore;//added
using CRUDelicious.Contexts;       //added
using CRUDelicious.Models;

namespace CRUDelicious
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //services.AddSession(); //added
            services.AddDbContext<MyContext>(o => o.UseMySql (Configuration["DBInfo:ConnectionString"])); //added
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseSession(); //added
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

```

## Setting up appsettings
We also need to modify our appsettings.json to include "DBInfo"...
```cs
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "DBInfo":
  {
    "Name": "MySQLconnect",
    "ConnectionString": "server=localhost;userid=root;password=root;port=3306;database=dishes;SslMode=None"
  }
}
```
# Make sure you change the mydb to whatever you want your schema to be called !!!

## Controller 
Next we need to dependency inject our MyContext into our HomeController class...
```cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using CRUDelicious.Models; //added
using CRUDelicious.Contexts; //added
namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        //dependency inject our MyContext into our HomeController
        private MyContext dBContext; //instance of context class
        public HomeController(MyContext context)
        {
            dBContext = context;
        }
        //end of dependency inject our MyContext into our HomeController
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        //***** MY ROUTES HERE 
        //....
        //***** END OF MY ROUTES HERE 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

```

## Migrating our Database
We need to create the appropriate schema in our database...
```
dotnet ef migrations add initial -v
dotnet ef database update -v
```
## Build Index.cshtml
/Home/Index.cshtml
Remove auto generated footer and header from _Layout.cshtml. Build form in Index.cshtml. Save and run it, the routes not there yet, but at this moment you should see the front.
```cs
@{
    ViewData["Title"] = "Add";
}
@model Dish

<form class="col-5 mx-auto" action="/process" method="post">
    <div class="text-center">
        <h1>Add a new dish:</h1>
    </div>    
    <div class="form-group">
        <label asp-for="Name">Chef's Name: </label>
        <input asp-for="Name" class="form-control">
    </div>
    <span asp-validation-for="Name" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="DishName">Name of a dish:</label>
        <input asp-for="DishName" class="form-control">
    </div>
    <span asp-validation-for="DishName" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Calories"># of calories (3000 max):</label>
        <input asp-for="Calories" class="form-control">
    </div>
    <span asp-validation-for="Calories" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Tastiness">Tastiness (1-5):</label>
        <input asp-for="Tastiness" class="form-control">
    </div>
    <span asp-validation-for="Tastiness" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Description">Description:</label>
        <textarea asp-for="Description" class="form-control" cols="30" rows="3"></textarea>
    </div>
    <span asp-validation-for="Description" class="text-danger"></span>
    <div class="text-center">
        <input type="submit" class="btn btn-success" value="ADD">
    </div>
    
</form>
```

## Build Dishes.cshtml to show show dishes on the page
/Home/Dishes.cshtml
```cs
@model List<Dish>

<table class="table table-hover">
    <thead>
        <tr class="text-center">
            <th>Chef's name: </th>
            <th>Dish name: </th>
            <th>Calories: </th>
            <th>Tastiness: </th>
            <th>Description: </th>
            <th>Created on: </th>
            <th>Updated at: </th>
        </tr>
    </thead>
    <tbody>
        @foreach (Dish d in Model)
        {
            <tr class="text-center">
                <td>@d.Name</td>
                <td>@d.DishName</td>
                <td>@d.Calories</td>
                <td>@d.Tastiness</td>
                <td>@d.Description</td>
                <td>@d.CreatedAt</td>
                <td>@d.UpdatedAt</td>
                <td>
                    <a href="/edit/@d.DishId" class="btn btn-warning">Edit </a>
                </td>
               <td>
                    <a href="/delete/@d.DishId" class="btn btn-danger">Delete </a>
                </td>
            </tr>
        }
    </tbody>
</table>
<div class="text-center">
    <a href="/" class="btn btn-success">Home</a>
</div>
```
## Add routes to HomeControlle.cs
At this momemnt you  are abble to add dishes to your db, and see it on http://localhost:5000/Dishes
```cs
     //***** MY ROUTES HERE 

        //PROCESS
        [HttpPost("process")]
        public IActionResult Process(Dish newbie)
        {
            if(ModelState.IsValid)
            {
                dBContext.Dishes.Add(newbie);
                dBContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else 
            {
                return View("Index"); 
            }
        }

        //SHOW ALL Dishes
        [HttpGet("Dishes")]
        public IActionResult Dishes()
        {
            // link queries
            List<Dish> AllDishes = dBContext.Dishes.ToList();
            return View(AllDishes);
        }
        //***** END OF MY ROUTES HERE 
```
## Add Edit page
pretty much same as Index.cshtml but don't forget to add <input type="hidden" asp-for="DishId" value="@Model.DishId">
```cs
@{
    ViewData["Title"] = "Edit dish";
}
@model Dish

@* will create copy *@
@* <form class="col-5 mx-auto" action="/update" method="post"> *@
<form class="col-5 mx-auto" action="/update" method="post">
    <h1>Edit dish:</h1>
    <input type="hidden" asp-for="DishId" value="@Model.DishId">
    <div class="form-group">
        <label asp-for="Name">Chef's Name:</label>
        <input asp-for="Name" class="form-control">
    </div>
    <span asp-validation-for="Name" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="DishName">Name of a dish:</label>
        <input asp-for="DishName" class="form-control">
    </div>
    <span asp-validation-for="DishName" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Calories"># of calories (3000 max):</label>
        <input asp-for="Calories" class="form-control">
    </div>
    <span asp-validation-for="Calories" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Tastiness">Tastiness (1-5):</label>
        <input asp-for="Tastiness" class="form-control">
    </div>
    <span asp-validation-for="Tastiness" class="text-danger"></span>

    <div class="form-group">
        <label asp-for="Description">Description:</label>
        <textarea asp-for="Description" class="form-control" cols="30" rows="3"></textarea>
    </div>
    <span asp-validation-for="Description" class="text-danger"></span>
    <div class="text-center">
        <input type="submit" class="btn btn-warning" value="CHANGE">
    </div>
</form>
```
## Add Edit Update Routes
So final HomeController.cs will be like that
