using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int Health
        {
            get
            {
                return health;
            }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        //METHODS START
        public void ShowStats()
        {
            Console.WriteLine($"{Name}: \n             strength: {Strength}   intelligence: {Intelligence}   dexterity: {Dexterity}   health: {health} \n");
        }

        //virtual can be called from the child class
        public virtual void Attack(Human target)
        {
            int dmg = Strength * 3; //the default Strength is 3
            target.ApplyDamage(dmg);
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage! {target.Name} now has {target.health} HP");
            Console.ResetColor();
        }
        public void ApplyDamage(int dmg)
        {
            health -= dmg;
        }
        public void PerformHeal(int dmg)
        {
            health += dmg;
        }
        //METHODS END

    }
}

