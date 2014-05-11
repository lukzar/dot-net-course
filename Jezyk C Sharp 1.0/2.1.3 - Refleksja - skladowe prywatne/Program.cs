using System;
using System.Reflection;

namespace RefleksjaSkladowePrywatne
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            SetNonPublicPropertyValue(a, "PrivateProperty", 12);
            Console.WriteLine((int) GetNonPublicPropertyValue(a, "PrivateProperty"));

            typeof(A).GetProperty("MixedProperty").SetValue(a, 144, null);
            Console.WriteLine(a.MixedProperty);

            Console.WriteLine((int) InvokePrivateMethod(a, "PrivateMethod"));

            int limit = 1000000;

            Console.WriteLine("Liczba powtórzeń: {0}", limit);

            DateTime start;
            DateTime end;
            TimeSpan time;
            
            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                a.PublicMethod();
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("Zwykły sposób: {0} ms", time.Milliseconds);

            start = DateTime.Now;

            for (int i = 0; i < limit; ++i)
            {
                typeof(A).GetMethod("PublicMethod").Invoke(a, new object[] { });
            }

            end = DateTime.Now;

            time = end - start;

            Console.WriteLine("Refleksja: {0} ms", time.Milliseconds);
        }

        public static PropertyInfo GetNonPublicProperty(object instance, string propertyName)
        {
            return instance
                .GetType()
                .GetProperty(propertyName, BindingFlags.NonPublic | BindingFlags.Instance);
        }

        public static void SetNonPublicPropertyValue(object instance, string propertyName, object value)
        {
            GetNonPublicProperty(instance, propertyName).SetValue(instance, value, null);
        }

        public static object GetNonPublicPropertyValue(object instance, string propertyName)
        {
            return GetNonPublicProperty(instance, propertyName).GetValue(instance);
        }

        public static object InvokePrivateMethod(object instance, string methodName)
        {
            return instance
                .GetType()
                .GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(instance, new object[] { });
        }
    }

    class A
    {
        private int PrivateProperty { get; set; }

        public int MixedProperty { get; private set; }

        public int PublicProperty { get; set; }

        private int PrivateMethod() { return 1; }

        public int PublicMethod() { return 2; }
    }
}
