namespace Ninjas.Models
{
    public class Ninja : Person
    {
        public int Dexterity;
        public int Speed;
        public int Strength;

        public Ninja(string fName,string lName,int dex, int spd,int strg) :base(fName,lName)
        {
            Dexterity = dex;
            Speed = spd;
            Strength = strg;
        }
        public Ninja() :base()
        {
            Dexterity = 10;
            Speed = 50;
            Strength = 100;
        }
        public Ninja(string fName,string lName,int age,int dex, int spd,int strg) :base(fName,lName,age)
        {
            Dexterity = dex;
            Speed = spd;
            Strength = strg;
        }
    }
}