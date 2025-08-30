using System;

namespace Operators
{
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
        }
    }
}