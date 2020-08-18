//MyContex.cs in kinda middleware . this is the file we will use to connect to our database.
using Microsoft.EntityFrameworkCore;
using SpaceCrabs.Models;
namespace SpaceCrabs.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        // this is the variable we will use to connect to the MySQL table, Lizards
        public DbSet<Crab> Crabs { get; set; } //DbSet = tables

        //after creating planet.cs add table to db and update
        public DbSet<Planet> Planets {get; set;}
    }
}