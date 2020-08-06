using System;

namespace WizardNinjaSamurai.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override void Attack(Human target)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} is attacking {target.Name} ({target.Health} HP)");
            Console.ResetColor();
            if (target.Health <= 50)
            {
                int dmg = target.Health;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"health < 50");
                Console.WriteLine($"Hit! {target.Name} takes {dmg} damage,  {target.Health} HP left");
                target.ApplyDamage(dmg);
                Console.ResetColor();
                //Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! {target.Name} now has {target.health} HP");

            }
            else
            {
                base.Attack(target);
            }

        }
        //Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public void Meditate()
        {
            int dmg = 200;
            PerformHeal(dmg);
            Console.WriteLine($"{Name} has recovered health!");

            //return Health;
        }
    }
}


