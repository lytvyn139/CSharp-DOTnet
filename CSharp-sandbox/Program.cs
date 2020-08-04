using System;
using Ninja.Models;

namespace Ninja
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("/Models/Person.cs");
            Person ninja = new Person("Mr.", "Ninja");
            Person benny = new Person("Benny.", "Bob", 24);
            Console.WriteLine(benny.Age);

        }

    }
}