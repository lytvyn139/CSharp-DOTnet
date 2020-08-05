using System;

namespace StarWars.Models
{
    public class Sith : Character
    {
        public int MidCount;
        public string LightSaberColor;
        public bool HasRatTail;
        public Sith(string name, int age, string side, string planet, int mid, string saberColor, bool rat) : base(name, age, side, planet)
        {
            MidCount = mid;
            LightSaberColor = saberColor;
            HasRatTail = rat;
        }

        public override int Attack(Character target)
        {
            int dmg = MidCount * 5;
            return target.TakeDamage(dmg);
        }

        public int UseForce(Character target)
        {
            Jedi t = (Jedi)target;
            if (t is Jedi)
            {
                Console.WriteLine("This is Dangerous.");
            }
            return -1;
        }
    }
}