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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{Name}({health} HP) is attacking {target.Name} ({target.Health} HP)");
            Console.ResetColor();
            if (target.Health <= 0)
            {
                Console.WriteLine($"Please Stop !!! That poor {target.Name} already dead ☠  \n");
            }
            else if (target.Health <= 50)
            {
                int dmg = target.Health;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{target.Name} your weakness disgusts me, your HP is <50 I'm gonna drain your soul: {target.Name} takes {dmg} damage, {target.Health} HP left");
                target.ApplyDamage(dmg);
                Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} did meditation & recovered his health");
            Console.ResetColor();
        }
    }
}


