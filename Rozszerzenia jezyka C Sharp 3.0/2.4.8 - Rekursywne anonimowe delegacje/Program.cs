using System;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

namespace RecursiveLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstWay();
            SecondWay();
        }

        #region First Way

        static void FirstWay()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in list.Select(i =>
            {
                if (i <= 2)
                {
                    return 1;
                }

                MethodBase lambda = (new StackTrace()).GetFrames().First().GetMethod();

                return (int)lambda.Invoke(new object(), new object[] { i - 1 })
                    + (int)lambda.Invoke(new object(), new object[] { i - 2 });
            }))
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region Second Way

        delegate Func<TIn, TOut> FixedPointFunction<TIn, TOut>(Func<TIn, TOut> f);

        static Func<T, TRes> Fix<T, TRes>(FixedPointFunction<T, TRes> f)
        {
            return f(x => Fix(f)(x));
        }

        static void SecondWay()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in list.Select(Fix<int, int>(f => (x => (x <= 1) ? x : f(x - 1) + f(x - 2)))))
            {
                Console.WriteLine(item);
            }
        }

        #endregion
    }
}