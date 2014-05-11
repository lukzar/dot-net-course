using System;
using System.Collections.Generic;

namespace ProstyAlgorytm
{
    static class Number
    {
        public static int[] GetDigits(int number)
        {
            List<int> digits = new List<int>();

            while (number != 0)
            {
                digits.Add(number % 10);

                number /= 10;
            }

            return digits.ToArray();
        }
    }
}
