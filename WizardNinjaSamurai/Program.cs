using System;
using WizardNinjaSamurai.Models;
namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("* INIT *");
            Ninja Shinobi = new Ninja("Ninja");
            Wizard Gendalf = new Wizard("Wizzard");
            Samurai Jack = new Samurai("Samurai");

            Shinobi.ShowStats();
            Gendalf.ShowStats();
            Jack.ShowStats();

            // // **** NINJA BLOCK ***


            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Shinobi.Attack(Jack);
            // Jack.ShowStats();
            // Shinobi.Attack(Gendalf);
            // Shinobi.Attack(Gendalf);
            // Shinobi.Steal(Gendalf);
            // Shinobi.ShowStats();
            // // *** END OF NINJA BLOCK ***

            // // *** SAMURAI BLOCK ***


            // Jack.Attack(Gendalf);
            // Jack.Attack(Gendalf);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Attack(Shinobi);
            // Jack.Meditate();
            // Jack.ShowStats();
            // // *** SAMURAI BLOCK ***


            // *** END OF WIZZARD BLOCK ***


            // Gendalf.Attack(Jack);
            // Console.WriteLine("Okay that's enought Gendalf !");
            // Jack.ShowStats();
            // Gendalf.Attack(Shinobi);
            // Shinobi.ShowStats();
            // Console.WriteLine("c'mon dude that was a prank");
            // Gendalf.Heal(Shinobi);
            // Shinobi.ShowStats();
            // *** END OF WIZZARD BLOCK ***

        }
    }
}



