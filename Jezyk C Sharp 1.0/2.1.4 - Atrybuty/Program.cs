using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Atrybuty
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo f = new Foo();

            foreach (var result in InvokeFlaggedWithoutParameters(f, GetPublicNonStaticMethods(f), typeof(int)))
            {
                Console.WriteLine("{0}() -> {1}", result.Key, result.Value);
            }
        }

        public static MethodInfo[] GetPublicNonStaticMethods(object instance)
        {
            return instance
                .GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public);
        }

        public static Dictionary<string, object> InvokeFlaggedWithoutParameters(object instance, MethodInfo[] methods, Type type)
        {
            Dictionary<string, object> results = new Dictionary<string, object>();

            IEnumerable<MethodInfo> oznakowane = methods.Where(method => 
                {
                    return Attribute.IsDefined(method, typeof(Flagged)) 
                        && method.ReturnType == type
                        && method.GetParameters().Length == 0;
                }
            );

            foreach (MethodInfo method in oznakowane)
            {
                results.Add(method.Name, method.Invoke(instance, new object[] { }));
            }

            return results;
        }
    }

    class Foo
    {
        [Flagged]
        public int Bar()
        {
            return 1;
        }

        public int Qux()
        {
            return 2;
        }

        [Flagged]
        public string Fubar()
        {
            return "fubar";
        }

        [Flagged]
        public int Foobar(int a)
        {
            return 5 + a;
        }

        public static int Baz()
        {
            return 3;
        }

        private int Quux()
        {
            return 4;
        }
    }

    class Flagged : Attribute { }
}
