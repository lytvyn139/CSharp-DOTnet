//MyContex.cs in kinda middleware . this is the file we will use to connect to our database.
using Microsoft.EntityFrameworkCore;
using LizardPirates.Models;
namespace LizardPirates.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        // this is the variable we will use to connect to the MySQL table, Lizards
        public DbSet<Lizard> Lizards { get; set; } //DbSet = tables

        //added for pirate 
        public DbSet<Pet> Pets {get; set;}
    }
}