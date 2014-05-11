using System;
using System.IO;
using System.Linq;

namespace LINQToObjectsAgregowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();

            string[] paths = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);

            long filesSize = (from path in paths
                              select (new FileInfo(path)).Length
                              ).Aggregate((current, next) => current + next);

            Console.WriteLine("{0:0,0} bytes", filesSize);
        }
    }
}
