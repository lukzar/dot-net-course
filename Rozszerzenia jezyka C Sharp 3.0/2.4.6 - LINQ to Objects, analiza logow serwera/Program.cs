using System;
using System.IO;
using System.Linq;

namespace LINQToObjectsAnalizaLogowSerwera
{
    class Program
    {
        static void Main(string[] args)
        {
            var logs = File.ReadLines(@"..\..\logs.txt");

            var result = (from line in logs
                         let ip = line.Split(' ')[1]
                         group ip by ip into g
                         orderby g.Count() descending
                         select new { IP = g.Key, Count = g.Count() }).Take(3);

            result.ToList().ForEach(Console.WriteLine);
        }
    }
}
