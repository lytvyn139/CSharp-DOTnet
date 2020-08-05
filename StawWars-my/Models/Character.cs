using System;

namespace StarWars.Models
{
    public class Character
    {
        public string Name;
        public string ForceSide;

        public string HomePlanet;
        public int age;
        //protected same privacy levels as private, but still have the abitility to be protected
        protected int health;

        //////////
        public Character(string name, int age, string side, string planet)
        {
            Name = name;
            ForceSide = side;
            HomePlanet = planet;
            this.age = age;
            health = 100;
        }
        //////////
        //make that available to be overriden, it doesn't mean it has to be, but it can
        // it is in Jedi.cs ln17
        public virtual int Attack(Character target)
        {
            if (target != this)
            {
                int dmg = 5;
                target.health -= dmg;
                Console.WriteLine("attacking ! attacking ! attacking !");
                return target.health;
            }
            Console.WriteLine("Can't attack that");
            return -1;
        }
        //////
        public void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n Name: {Name} \n Age: {age} \n ForceSide: {ForceSide} \n Home Planet: {HomePlanet} \n Health: {health}");
            Console.ResetColor();
        }

        //method for use protected, Char.cs ln13
        //maintained the privacy levels of this protected value
        public int TakeDamage(int dmg)
        {
            health += dmg;
            return health;
        }
        //end of method to use protected

    }
}
