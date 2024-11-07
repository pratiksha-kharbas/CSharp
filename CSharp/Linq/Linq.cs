using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
//using System.Console.dll;

namespace CSharp.LinqBasicOperations
{
    public class Program
    {
        public static void Run(string[] args) 
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var EvenNumber = numbers.Where(n=>n%2==0).ToList();
            Console.WriteLine("\n The Even Number");
            foreach (var number in EvenNumber)
            {
                Console.WriteLine(number);
            }
            // Method syntax: Get odd numbers
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

            Console.WriteLine("\nOdd Numbers (Method Syntax):");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }

            // Order numbers in ascending order
            var orderedNumbers = numbers.OrderBy(n => n).ToList();

            Console.WriteLine("\nOrdered Numbers (Ascending):");
            foreach (var num in orderedNumbers)
            {
                Console.WriteLine(num);
            }

            // Count how many numbers are greater than 5
            int countGreaterThanFive = numbers.Count(n => n > 5);
            Console.WriteLine($"\nCount of numbers greater than 5: {countGreaterThanFive}");

            //Checking particular element present in list or not
            String element = numbers.Contains(4) ? "present" : "notpresent";
            Console.WriteLine(element);

            //Reverse the element from
           var reversedNumbers = numbers.AsEnumerable().Reverse().ToList();
           Console.WriteLine("Reversed elements:");
           reversedNumbers.ForEach(num => Console.WriteLine(num));

         



        }
    }
}
