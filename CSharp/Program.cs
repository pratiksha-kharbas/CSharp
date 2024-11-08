using CSharp.ArithmaticOpration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Welcome***");
        Console.WriteLine("Which code do you want to see?");
        Console.WriteLine("choose 1 for Datatypecode");
        Console.WriteLine("choose 2 for ArithmaticOpration");
        Console.WriteLine("choose 3 for Calculation");
        Console.WriteLine("Choose 4 for Performing opration using ternary");
        Console.WriteLine("Choose 5 for Days Conversion");
        Console.WriteLine("Choose 6 for array Opration");
        Console.WriteLine("Choose 7 for Exception Handling Code");
        Console.WriteLine("Choose 8 for Interface and abstract class code");
        Console.WriteLine("Choose 9 for List And Dictionary Opration");
        Console.WriteLine("Choose 10 for LINQ");
        Console.WriteLine("Choose 11 for Delegates Program");


        string userInput = Console.ReadLine();

        switch (userInput)
        {
                case "1":
                     Console.WriteLine("You choose DatatypeCode");
                     CSharp.BasicDataTypeIO.Program.Run(args);
                     break;
                 case "2":
                     Console.WriteLine("You choose Arithmetic Operation");
                     ArithmeticOperation.Run(args);
                     break;
                case "3":
                     Console.WriteLine("You choose Calculation");
                     CSharp.Calculations.Calculation.Run(args);
                     break;
                case "4":
                     Console.WriteLine("You Choose TernaryOpration");
                     CSharp.OprationUsingTernary.TernaryOpration.Run(args);
                     break;
                case "5":
                     Console.WriteLine("You Choose Days Conversion Into year week and days");
                     CSharp.ConvertDaysIntoWeekDaysAndYear.ConvertDaysIntoWeekDaysAndYear.Run(args);
                     break;
                 case "6":
                     Console.WriteLine("You choose ArrayOpration");
                     CSharp.ArrayOperation.ArrayOperation.Run(args);
                     break;
                case "7":
                     Console.WriteLine("You choose Exception Handling Code");
                     CSharp.ExceptionHandlingProgram.ExceptionHandling.Run(args);
                     break;
                case "8":
                    Console.WriteLine("you choose interface and abstarct class");
                    CSharp.InterfaceAndAbstractClass.Program.Run(args);
                    break;
                case "9":
                    Console.WriteLine("You Choose List and Dictionary Opration");
                    CSharp.CrudOprationOnList.CrudOprationOnList.Run(args);
                    break;
                 case "10":
                    Console.WriteLine("You Choose linq");
                CSharp.LinqBasicOperations.Program.Run(args);   
                    break;
                 case "11":
                    Console.WriteLine("You choose delegates");
                CSharp.Delgates.Program.Run(args);
                     break;
                  default:
                     Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                     break;
        }
    }
}
