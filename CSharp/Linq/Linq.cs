using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LinqBasicOperations
{
    public class Program
    {
        public static void Run(string[] args)
        {
            // List of numbers to perform LINQ operations on
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Get even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("\nEven Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Get odd numbers
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
            Console.WriteLine("\nOdd Numbers:");
            foreach (var num in oddNumbers)
            {
                Console.WriteLine(num);
            }

            // Order numbers in ascending order
            var orderedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("\nOrdered Numbers (Ascending):");
            foreach (var num in orderedNumbers)
            {
                Console.WriteLine(num);
            }

            // Count how many numbers are greater than 5
            int countGreaterThanFive = numbers.Count(n => n > 5);
            Console.WriteLine($"\nCount of numbers greater than 5: {countGreaterThanFive}");

            // Check if a specific element is present in the list
            string elementStatus = numbers.Contains(4) ? "present" : "not present";
            Console.WriteLine($"\nElement 4 is {elementStatus}");

            // Reverse the elements
            var reversedNumbers = numbers.AsEnumerable().Reverse().ToList();
            Console.WriteLine("\nReversed Numbers:");
            foreach (var num in reversedNumbers)
            {
                Console.WriteLine(num);
            }

            // Define Employee class
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Abc", Age = 25, Salary = 50000 },
                new Employee { Id = 2, Name = "Xyz", Age = 30, Salary = 55000 },
                new Employee { Id = 3, Name = "Pqr", Age = 35, Salary = 60000 },
                new Employee { Id = 4, Name = "Wxy", Age = 40, Salary = 70000 },
                new Employee { Id = 5, Name = "Eve", Age = 45, Salary = 80000 }
            };

            // LINQ to find employees older than 30
            var olderThan30 = employees.Where(e => e.Age > 30);
            Console.WriteLine("\nEmployees older than 30:");
            foreach (var employee in olderThan30)
            {
                Console.WriteLine($"{employee.Name}, Age: {employee.Age}");
            }

            //Count Total number of employees
            int totalEmployees = employees.Count;
            Console.WriteLine($"\nTotal number of employees in the company: {totalEmployees}");
            foreach(var employee in totalEmployees)
            {
                Console.WriteLine($"The name of employee{name} and {Id}");
            }

            // LINQ to get the employee with the highest salary
            var highestSalaryEmployee = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
            Console.WriteLine($"\nEmployee with the highest salary: {highestSalaryEmployee?.Name}, Salary: {highestSalaryEmployee?.Salary}");

            // LINQ to get the average age of employees
            var averageAge = employees.Average(e => e.Age);
            Console.WriteLine($"\nAverage age of employees: {averageAge}");

            // LINQ to search for an employee by name
            string searchName = "Bob";
            var employeeByName = employees.FirstOrDefault(e => e.Name == searchName);
            Console.WriteLine($"\nEmployee with name '{searchName}': {employeeByName?.Name ?? "Not Found"}");

            // LINQ to get a list of employees sorted by salary
            var sortedBySalary = employees.OrderBy(e => e.Salary).ToList();
            Console.WriteLine("\nEmployees sorted by salary:");
            foreach (var employee in sortedBySalary)
            {
                Console.WriteLine($"{employee.Name}, Salary: {employee.Salary}");
            }
            Console.ReadLine();
        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
        }
       

    }
  
}
