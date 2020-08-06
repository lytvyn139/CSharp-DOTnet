using System;

namespace WizardNinjaSamurai.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Human target)
        {//if it's <50 it will drain all health
            base.Attack(target); //Human.cs

            if (target.health <= 50)
            {
                return target.ApplyDamage(target.health);
            }
            return target.health;


        }

        //Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health

    }
}