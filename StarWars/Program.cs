using System;
using StarWars.Models;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******STAR WARS******");
            Console.ResetColor();

            Character solo = new Character("Hans Solo",31,"Light","Coriella");
            Character chewbacca = new Character("Chewy",138,"Light","Kashyyyk");
            solo.ShowStats();
            chewbacca.Attack(solo);
            solo.ShowStats();
            solo.Attack(solo);

            Jedi LightVader = new Jedi("Lighth Vader",35,"Light","Tatooine",5000000,"blue",false);

            Sith DarthVader = new Sith("Darth Vader",35,"Dark","Tatooine",500000000,"red",true);
            
            Jedi ObiWan = new Jedi("Obi Wan",55,"Light","Someplace",5000,"green",true);
            LightVader.UseForce(DarthVader);
            DarthVader.ShowStats();
            LightVader.UseForce(ObiWan);

            ObiWan.ShowStats();


            object[] things = new object[]
            {
                "Hello",
                123,
                true
            };

            foreach(object obj in things)
            {
                if(obj is int)
                {
                    int add = 6;
                    add += (int)obj;
                    Console.WriteLine($"This is an integer. {add}");
                }
                if(obj is string)
                {
                    Console.WriteLine("this is a string");
                }
                if(obj is bool)
                {
                    Console.WriteLine("this is a bool");
                }

            }

            // DarthVader.ShowStats();
        }
    }
}
