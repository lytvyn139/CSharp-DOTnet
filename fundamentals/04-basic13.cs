using System;

namespace basic13
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] NumbersArray = { 44, 54, -2, 16, 656, -44, 766, -126 };
            //PrintNumber();
            //PrintOdds();
            //PrintSum();
            //LoopArray(NumbersArray);
            //FindMax(NumbersArray);
            //GetAverage(NumbersArray);
            //GreaterThanY(NumbersArray, 15);
            //SquareArrayValues(NumbersArray);
            //EliminateNegatives(NumbersArray);
            //MinMaxAverage(NumbersArray);
            //ShiftValues(NumbersArray);
            //LoopObArray(NumToString(NumbersArray));
        }
        public static void PrintNumber()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"numnber:{i}, sum:{sum}");
            }
        }
        public static void LoopArray(int[] numbers)

        {
            int[] test = { 1, 5, -6, 4, 0, 7, -9, 6, 6 };
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console.
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            Console.WriteLine($"the largest number in the array is {max}");
            return max;
        }
        public static int GetAverage(int[] numbers)
        {
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            int average = total / numbers.Length;
            Console.WriteLine($"the average in the array is {average}");
            return average;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > y)
                {
                    count++;
                }
            }
            Console.WriteLine($"there are {count} numbers greater than {y}");
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
                // For example, [1,5,10,-10] should become [1,25,100,100]
                int temp = numbers[i] * numbers[i];
                numbers[i] = temp;
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. copy
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }
        public static void MinMaxAverage(int[] numbers)
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
            int average = total / numbers.Length;
            Console.WriteLine($"the average in the array is {average}");
            Console.WriteLine($"the max in the array is {max}");
            Console.WriteLine($"the min in the array is {min}");
        }


        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].

            object[] ob_array = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    ob_array[i] = numbers[i];
                }
                else
                {
                    ob_array[i] = "Dojo";
                }
            }
            return ob_array;
        }
        public static void LoopObArray(object[] arr)
        {
            foreach (object ob in arr)
            {
                Console.WriteLine($"{ob}");
            }
        }
    }
}