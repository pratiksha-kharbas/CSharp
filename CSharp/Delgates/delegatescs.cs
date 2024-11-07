using System;
namespace CSharp.Delgates
{
    public class Program
    {
        // a delegate 
        public delegate int MathOperation(int num1, int num2);

        public static void Run(string[] args)
        {
            // Assign anonymous methods 
            MathOperation add = delegate (int num1, int num2)
            {
                return num1 + num2;
            };

            MathOperation subtract = delegate (int num1, int num2)
            {
                return num1 - num2;
            };

            MathOperation multiply = delegate (int num1, int num2)
            {
                return num1 * num2;
            };

            MathOperation divide = delegate (int num1, int num2)
            {
                try
                {
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    return num1 / num2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            };

            // Demonstrate the functionality of each operation
            Console.WriteLine("Addition: 10 + 5 = " + add(10, 5));
            Console.WriteLine("Subtraction: 10 - 5 = " + subtract(10, 5));
            Console.WriteLine("Multiplication: 10 * 5 = " + multiply(10, 5));
            Console.WriteLine("Division: 10 / 5 = " + divide(10, 5));
            Console.WriteLine("Division by zero: 10 / 0 = " + divide(10, 0));
        }
    }
}
