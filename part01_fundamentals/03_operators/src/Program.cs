using System;
using Operators.Math;

namespace Operators
{
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators in C#");
            // Arithmetic Operators
            Console.WriteLine("Addition: " + (5 + 3));
            Console.WriteLine("Subtraction: " + (5 - 3));
            Console.WriteLine("Multiplication: " + (5 * 3));
            Console.WriteLine("Division: " + (5 / 3));
            Console.WriteLine("Modulus: " + (5 % 3));
            var a = 10;
            var b = 20;
            Console.WriteLine((float)a / (float)b); // 0.5
            // Increment and Decrement Operators
            int x = 5;
            Console.WriteLine("Increment: " + (++x));
            Console.WriteLine("Decrement: " + (--x));
            // Comparison Operators
            Console.WriteLine("Equal: " + (5 == 3));
            Console.WriteLine("Not Equal: " + (5 != 3));
            Console.WriteLine("Greater Than: " + (5 > 3));
            Console.WriteLine("Less Than: " + (5 < 3));
            Console.WriteLine("Greater Than or Equal: " + (5 >= 3));
            Console.WriteLine("Less Than or Equal: " + (5 <= 3));
            // Assignment Operators
            int y = 10;
            y += 5;
            Console.WriteLine("Addition Assignment: " + y);
            y -= 3;
            Console.WriteLine("Subtraction Assignment: " + y);
            // Logical Operators
            Console.WriteLine("And: " + (true && false));
            Console.WriteLine("Or: " + (true || false));
            Console.WriteLine("Not: " + (!true));
            // Bitwise Operators
            Console.WriteLine("Bitwise And: " + (5 & 3));
            Console.WriteLine("Bitwise Or: " + (5 | 3));
            Console.WriteLine("Bitwise Not: " + (~5));
            Console.WriteLine("Bitwise XOR: " + (5 ^ 3));
            // Ternary Operator
            int max = (a > b) ? a : b; //condition ? value_if_true : value_if_false
            Console.WriteLine("Max: " + max);
            // Here is single line comment
            /*
                Here is a 
                multi-line 
                comment
            */
            // Object Creation
            Person person = new Person { Name = "Alice", Age = 30 };
            person.Introduce();
            // Object Creation
            var calculator = new Calculator();
            Console.WriteLine("Calculator Add: " + calculator.Add(5, 3));
            Console.WriteLine("Calculator Subtract: " + calculator.Subtract(5, 3));
            Console.WriteLine("Calculator Multiply: " + calculator.Multiply(5, 3));
            Console.WriteLine("Calculator Divide: " + calculator.Divide(5, 3));
            // Array Creation
            int[] numbers = { 1, 2, 3, 4, 5 };
            // Creating Strings
            string list = string.Join(", ", numbers);
            Console.WriteLine("Array Element: " + numbers[0]);
            Console.WriteLine("Array Elements: " + list);
            // Boolean Elements
            var flags = new bool[] { true, false, true };
            Console.WriteLine("Array Element: " + flags[0]);
            // String Elements
            string name = "Alice";
            char firstInitial = name[0];
            Console.WriteLine("First Initial: " + firstInitial);
            // Escape Sequences
            string filePath = "C:\\Program Files\\MyApp";
            string verbatimPath = @"C:\Program Files\MyApp";
            string quote = "She said, \"Hello!\"";
            string multiLine = "Line 1\nLine 2\nLine 3";
            Console.WriteLine("File Path: " + filePath);
            Console.WriteLine("Verbatim Path: " + verbatimPath);
            Console.WriteLine("Quote: " + quote);
            Console.WriteLine("Multi-line: " + multiLine);
            // Enums
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine("Today is: " + Enum.GetName(typeof(DayOfWeek), today));
            // Types and Values
            Console.WriteLine("Type of today: " + today.GetType());
            Console.WriteLine("Value of today: " + (int)today);
        }
    }
}