using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Calculations
{
    class Calculation
    { 
        public static Double AreaOfRectangle()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the breadth of the rectangle: ");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double result = 2 * (length + breadth);
            return result;
        }
        public static void Run(string[] args)
        {
            double perimeter = AreaOfRectangle();
            Console.WriteLine($"Perimeter of  rectangle is: {perimeter}");
        }
    }
}
