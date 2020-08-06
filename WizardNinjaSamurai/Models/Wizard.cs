using System;

namespace WizardNinjaSamurai.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 100;
        }
        //Provide an override Attack method to Wizard, which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            return target.ApplyDamage(dmg);

        }
    }
}