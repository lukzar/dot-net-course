using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace KonteneryGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListVSList();

            Console.WriteLine();

            HashtableVSDictionary();
        }

        public static void ArrayListVSList()
        {
            DateTime start;
            DateTime end;
            TimeSpan time;

            int limit = 100000;
            int tmp;

            ArrayList arrayList = new ArrayList(limit);
            List<int> list = new List<int>(limit);

            Console.WriteLine("ArrayList vs List<T>");

            Console.WriteLine();

            Console.WriteLine("Dodawanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                arrayList.Add(i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - ArrayList", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                list.Add(i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - List<T>", time.Milliseconds);

            Console.WriteLine();

            Console.WriteLine("Zużycie pamięci:");

            MemoryUsage((object) arrayList, (object) list);

            Console.WriteLine();

            Console.WriteLine("Przeglądanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                tmp = (int) arrayList[i];
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - ArrayList", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                tmp = list[i];
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - List<T>", time.Milliseconds);

            Console.WriteLine();

            Console.WriteLine("Usuwanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                arrayList.RemoveAt(limit - i - 1);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - ArrayList", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                list.RemoveAt(limit - i - 1);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - List<T>", time.Milliseconds);
        }

        public static void HashtableVSDictionary()
        {
            DateTime start;
            DateTime end;
            TimeSpan time;

            int limit = 100000;
            int tmp;

            Hashtable hashtable = new Hashtable(limit);
            Dictionary<int, int> dictionary = new Dictionary<int, int>(limit);

            Console.WriteLine("Hashtable vs Dictionary<K, V>");

            Console.WriteLine();

            Console.WriteLine("Dodawanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                hashtable.Add(i, i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Hashtable", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                dictionary.Add(i, i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Dictionary<K, V>", time.Milliseconds);

            Console.WriteLine();

            Console.WriteLine("Zużycie pamięci:");

            MemoryUsage(hashtable, dictionary);

            Console.WriteLine();

            Console.WriteLine("Przeglądanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                tmp = (int) hashtable[i];
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Hashtable", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                tmp = dictionary[i];
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Dictionary<K, V>", time.Milliseconds);

            Console.WriteLine();

            Console.WriteLine("Usuwanie:");

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                hashtable.Remove(i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Hashtable", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                dictionary.Remove(i);
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("{0,3} ms - Dictionary<K, V>", time.Milliseconds);
        }

        public static void MemoryUsage(object a, object b)
        {
            long size;

            Stream s;
            BinaryFormatter formatter = new BinaryFormatter();

            s = new MemoryStream();
            formatter.Serialize(s, a);
            size = s.Length;
            Console.WriteLine("{0,8} bytes - {1}", size, a.GetType().Name);

            s = new MemoryStream();
            formatter.Serialize(s, b);
            size = s.Length;
            Console.WriteLine("{0,8} bytes - {1}", size, b.GetType().Name);
        }
    }
}
