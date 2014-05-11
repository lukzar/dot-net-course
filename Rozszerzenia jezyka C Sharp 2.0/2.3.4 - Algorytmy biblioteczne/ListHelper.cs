using System;
using System.Collections.Generic;

namespace AlgorytmyBiblioteczne
{
    public class ListHelper
    {
        public static List<TOutput> ConvertAll<T, TOutput>(List<T> list, Converter<T, TOutput> converter)
        {
            List<TOutput> result = new List<TOutput>();

            foreach (T val in list)
            {
                result.Add(converter(val));
            }

            return result;
        }

        public static List<T> FindAll<T>(List<T> list, Predicate<T> match)
        {
            List<T> result = new List<T>();

            foreach (T val in list)
            {
                if (match(val))
                {
                    result.Add(val);
                }
            }

            return result;
        }

        public static void ForEach<T>(List<T> list, Action<T> action) 
        {
            foreach (T val in list)
            {
                action(val);
            }
        }

        public static int RemoveAll<T>(List<T> list, Predicate<T> match)
        {
            int removed = 0;

            for (int i = 0; i < list.Count; ++i)
            {
                if (match(list[i]))
                {
                    list.RemoveAt(i - removed++);
                }
            }

            return removed;
        }

        public static void Sort<T>(List<T> list, Comparison<T> comparison)
        {
            Algorithm.BubbleSort(list, comparison);
        }
    }
}
