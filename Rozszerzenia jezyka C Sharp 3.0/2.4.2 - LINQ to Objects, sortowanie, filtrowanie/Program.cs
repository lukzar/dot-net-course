using System;
using System.IO;
using System.Linq;

namespace LINQToObjectsSortowanieFiltrowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadLines(@"..\..\numbers.txt");

            var result1 = from line in numbers
                        let number = int.Parse(line)
                        where number > 100
                        orderby number descending
                        select number;

            var result2 = numbers
                .Select<string, int>(i => int.Parse(i))
                .Where(i => i > 100)
                .OrderByDescending(i => i);

            Console.WriteLine("Czy oba sposoby zwracją ten sam wynik: {0}.", Enumerable.SequenceEqual(result1, result2));

            result1.ToList().ForEach(Console.WriteLine);
        }
    }
}
