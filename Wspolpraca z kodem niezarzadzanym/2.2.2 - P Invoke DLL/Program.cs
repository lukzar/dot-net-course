using System;
using System.Runtime.InteropServices;

namespace PInvokeDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj liczbę: ");

                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("Liczba {0} jest {1}.", number, IsPrime(number) == 1 ? "pierwsza" : "złożona");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [DllImport("Primes.dll")]
        public static extern int IsPrime(int number);
    }
}
