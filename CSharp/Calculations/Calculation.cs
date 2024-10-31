using CSharp.BasicDataTypeIO;
using System;

namespace CSharp.Calculations
{
    public class UserDefinedException : Exception
    {
        public UserDefinedException(string message) : base(message) { }
    }

    class Calculation
    {
        public static double PerimeterOfRectangle()
        {
            try
            {
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the breadth of the rectangle: ");
                double breadth = Convert.ToDouble(Console.ReadLine());

                if (length < 0 || breadth < 0)
                {
                    throw new UserDefinedException("Error: Negative numbers are not allowed.");
                }

                return 2 * (length + breadth);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return 0;
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public static double AreaOfRectangle()
        {
            try
            {
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the breadth of the rectangle: ");
                double breadth = Convert.ToDouble(Console.ReadLine());

                if (length < 0 || breadth < 0)
                {
                    throw new UserDefinedException("Error: Negative numbers are not allowed.");
                }

                return length * breadth;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return 0;
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public void AreaOfCircle()
        {
            const float PI = 3.14f;
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Error: Negative numbers are not allowed.");
                return;
            }

            double area = PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
        public void DiameterOfCircle()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Error: Negative numbers are not allowed.");
                return;
            }

            double diameter = 2 * radius;
            Console.WriteLine("The diameter of the circle is: " + diameter);
        }
        public void CircumferenceOfCircle()
        {
            const float PI = 3.14f;
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius < 0)
            {
                Console.WriteLine("Error: Negative numbers are not allowed.");
                return;
            }

            double circumference = 2 * PI * radius;
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }
        public void ConvertCentimeterToMeter()
        {
            Console.Write("Enter the centimeters: ");
            double centimeters = Convert.ToDouble(Console.ReadLine());

            if (centimeters < 0)
            {
                Console.WriteLine("Error: Negative numbers are not allowed.");
                return;
            }

            double meters = centimeters / 100.0;
            Console.WriteLine("The conversion to meters is: " + meters);
        }
        public void ConvertCentimeterToKilometer()
        {
            Console.Write("Enter the centimeters: ");
            double centimeters = Convert.ToDouble(Console.ReadLine());

            if (centimeters < 0)
            {
                Console.WriteLine("Error: Negative numbers are not allowed.");
                return;
            }
            double kilometers = centimeters / 100000.0;
            Console.WriteLine("The conversion to kilometers is: " + kilometers);
        }

        public static void Run(string[] args)
        {
            Console.WriteLine("Choose a calculation to perform:");
            Console.WriteLine("1 - Perimeter of Rectangle");
            Console.WriteLine("2 - Area of Rectangle");
            Console.WriteLine("3 - Area of Circle");
            Console.WriteLine("4 - Diameter of Circle");
            Console.WriteLine("5 - Circumference of Circle");
            Console.WriteLine("6 - Convert Centimeter to Meter");
            Console.WriteLine("7 - Convert Centimeter to Kilometer");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Calculation calculation = new Calculation();

            switch (choice)
            {
                case 1:
                    double perimeter = PerimeterOfRectangle();
                    Console.WriteLine($"Perimeter of the rectangle is: {perimeter}");
                    break;
                case 2:
                    double areaRectangle = AreaOfRectangle();
                    Console.WriteLine($"Area of the rectangle is: {areaRectangle}");
                    break;
                case 3:
                    calculation.AreaOfCircle();
                    break;
                case 4:
                    calculation.DiameterOfCircle();
                    break;
                case 5:
                    calculation.CircumferenceOfCircle();
                    break;
                case 6:
                    calculation.ConvertCentimeterToMeter();
                    break;
                case 7:
                    calculation.ConvertCentimeterToKilometer();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
