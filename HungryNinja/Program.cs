using System;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("༼ ༽ RICE BUFFET ༼ ༽");
            Console.WriteLine("you ate all my food ninja !!!");
            Console.ResetColor();
            Ninja client = new Ninja();
            Buffet buffet = new Buffet();

            while (!client.IsFull)
            {
                client.Eat(buffet.Serve());
            }
            client.Eat(buffet.Serve());
        }
    }
}
