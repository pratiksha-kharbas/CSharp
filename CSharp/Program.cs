using CSharp.ArithmaticOpration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which code do you want to see?");
        Console.WriteLine("choose 1 for Datatypecode");
        Console.WriteLine("choose 2 for ArithmaticOpration");
        Console.WriteLine("choose 3 for Calculation");

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
            default:
                Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                break;
        }
    }
}
