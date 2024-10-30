using CSharp.BasicDataTypeIO;
using System;
using CSharp.BasicDataTypeIO;
//using  CSharp.BasicDataTypeIO.BasicDataTypeIO;
using CSharp.BasicDataTypeIO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which code do you want to see?");
        Console.WriteLine("For DatatypeCode, choose 1");
        Console.WriteLine("For Arithmetic operation, choose 2");

        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.WriteLine("You choose DatatypeCode");
                CSharp.BasicDataTypeIO.Program.Run(args);
                break;
            case "2":
                Console.WriteLine("You choose Arithmetic Operation");
                CSharp.BasicDataTypeIO.ArithmeticOperation.Run(args);
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                break;
        }
      





    }
}
