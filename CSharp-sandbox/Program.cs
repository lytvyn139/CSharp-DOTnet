using System;
using System.Collections.Generic;
namespace CSharp_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // HoldTenNumbers();
            // FourNamesArray();
            // TenBoolArray();
            userinfo(Icecream(), FourNamesArray());
        }
        /*             
          ######### Three Basic Arrays ##########
      */
        //Create an array to hold integer values 0 through 9
        static void HoldTenNumbers()
        {

            int num = 0;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = num + i;
                Console.WriteLine(array[i]);
            }
        }

        //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
        static string[] FourNamesArray()
        {
            string[] names = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            //Console.WriteLine(String.Join(", ", names));
            {
                foreach (string person in names)
                {
                    Console.WriteLine(person);
                }
            }
            return names;
        }

        static void TenBoolArray()
        {
            bool[] arr = new bool[6];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = true;
                arr[i + 1] = false;
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr[i + 1]);
            }
        }
        /*             
            ######### List of Flavors ##########
        */
        static List<string> Icecream()
        {
            //Create a list of ice cream flavors that holds at least 5 different flavors
            List<string> flavorslist = new List<string>();
            flavorslist.Add("Flavor1");
            flavorslist.Add("Flavor2");
            flavorslist.Add("Flavor3");
            flavorslist.Add("Flavor4");
            flavorslist.Add("Flavor5");
            flavorslist.Add("Flavor6");

            //Console.WriteLine(String.Join(", ", flavorslist));
            //Output the length of this list after building it
            //Console.WriteLine(flavorslist.Count);
            //Output the third flavor in the list, then remove this value
            //Console.WriteLine(flavorslist[2]);
            flavorslist.RemoveAt(2);
            //Console.WriteLine(flavorslist.Count);
            return flavorslist;
        }

        public static void userinfo(List<string> flavorslist, string[] names)
        {
            //Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> user = new Dictionary<string, string>();
            //Add key/value pairs to this dictionary where:
            //each key is a name from your names array
            //each value is a randomly select a flavor from your flavors list.
            foreach (string name in names)
            {
                user.Add(name, null);
            }
            Random rand = new Random();
            foreach (string name in names)
            {
                int x = rand.Next(flavorslist.Count - 1);
                user[name] = flavorslist[x];
            }
            //Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in user)
            {
                Console.WriteLine("{0}'s favorite flavor is {1}!", entry.Key, entry.Value);
            }
        }


    }
}
