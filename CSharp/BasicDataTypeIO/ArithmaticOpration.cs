using System;

namespace CSharp.BasicDataTypeIO
{
    /// <summary>
    /// Performing Arithamatic Oprations
    /// </summary>
    class ArithmeticOperation
    {
        public static void Operations()
        {
            Console.WriteLine("Enter First Number:");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

           while (true)
            {
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");
                Console.WriteLine("5 for Exit");

                string userInput = Console.ReadLine();

                switch (userInput)//used switch case here
                {
                    case "1":

                        var AdditionResult = number1 + number2;
                        Console.WriteLine("1 Addition " + AdditionResult);
                        break;

                    case "2":
                        var SubtractionResult = number1 - number2;
                        Console.WriteLine("2.Subtraction " + SubtractionResult);
                        break;

                    case "3":
                        var MultiplicationResult = number1 * number2; 
                        Console.WriteLine("3.Multiplication " + MultiplicationResult);
                        break;

                    case "4":
                        if (number2 != 0)
                        {
                            var DivisionResult = number1 / number2;
                            Console.WriteLine("4.DivisionResult" + DivisionResult);
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;

                        case "5":
                        Console.WriteLine("Exiting Program");
                        return;
                       

                    default:
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
                        break;
                }

            }
        }
        public static void Run(string[] args)
        {
            ArithmeticOperation.Operations();
        }
    }
}
