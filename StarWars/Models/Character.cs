using System;

namespace StarWars.Models
{
    public class Character
    {
        public string Name;

        private int age;

        public string ForceSide;

        public string HomePlanet;

        protected int health;

        public Character(string name, int age, string side,string planet)
        {   
            Name = name;
            this.age = age;
            ForceSide = side;
            HomePlanet = planet;
            health = 100;
        }

        public virtual int Attack(Character target)
        {
            if(target != this)
            {
                int dmg = 5;
                target.health -= dmg;

                Console.WriteLine("Pkew PKew Pkew!!!");
                return target.health;
            }
            Console.WriteLine("Stop hitting yourself");
            return -1;
            
        }

        public void ShowStats()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Name: {Name}\n\tAge: {age}\nForce Side: {ForceSide}\nHome Planet: {HomePlanet}\nHealth: {health}");
            Console.ResetColor();
        }

        public int TakeDamage(int dmg)
        {
            health += dmg;
            return health;
        }




    }
}