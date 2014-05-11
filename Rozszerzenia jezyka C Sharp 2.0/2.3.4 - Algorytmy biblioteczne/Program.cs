using System;
using System.Collections.Generic;

namespace AlgorytmyBiblioteczne
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 10; ++i)
            {
                list.Add(i);
            }

            Console.WriteLine("ConvertAll");
            ListHelper.ConvertAll<int, string>(list, i => i.ToString()).ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("FindAll");
            ListHelper.FindAll(list, i => i >= 5).ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("ForEach");
            ListHelper.ForEach(list, i => Console.Write("{0}, ", i));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Sort");
            ListHelper.Sort(list, (x, y) => y - x);
            list.ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("RemoveAll");
            Console.WriteLine("Removed {0} elements.", list.RemoveAll(i => i >= 5));
            list.ForEach(i => Console.Write("{0}, ", i));
            Console.WriteLine(Environment.NewLine);
        }
    }
}
