using System;

namespace WizardNinjaSamurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        //Provide an override Attack method to Ninja, which reduces the target by 5 * Dexterity and a 20% chance of dealing an additional 10 points of damage.
        //override = overwrite the Attack() from parrent
        public override int Attack(Human target)
        {
            int dmg = (target.Dexterity * 5) + 10;
            return target.ApplyDamage(dmg);

        }
        //Ninja should have a method called Steal, reduces a target Human's health by 5 and adds this amount to its own health.

    }
}