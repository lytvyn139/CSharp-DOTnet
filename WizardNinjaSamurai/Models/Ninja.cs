using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        //Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        //override = overwrite the Attack() from parrent
        // public override void Attack(Human target)
        // {
        //     int dmg = (target.Dexterity * 5) + 10;
        //     return target.ApplyDamage(dmg);

        // }

        public override void Attack(Human target)
        {

            Random rand = new Random();
            int critical = rand.Next(0, 21);
            //int dmg = 0;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} is attacking {target.Name} ({target.Health} HP)");
            if (critical == 20)
            {
                int dmg = (target.Dexterity * 5) + 10;
                target.ApplyDamage(dmg);
                Console.WriteLine($"Ouch! Critical hit! {target.Name} takes {dmg} damage! {target.Health} HP left");
            }
            else if (critical > 4)
            {
                int dmg = target.Dexterity * 5;
                target.ApplyDamage(dmg);
                Console.WriteLine($"Hit! {target.Name} takes {dmg} damage,  {target.Health} HP left");
            }
            else
            {
                Console.WriteLine($"Oops! {Name} missed!");
            }
            Console.ResetColor();
        }

        //Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.
        public void Steal(Human target)
        {
            int dmg = 5;
            target.ApplyDamage(dmg);
            health += 5;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} has stolen 5 health from {target.Name}!");
            Console.WriteLine($"{target.Name} now has {target.Health} health, {Name} now has {health} health.");
            Console.ResetColor();
        }
    }
}