using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// Methods will run here
            PrintOneTo255();
            FizzBuzz();
            FizzBuzzWhile();
            //////// Methods will run here
        }
        static void PrintOneTo255()
        {
            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void WhileLooping()
        {
            int j = 0; // initialization
            while (j < 10) // condition
            {
                Console.WriteLine("j = {0}", j);
                j++; // increment
            }
        }

        static void FizzBuzz()
        {
            for (int i = 1; i < 256; i++)
            {
                //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void FizzBuzzWhile()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                i++;
            }

        }

    }
}
