using System;
using WizardNinjaSamurai.Models;
namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* INIT *");
            Ninja Shinobi = new Ninja("Shinobi");
            Wizard Gendalf = new Wizard("Gendalf");
            Samurai Jack = new Samurai("Jack");
            Gendalf.ShowStats();
            Jack.Attack(Gendalf);
            Gendalf.ShowStats();
        }
    }
}

