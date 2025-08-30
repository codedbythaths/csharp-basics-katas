using System;

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
            }else
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
        }
    }
}
