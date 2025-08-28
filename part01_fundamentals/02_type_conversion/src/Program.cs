using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2; //Variables and Data Types
            float floatNumber = 20.95f;
            char character = 'A';
            string text = "Hello";
            bool isTrue = true;
            var implicitInt = 10; // Implicitly typed variable
            const float pi = 3.14f; // Constant variable
            byte b = 1; // Implicitly typed variable
            int c = 1; // Type casting
            float f = 1.0f; // Explicitly typed variable
            int i = (int)f; // Type casting, take the float f and convert it to an int
            var numberString = "1234";
            int intValue = Convert.ToInt32(numberString); // Convert string to int
            var byteValue = (byte)intValue; // Convert int to byte
            var largeNumber = 300;
            byte byteFromLargeNumber = (byte)largeNumber; // Data loss, 300
            try
            {
                var largeFloat = 300.0f;
                byte byteFromLargeFloat = checked((byte)largeFloat); // Checked context to catch overflow
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during conversion.");
            }
            // string str = "Hello";
            // int num = int.Parse(str); // This will throw an exception
            string str = "Hello";
            int num = int.TryParse(str, out int result) ? result : 0; // Safe parsing
            // Output
            Console.WriteLine("Int: " + number);
            Console.WriteLine("Float: " + floatNumber);
            Console.WriteLine("Char: " + character);
            Console.WriteLine("String: " + text);
            Console.WriteLine("Bool: " + isTrue);
            Console.WriteLine("Implicit Int: " + implicitInt);
            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}, {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0}", pi);
            Console.WriteLine("{0}, {1}", b, c);
            Console.WriteLine("{0}, {1}", f, i);
            Console.WriteLine(intValue);
            Console.WriteLine(byteValue);
            Console.WriteLine(byteFromLargeNumber);
            // Console.WriteLine(num); // This will throw an exception
            Console.WriteLine(num); // Safe parsing result
            Console.WriteLine(num);
        }
    }
}
