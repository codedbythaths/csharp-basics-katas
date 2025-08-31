using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class ArraysAndLists
    {
        static void Main(string[] args)
        {
            // Single-dimensional array
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine("Single-dimensional array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Multi-dimensional array
            int[,] matrix = new int[3, 3];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Console.WriteLine("Multi-dimensional array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Length of the array
            Console.WriteLine("Length of the array: " + numbers.Length);

            // IndexOf()
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);

            // Clear()
            Array.Clear(numbers, 0, numbers.Length);
            Console.WriteLine("Array cleared.");

            // Copy()
            int[] copiedArray = new int[numbers.Length];
            Array.Copy(numbers, copiedArray, numbers.Length);
            Console.WriteLine("Array copied.");

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Array sorted.");

            // Jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3, 4, 5 };
            jaggedArray[2] = new int[1] { 6 };

            Console.WriteLine("Jagged array:");
            foreach (int[] innerArray in jaggedArray)
            {
                foreach (int number in innerArray)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            // Creating Lists
            List<int> numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);

            Console.WriteLine("List of numbers:");
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }

            // Add
            numberList.Add(4);
            numberList.Add(5);
            Console.WriteLine("List after adding elements." + " Count: " + numberList.Count);

            // Add Range
            numberList.AddRange(new int[] { 6, 7, 8 });
            Console.WriteLine("List after adding range." + " Count: " + numberList.Count);

            // Copy()
            List<int> copiedList = new List<int>(numberList);
            Console.WriteLine("List copied." + " Count: " + copiedList.Count);

            // Remove
            numberList.Remove(4);
            Console.WriteLine("List after removing an element." + " Count: " + numberList.Count);

            // Remove At
            numberList.RemoveAt(0);
            Console.WriteLine("List after removing element at index 0." + " Count: " + numberList.Count);

            // Contains
            bool containsSix = numberList.Contains(6);
            Console.WriteLine("List contains 6: " + containsSix);

            Console.WriteLine("List of numbers:");
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }

            // Clear
            numberList.Clear();
            Console.WriteLine("List cleared." + " Count: " + numberList.Count);

            Console.WriteLine("List of numbers:");
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
