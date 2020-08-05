using System;
using StarWars.Models;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Character solo = new Character("Hans Solo", 19, "Light", "Earth");
            Character chewbacca = new Character("Chewbacca", 139, "Light", "Kashlyyk");
            Jedi LightVader = new Jedi("Lighth Vader", 35, "Light", "Tatooine", 5000000, "blue", false);
            Sith DarthVader = new Sith("Darth Vader", 55, "Dark", "Tatooine", 500000000, "red", true);
            Jedi ObiWan = new Jedi("Obi Wan", 55, "Light", "Someplace", 5000, "green", true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("***STAR WARS***");
            Console.ResetColor();


            LightVader.UseForce(DarthVader);
            DarthVader.ShowStats();
            LightVader.UseForce(ObiWan);
            ObiWan.ShowStats();
        }
    }
}
