using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ConvertDaysIntoWeekDaysAndYear
{
     class ConvertDaysIntoWeekDaysAndYear
    {
        public static void Run(String[] args)
        {
            Console.Write("Enter the number of days: ");
            int totalDays = int.Parse(Console.ReadLine());

            // Constants
            const int daysInYear = 365;
            const int daysInWeek = 7;

            // Calculations
            int years = totalDays / daysInYear;
            int remainingDays = totalDays % daysInYear;
            int weeks = remainingDays / daysInWeek;
            int days = remainingDays % daysInWeek;

           
            Console.WriteLine($"{totalDays} days is equivalent to {years} years, {weeks} weeks, and {days} days.");
        }
    
        
    }
}
