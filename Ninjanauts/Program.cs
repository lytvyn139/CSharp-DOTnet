using System;
using Ninjanauts.Interfaces;
using Ninjanauts.Models;

namespace Ninjanauts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___) \n");
            Console.WriteLine("                     .-\"\"\"\"-.        .-\"\"\"\"-. \n");
            Console.WriteLine("                    /        \\      /        \\ \n");
            Console.WriteLine("                   /_        _\\    /_        _\\ \n");
            Console.WriteLine("                  // \\      / \\   // \\      / \\ \n");
            Console.WriteLine("                  |\\__\\    /__/|  |\\__\\    /__/| \n");
            Console.WriteLine("                   \\    ||    /    \\    ||    /\\ \n");
            Console.WriteLine("                    \\        /      \\        /\n");
            Console.WriteLine("                     \\  __  /        \\  __  /  \n");
            Console.WriteLine("                      '.__.'          '.__.' \n");
            Console.WriteLine("                       |  |            |  |\n");
            Console.WriteLine("                       |  |            |  |\n");
            Console.WriteLine("                         👽 Ninjanauts 👽 \n");
            Console.WriteLine("\n");
            Console.WriteLine("(_ ___)-._.-=-._.-=-._.-=-._.-=-._.-=-._.._.-=-._.-=-._.-=-._.-=-._.-=-._.-=-._.-(_ ___) \n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Planet Earth 🌍 year 2020... \n \n  Earth is corrupted with viruses and pollution, \n we have no choice left, but to send some brave people to space, \n their journey might not be successful, but they are our only hope... \n");
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("So far we have two candidates, let's see who is smarter, the will be the \"chose one\", he will be sent to space \n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

            Console.Clear();
            Library word = new Library();
            Unit1 unit1 = new Unit1("ᕙ(▀̿̿Ĺ̯̿̿▀̿ ̿) ᕗ SAM the nerd");
            Unit2 unit2 = new Unit2("(‡▼益▼) geeky JACK");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Let's the epic battle begin \n");
            Console.WriteLine($"{unit1.Name} vs. {unit2.Name} \n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();

            //Console.Clear();
            while (!unit2.IsFull || !unit1.IsFull)
            {
                unit1.Consume(word.Serve());
                unit2.Consume(word.Serve());
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"{unit1.Name} learned {unit1.ConsumptionHistory.Count} books & {unit2.Name} learned {unit2.ConsumptionHistory.Count} books \n");

            Console.WriteLine("Press any key to continue...\n");
            Console.ReadKey();
            Console.Clear();

            if (unit1.ConsumptionHistory.Count > unit2.ConsumptionHistory.Count)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Mewnwhile in space...music plays\n");
                Console.WriteLine("Ground control to major tom ♪ ♪ ♪ \n  take your protein pills and put your helmet on...  ♫ ♫ ♫ \n our ninjanaut 🙭 is in space!...\n");
                Console.WriteLine($"The earth is saved...ninjanaut 🙭 {unit1.Name} is in space!");
                Console.ResetColor();

            }
            else if (unit2.ConsumptionHistory.Count > unit1.ConsumptionHistory.Count)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Mewnwhile in space...music plays\n");
                Console.WriteLine("Ground control to major tom ♪ ♪ ♪ \n  take your protein pills and put your helmet on...  ♫ ♫ ♫ \n our ninjanaut 🙭 is in space!...\n");
                Console.WriteLine($"The earth is saved...ninjanaut 🙭 {unit2.Name} is in space!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"It looks to be like ☠ ninjanauts ☠ are both equal dumb \n the Earth is doomed, sorry for your loss ☠ ");
                Console.ResetColor();
                Console.ResetColor();
            }

            // Console.Clear();


            // Console.WriteLine("Press any key to continue...\n");
            // Console.ReadKey();


        }

    }
}
