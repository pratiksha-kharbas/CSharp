using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharp.BasicDataTypeIO
{
    class UserDefinedException : Exception
    {
        public UserDefinedException(string message) : base(message) { }
    }

    class Program
    {
        /// <summary>
        /// Basic Datatype
        /// </summary>
        public void Datatypes()
        {
            try
            {
                //checking integer
                Console.WriteLine("Enter an integer value:");
                try
                {
                    int intValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You entered a valid integer: {intValue}");
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid integer.");
                }

                Console.WriteLine("Enter a character value:");
                try
                {
                    //checking character
                    string b = Console.ReadLine();
                    if (b.Length == 1)
                    {
                        char charValue = Convert.ToChar(b);
                        Console.WriteLine($"You entered a valid character: {charValue}");
                    }
                    else
                    {
                        throw new UserDefinedException("You did not enter a valid single character.");
                    }
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid character.");
                }
                //Checking string
                Console.WriteLine("Enter a string value:");
                string strValue = Console.ReadLine();
                Console.WriteLine($"You entered a string: {strValue}");

                Console.WriteLine("Enter a long integer value:");
                try
                {
                    long longValue = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine($"You entered a valid long integer: {longValue}");
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid long integer.");
                }
                //checking float
                Console.WriteLine("Enter a float value:");
                try
                {
                    float floatValue = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"You entered a valid float: {floatValue}");
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid float.");
                }
                //checking double
                Console.WriteLine("Enter a double value:");
                try
                {
                    double doubleValue = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"You entered a valid double: {doubleValue}");
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid double.");
                }
                //checking boolean
                Console.WriteLine("Enter a boolean value (true/false):");
                try
                {
                    bool boolValue = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine($"You entered a valid boolean: {boolValue}");
                }
                catch (FormatException)
                {
                    throw new UserDefinedException("You did not enter a valid boolean.");
                }

                Console.WriteLine("**End**");
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Run(string[] args)
        {
            Program program = new Program();
            program.Datatypes();
        }
    }
}
