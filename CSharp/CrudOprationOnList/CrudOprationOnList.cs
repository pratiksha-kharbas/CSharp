using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace CSharp.CrudOprationOnList
{
    class CrudOprationOnList
    {
        public static void Run(string[] args)
        {
            // Initializing and adding elements to the list
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("The list of elements:");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            // Adding an element to the list
            list.Add(10);
            list.AddRange(new List<int> { 10, 20 });
            Console.WriteLine("\nAfter updating the list:");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            // Removing an element from the list
            list.Remove(10);
            Console.WriteLine("\nAfter removing the 10th element from the list:");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            // Initializing and adding elements to the dictionary
            Dictionary<int, object> dict = new Dictionary<int, object>
            {
                { 1, "NAME" },
                { 2, "AGE" },
                { 3, "Salary" },
                { 4, 4 }
            };

            Console.WriteLine("\nThe keys and values of the dictionary:");
            foreach (KeyValuePair<int, object> ele in dict)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }

            // Removing a key from the dictionary
            dict.Remove(4);
            Console.WriteLine("\nAfter removing the key 4:");
            foreach (KeyValuePair<int, object> ele in dict)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }

            // Adding a new key-value pair to the dictionary
            dict.Add(5, "NO");
            Console.WriteLine("\nAfter adding a new key and value (5, 'NO'):");
            foreach (KeyValuePair<int, object> ele in dict)
            {
                Console.WriteLine($"Key: {ele.Key}, Value: {ele.Value}");
            }
            //Displaying Only keys
            Console.WriteLine("\nDisplaying the keys");
            foreach(KeyValuePair<int, object> ele in dict)
            {
                Console.Write($"\nKeys are {ele.Key}");
            }
            //Displaying Only Values
            Console.WriteLine("\nDisplaying the values");
            foreach (KeyValuePair<int, object> ele in dict)
            {
                Console.Write($"\nvalues are {ele.Value}");
            }
           ////LINQ method for adding element in list
           //var addelement  = from searchelement           
        }
    }
}
 