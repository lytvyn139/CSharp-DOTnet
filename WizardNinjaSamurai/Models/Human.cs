using System;
namespace WizardNinjaSamurai.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;

        public int Health
        {
            get { return health; }
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
        //virtual can be called from the child class
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void ShowStats()
        {
            Console.WriteLine($" name: {Name} \n strength: {Strength} \n intelligence: {Intelligence} \n dexterity: {Dexterity} \n health: {health} \n");
        }

        public int ApplyDamage(int dmg)
        {
            return health -= dmg;
        }
        public int PerformHeal(int dmg)
        {
            return health += dmg;
        }
        //METHODS END

    }
}

