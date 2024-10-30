using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BasicDataTypeIO
{
    
    public class OprationBasedOnUserInput
    {
       
        public static int AreaOfRectangle()
        {
            int Length = int.Parse(Console.ReadLine());
            int Breadth = int.Parse(Console.ReadLine());
             return Length * Breadth;
        }
       static void Run(String args)
        {
            Console.WriteLine("Enter The Length and Breadth of rectangle");
            var Perimeter = OprationBasedOnUserInput.AreaOfRectangle();
            Console.WriteLine(Perimeter);
                
        }
    }
}
