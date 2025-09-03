using System;
using System.Collections.Generic;
using System.Linq;


namespace ArraysAndLists
{
    enum WeekDays { Mon, Tue, Wed, Thur, Fri, Sat, Sun };
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
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write(matrix[a, b] + " ");
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

            // if statement katas
            int k = 5;
            if (k > 3) // evaluate condition: number > 3 -> 5 > 3 -> true
                Console.WriteLine("Greater than 3");
            else
                Console.WriteLine("Not greater than 3");

            // while loop katas
            int i = 0;
            while (i < 3) // check condition: i < 3 -> 0 < 3 -> true
            {
                Console.WriteLine(i); // execute body -> prints 0
                i++; // increment i++ -> i = i + 1 -> i = 0 + 1 -> i = 1
            }

            // do-while loop katas
            int j = 0;
            do
            {
                Console.WriteLine(j); // no condition check yet -> execute body -> prints 0
                j++; // increment j++ -> j = j + 1 -> j = 0 + 1 -> j = 1
            } while (j < 3); // check condition: 1 < 3 -> true

            // switch-case katas
            WeekDays weekDays = WeekDays.Mon;

            switch (weekDays)
            {
                case WeekDays.Mon: // case: "Mon": -> match found
                    Console.WriteLine("Start of week"); // executes bosy -> prints "Start of week"
                    break; // exit the sitch block immediately

                case WeekDays.Fri:
                    Console.WriteLine("Weekend soon");
                    break;
            }

            string day = "Thurs";

            string message = day switch
            {
                "Mon" => "Start of week",
                "Fri" => "Weekend soon",
                _ => "Other day"      // default case
            };
            Console.WriteLine(message);

            // array katas
            int[] num = { 20, 23, 54, 89, 12, 02, 33 };

            // access
            Console.WriteLine(num[2]);

            // index of
            int IndexOf = Array.IndexOf(num, 33);
            Console.WriteLine(IndexOf);

            // update
            num[2] = 99;
            Console.WriteLine(num[2]);

            // for loop
            for (i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            // for each
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            // sort
            Array.Sort(num);

            // reverse
            Array.Reverse(num);

            // Sum (LINQ)
            int sum = num.Sum();
            Console.WriteLine(sum);

            // list
            List<int> value = new List<int> { 1, 2, 3 };

            foreach (int v in value)
            {
                Console.WriteLine(v);
            }
        }
    }
}
