using Ninjanauts.Interfaces;

namespace Ninjanauts.Models
{
    public class Book : ILearnable
    {
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        public string GetInfo()
        {
            return $"Reading {Name} + {Calories} brain power points"; //
        }
        public Book(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}
