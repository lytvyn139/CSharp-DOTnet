using System;
using Ninjas.Models;

namespace Ninjas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ninjas!!!");

            Person ninja = new Person("Mr.","Nibbles");
            Person benny = new Person("Benny Bob","McBob",55);

            Ninja lydell = new Ninja("Lydell","Ninja",100,150,200);

            lydell.Birthday();


            benny.Birthday().Birthday().Birthday();
            Console.WriteLine(benny.Age);
        }
    }
}
