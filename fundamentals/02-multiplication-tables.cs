using System;
using System.Collections.Generic;
namespace MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,6}", i * j);
                }
            }
        }
    }
}