using System;

namespace StarWars.Models
{
    public class Jedi : Character
    {
        public int MidCount;
        public string LightSaberColor;
        public bool HasRatTail;
        public Jedi(string name, int age, string side, string planet, int mid, string saberColor, bool rat) : base(name, age, side, planet)
        {
            MidCount = mid;
            LightSaberColor = saberColor;
            HasRatTail = rat;
        }
        //here's override, because in Char.cs ln23 I have virtual
        public override int Attack(Character target)
        {
            int dmg = MidCount * 5;
            return target.TakeDamage(dmg); //TakeDmg from Char.cs
            //make sure that in Char.cs ln15 access modifier = protected
        }
        public int UseForce(Character target)
        {
            // Sith t = (Sith)target;
            if (target is Sith)
            {
                int dmg = MidCount * 10;
                Console.WriteLine("Usings FORCE This is Dangerous.");
                return target.TakeDamage(-dmg);
            }
            else
            {

                int heal = MidCount * 3;
                return target.TakeDamage(heal);
            }
        }
    }
}