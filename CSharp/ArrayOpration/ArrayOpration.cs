using System;

namespace CSharp.ArrayOperation
{
    class ArrayOperation
    {
        int[] arr;

        // Method to take array input from the user
        public void InputArrayElements()
        {
            Console.Write("Enter the number of elements you want to add to the array: ");
            int length = int.Parse(Console.ReadLine());

            arr = new int[length];//size of array

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array elements:");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }

        // Method to calculate the sum of array elements
        public void SumOfArrayElement()
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine("Sum of array elements: " + sum);
        }

        // Method to calculate the average of array elements
        public void AverageOfArrayElement()
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            double average = (double)sum / arr.Length;
            Console.WriteLine("Average of array elements: " + average);
        }

        // Method to find the minimum element in the array
        public void MinimumInArrayElement()
        {
            int min = arr[0];
            foreach (int item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine("Minimum of array elements: " + min);
        }

        // Method to find the maximum element in the array
        public void MaximumInArrayElement()
        {
            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine("Maximum of array elements: " + max);
        }

        public static void Run(string[] args)
        {
            ArrayOperation arrayOp = new ArrayOperation();
            arrayOp.InputArrayElements();
            arrayOp.SumOfArrayElement();
            arrayOp.AverageOfArrayElement();
            arrayOp.MinimumInArrayElement();
            arrayOp.MaximumInArrayElement();
        }
    }
}
