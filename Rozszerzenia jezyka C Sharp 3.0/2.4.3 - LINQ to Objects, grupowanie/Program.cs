using System;
using System.IO;
using System.Linq;

namespace LINQToObjectsGrupowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            var surnames = File.ReadLines(@"..\..\surnames.txt");

            var letters = from surname in surnames
                          orderby surname
                          group surname by surname[0] into newGroup
                          select newGroup.Key;

            letters.ToList().ForEach(Console.WriteLine);
        }
    }
}
