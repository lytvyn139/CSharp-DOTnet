using System;
using Ninjanauts.Interfaces;

namespace Ninjanauts.Models
{
    public class Unit2 : Ninjanaut
    {
        public Unit2(string name) : base(name) { }
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 500)
                {
                    //Console.WriteLine("(stopping cond for unit2) \n");
                    return true;
                }
                return false;
            }
        }
        public override void Consume(ILearnable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{Name} screams: yes please more of that (+ 10 points to my brain power) \n");
                    Console.ResetColor();
                }
                ConsumptionHistory.Add(item);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("(‡▼益▼) JACK  is learning: ");
                Console.WriteLine(item.GetInfo());
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Name} says: My brain hurts cant study anymore \n");
                Console.ResetColor();

            }
        }

    }
}