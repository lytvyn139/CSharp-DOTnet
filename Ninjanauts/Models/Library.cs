using System;
using System.Collections.Generic;
using Ninjanauts.Interfaces;

namespace Ninjanauts.Models
{
    public class Library
    {
        public List<ILearnable> Menu;
        public Library()
        {
            Menu = new List<ILearnable>()
            {
                new Book("The Art of Assembly Language", 250, true, false),
                new Book("Clean Code", 150, true, true),
                new Book("C++ book", 100, true, false),
                new Book("Data structures in Java", 75, true, false),
                new Book("Eloquent JavaScript", 50, true, false),
                new Book("Python3", 25, true, false),
                // new Drink("Coffee", 50, true),
                // new Drink("Americano", 50, true),
                // new Drink("Americano", 50, true),
            };
        }

        public ILearnable Serve()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("                         ***NEW ROUND ***");
            Console.ResetColor();

            Random rand = new Random();
            ILearnable item = Menu[rand.Next(Menu.Count)];
            return item;
        }
    }
}