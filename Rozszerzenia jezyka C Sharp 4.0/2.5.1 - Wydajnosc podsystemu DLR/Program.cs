using System;

namespace WydajnoscPodsystemuDLR
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStatic();
            TestDynamic();
        }

        const int INTERATIONS = 100000000;

        public static void TestStatic()
        {
            DateTime start = DateTime.Now;

            for (int i = 1; i <= INTERATIONS; ++i)
            {
                Foo(i, i);
            }

            DateTime end = DateTime.Now;
            TimeSpan span = end - start;

            Console.WriteLine("static: {0} ms", span.Milliseconds);
        }

        public static void TestDynamic()
        {
            DateTime start = DateTime.Now;

            for (int i = 1; i <= INTERATIONS; ++i)
            {
                FooDynamic(i, i);
            }

            DateTime end = DateTime.Now;
            TimeSpan span = end - start;

            Console.WriteLine("dynamic: {0} ms", span.Milliseconds);
        }

        public static int Foo(int x, int y)
        {
            return x * y - x / y;
        }

        public static dynamic FooDynamic(dynamic x, dynamic y)
        {
            return x * y - x / y;
        }
    }
}
