using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace ControlFlow
{
    class Program
    {
        static void Main()
        {
            // if statement
            int number = 5;
            if (number > 0)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Non-positive number");
            }
            // switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is One");
                    break;
                case 2:
                    Console.WriteLine("Number is Two");
                    break;
                default:
                    Console.WriteLine("Number is not One or Two");
                    break;
            }
            // Ternary Operator
            bool isGoldCustomer = false;
            decimal price = 100;
            decimal discount = isGoldCustomer ? 0.2m : 0.1m;
            Console.WriteLine("Discounted Price: " + (price * (1 - discount)));
            // Exercise: Ask the user for a number between 1 and 10. 
            // Print "Valid" if input is in range, otherwise "Invalid".
            Console.Write("Enter a number between 1 and 10: ");

            int num = int.Parse(Console.ReadLine());
            if (num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            // Exercise: Write a program which takes two numbers and displays the maximum of the two.
            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            int max = (number1 >= number2) ? number1 : number2;
            Console.WriteLine("The maximum of the two is: " + max);

            // Exercise: Write a program and ask the user to enter the width and height of an image. 
            // Then tell if the image is landscape or portrait.
            Console.Write("Enter the width of the image: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of the image: ");
            int height = int.Parse(Console.ReadLine());

            string orientation =
                (width > height) ? "Landscape" :
                (width < height) ? "Portrait" :
                "Square";

            Console.WriteLine("Your image is a: " + orientation);
            // Exercise: Ask user for speed limit and car speed. 
            // If car speed <= limit → print "Ok". 
            // Otherwise, calculate demerit points = (speed - limit) / 5. 
            // Print points, and if > 12 → print "License Suspended".
            Console.Write("Enter speed limit: ");
            float limit = float.Parse(Console.ReadLine());

            Console.Write("Enter car speed: ");
            float speed = float.Parse(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                float demoritPoints = (speed - limit) / 5;
                Console.WriteLine("Your demerit points: " + demoritPoints);
                string licenseStatus = (demoritPoints > 12) ? "License Suspended" : "Not Suspended";
                Console.WriteLine("Your Licence status: " + licenseStatus);
            }
            // Iteration Statements
            // For Loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration " + i);
            }
            // While Loop
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine("Iteration " + j);
                j++;
            }
            // Do-While Loop
            int k = 1;
            do
            {
                Console.WriteLine("Iteration " + k);
                k++;
            } while (k <= 5);
            // Foreach Loop
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int n in numbers)
            {
                Console.WriteLine("Iteration " + n);
            }
            // Random Loop
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            Console.WriteLine("Random Number: " + randomNumber);
            // Exercise: Count how many numbers between 1 and 100 are divisible by 3.
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Numbers divisible by 3 between 1 and 100: " + count);

            // Exercise: Continuously ask the user for a number (or "ok" to exit). 
            // Keep a running sum of all entered numbers and display the total when done.
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number or type 'ok' to exit: ");
                string input = Console.ReadLine();

                // Try to parse the input as a number
                if (int.TryParse(input, out int value))
                {
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number or 'ok'.");
                }

                if (input.ToLower() == "ok")
                    break;

            }

            Console.WriteLine("The total sum is: " + sum);
        }
    }
}
