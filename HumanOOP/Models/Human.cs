using System;
/* 
- why do we have to have two constr
- line 16 
 */
namespace HumanOOP
{
    public class Human
    //fields
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health
        {
            get
            {
                return Health;
            }

        }
    }
    //fields

    // constr
    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;

    }

    public Human(string name, int strenth, int brain, int speed, int hp)

    {
        //field - receiving
        Name = name;
        Strength = strenth;
        Intelligence = brain;
        Dexterity = speed;
        Health = hp;
    }
    // constr


    //method
    public int Attack(Human target)
    {
        Human enemy = target as Human;
        if (enemy == null)
        {
            Console.WriteLine("Failed Attack");
        }
        else
        {
            enemy.health -= strength * 5;
        }
    }
    //method
}

