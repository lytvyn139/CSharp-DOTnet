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

            // Shinobi.ShowStats();
            // Gendalf.ShowStats();
            // Jack.ShowStats();

            // Shinobi.Attack(Gendalf);
            // Shinobi.Attack(Jack);

            // Gendalf.Attack(Shinobi);
            Gendalf.Attack(Jack);

            Jack.Attack(Gendalf);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);
            Jack.Attack(Shinobi);



        }
    }
}



