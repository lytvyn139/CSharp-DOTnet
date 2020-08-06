using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }
        //Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override void Attack(Human target)
        {
            int dmg = Intelligence * 5;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} is attacking {target.Name} ({target.Health} HP)");
            target.ApplyDamage(dmg);
            Console.WriteLine($"Hit! {target.Name} takes {dmg} damage, {target.Health} HP left");
            PerformHeal(dmg);
            Console.ResetColor();
        }

        public void Heal(Human target)
        {
            int dmg = Intelligence * 10;
            target.PerformHeal(dmg);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} has healed {target.Name} and now they have {target.Health} health!");
            Console.WriteLine($" public void Heal(Human target) from Wizzard.cs");
            Console.ResetColor();
        }
    }
}