using System;
using System.Collections.Generic;

namespace AnonimoweDelegacje
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
            ConvertAll(list);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("FindAll");
            FindAll(list);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("ForEach");
            ForEach(list);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Sort");
            Sort(list);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("RemoveAll");
            RemoveAll(list);
            Console.WriteLine(Environment.NewLine);
        }

        public static void ConvertAll(List<int> list)
        {
            list.ConvertAll<string>(i => i.ToString()).ForEach(i => Console.Write("{0}, ", i));
        }

        public static void FindAll(List<int> list)
        {
            list.FindAll(i => i >= 5).ForEach(i => Console.Write("{0}, ", i));
        }

        public static void ForEach(List<int> list)
        {
            list.ForEach(i => Console.Write("{0}, ", i));
        }

        public static void Sort(List<int> list)
        {
            list.Sort((x, y) => y - x);

            list.ForEach(i => Console.Write("{0}, ", i));
        }

        public static void RemoveAll(List<int> list)
        {
            Console.WriteLine("Removed {0} elements.", list.RemoveAll(i => i >= 5));

            list.ForEach(i => Console.Write("{0}, ", i));
        }
    }
}
