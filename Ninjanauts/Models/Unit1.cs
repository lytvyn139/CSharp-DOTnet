using System;
using Ninjanauts.Interfaces;

namespace Ninjanauts.Models
{
    public class Unit1 : Ninjanaut
    {
        public Unit1(string name) : base(name) { }
        public override bool IsFull
        {
            get
            {
                if (calorieIntake >= 500)
                {
                    //Console.WriteLine("(stopping cond for unit1) \n");
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
                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{Name} that book is too hard !!! (-5 points to brain power)\n");
                    Console.ResetColor();
                }
                ConsumptionHistory.Add(item);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("ᕙ(▀̿̿Ĺ̯̿̿▀̿ ̿) ᕗ SAM is learning: ");
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