using System;

namespace Operators.Math
{
    public class Calculator
    { 
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (float)a / b;
        }
    }
}