using System;
using System.Collections.Generic;
namespace CSharp.OprationUsingTernary
{
    class TernaryOpration
    {
        /// <summary>
        /// Finds the maximum of two numbers using the ternary operator.
        /// </summary>
        public void MaxNumberUsingTernary()
        {
            Console.WriteLine("Enter Number1:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2:");
            int number2 = int.Parse(Console.ReadLine());

            // Ternary operation 
            string result = (number1 > number2)
                ? $"{number1} is greater"
                : $"{number2} is greater";

            Console.WriteLine(result);
        }

        public void EvenOrOddNumberUsingTernary()
        {
            Console.WriteLine("Enter the Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            var result = (number % 2 == 0)
                ? $"{number} is even"
                : $"{number} is odd";

            Console.WriteLine(result);
        }
        public void LeapYearOrNot()
        {
            Console.WriteLine("Enter the Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("The year is a leap year.");
            }
            else
            {
                Console.WriteLine("The year is not a leap year.");
            }
        }


        public static void Run(string[] args)
        {
           TernaryOpration ternaryOpration = new TernaryOpration();
           Console.WriteLine(" Choose 1-- For Maximum Or Minimum no");
           Console.WriteLine(" Choose 2-- For Even Or Odd no");
           Console.WriteLine(" Choose 3-- For LeapYear");

            Console.WriteLine("Enter Your Choise");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ternaryOpration.MaxNumberUsingTernary();
                    break;
                case 2:
                    ternaryOpration.EvenOrOddNumberUsingTernary();
                    break;
                case 3:
                    ternaryOpration.LeapYearOrNot();
                    break;
                default:
                    Console.WriteLine("Enter Correct choice");
                    break;


            }


        }
    }
}
