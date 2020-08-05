using System;
using Humanoid.Models;
namespace Humanoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Humanoid OOP!");
            Human Cris = new Human("Cris");
            Human Marry = new Human("Marry");
            Human Bob = new Human("Bob", 100, 20, 1000, 200);
            Cris.Attack(Marry);
            Cris.ShowStats();
            Bob.ShowStats();
        }
    }
}
