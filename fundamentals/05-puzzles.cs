using System;
using System.Collections.Generic;
namespace puzzles
{
    class Program
    {
        public static int[] Random5_25(int num)
        {
            int[] random = new int[num];
            for (int i = 0; i < random.Length; i++)
            {
                Random a = new Random();
                random[i] = a.Next(5, 26);
            }
            return random;
        }
        public static int[] PrintIntArray(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.WriteLine($"{arr[arr.Length - 1]} ]");
            return arr;
        }
        public static void MinMaxTotal(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int total = 0;
            int max = numbers[0];
            int min = numbers[0];
            foreach (int number in numbers)
            {
                total += number;
                if (number > max) { max = number; }
                if (number < min) { min = number; }
            }
            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"Max : {max}");
            Console.WriteLine($"Min : {min}");
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin");
            Random coin = new Random();
            if (coin.NextDouble() >= 0.5)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoin(int num)
        {
            int Heads = 0;
            int Tails = 0;
            for (int i = 0; i < num; i++)
            {
                string a = TossCoin();
                if (a == "Heads")
                {
                    Heads++;
                }
                else if (a == "Tails")
                {
                    Tails++;
                }
                else
                {
                    Console.WriteLine("?");
                }
            }
            double HeadRatio = (double)Heads / num;
            Console.WriteLine("Heads " + Heads);
            Console.WriteLine("Tails " + Tails);
            Console.WriteLine(HeadRatio);
            return HeadRatio;
        }
        public static List<string> Shuffle(List<string> a)
        {
            Random index = new Random();
            for (int i = 0; i < a.Count; i++)
            {
                int randomIndex = index.Next(0, a.Count);
                string temp = a[i];
                a[i] = a[randomIndex];
                a[randomIndex] = temp;
            }
            return a;
        }
        public static void ReadList(List<string> a)
        {
            Console.Write("[ ");
            for (int i = 0; i < a.Count - 1; i++)
            {
                Console.Write($"{a[i]}, ");
            }
            Console.WriteLine($"{a[a.Count - 1]} ]");
        }
        public static List<string> names5characters(List<string> a)
        {
            List<string> temp = new List<string> { };
            foreach (string element in a)
            {
                if (element.Length > 5)
                {
                    temp.Add(element);
                }
            }
            return temp;
        }
        static void Main(string[] args)
        {
            // int[] a = Random5_25(10);
            // PrintIntArray(a);
            // MinMaxTotal(a);
            // TossCoin();
            // TossMultipleCoin(49);
            List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            ReadList(names);
            Shuffle(names);
            ReadList(names);
            ReadList(names5characters(names));
        }
    }
}
