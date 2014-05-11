using System;
using System.Collections.Generic;

namespace ProstyAlgorytm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            for (int number = 1; number <= 100000; ++number)
            {
                if (Check(number))
                {
                    arr.Add(number);
                }
            }
        }

        public static bool Check(int number)
        {
            int sum = 0;
            bool isCandidate = true;

            foreach (int digit in Number.GetDigits(number))
            {
                if (digit == 0 || number % digit != 0)
                {
                    return false;
                }

                sum += digit;
            }

            return (isCandidate && (number % sum == 0));
        }
    }
}
