using System;
/* 
- why do we have to have two constr
- line 16 
 */
namespace Humanoid.Models
{
    public class Human
    //fields
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        //fields

        // constr
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;

        }

        public Human(string name, int strenth, int brain, int speed, int hp)

        {
            //field - receiving
            Name = name;
            Strength = strenth;
            Intelligence = brain;
            Dexterity = speed;
            health = hp;
        }
        // constr

        //methodі
        public void Attack(Human target)
        {
            Human enemy = target as Human;
            if (enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= Strength * 5;
                Console.WriteLine("We are under attack");

            }
        }
        public void ShowStats()
        {
            Console.WriteLine($" Name: {Name}, strength {Strength}, intelligence {Intelligence},  dexterity {Dexterity}, health {health} ");
        }

        //methodі
    }



}

