using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {// Name, Calories, IsSpicy, IsSweet
            new Food("Salty Rice", 1010, true, false),
            new Food("Sacred shrooms", 311, true, false),
            new Food("Sweet n Spicy Rice", 290, true, true),
            new Food("Apple", 50, false, true),
            new Food("Dried Banana", 100, true, true),
    };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}
