using System;

namespace Operators
{
    public class ArrayHelper()
    {
        // Method: return the maximum number in the array

        public static int FindMax(int[] number)
        {
            if (number.Length == 0)
                throw new ArgumentException("Array cannot be empty");

            int max = number[0];
            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] > max)
                {
                    max = number[i];
                }
            }

            return max;
        }
    }
}