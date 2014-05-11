using System;
using System.Runtime.InteropServices;

namespace PInvokeDLLWskaznikiFunkcjeDelegacje
{
    public delegate int F(int n);

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Podaj liczbę: ");

                int number = int.Parse(Console.ReadLine());

                Console.WriteLine("C#: Liczba {0} jest {1}.", number, Execute(number, IsPrimeCs) == 1 ? "pierwsza" : "złożona");
                Console.WriteLine("C++: Liczba {0} jest {1}.", number, Execute(number, IsPrimeC) == 1 ? "pierwsza" : "złożona");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static int IsPrimeCs(int number)
        {
            if (number < 2) {
                return 0;
            }

            int limit = (int) Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i < limit; ++i) {
                if (number % i == 0) {
                    return 0;
                }
            }

            return 1;
        }

        [DllImport("Primes.dll", EntryPoint = "IsPrime")]
        public static extern int IsPrimeC(int number);

        [DllImport("NativeLibrary.dll")]
        public static extern int Execute(int number, F f);
    }
}
