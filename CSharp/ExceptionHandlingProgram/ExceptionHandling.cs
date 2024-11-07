using System;

namespace CSharp.ExceptionHandlingProgram
{
    // Custom exception class
    class UserException : Exception
    {
        public UserException(string message) : base(message) { }
    }

    class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                // Taking input from user
                Console.WriteLine("Enter Numerator:");
                int numerator = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Denominator:");
                int denominator = int.Parse(Console.ReadLine());

                // Check for custom exception condition (negative values)
                if (numerator < 0 || denominator < 0)
                {
                    throw new UserException("Numerator and Denominator should be non-negative.");
                }

                // Check for division by zero
                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                int result = numerator / denominator;
                Console.WriteLine("Result of division: " + result);
            }
            catch (UserException ex)
            {
                Console.WriteLine("User Exception: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide By Zero Exception: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Please enter valid integers.");
            }
            finally
            {
                Console.WriteLine("Program Execution Complete");
            }
        }
    }
}
