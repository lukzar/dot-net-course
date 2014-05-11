using System;
using System.Collections.Generic;

namespace AlgorytmyBiblioteczne
{
    public class Algorithm
    {
        public static List<T> BubbleSort<T>(List<T> list, Comparison<T> comparison)
        {
            int action;
            T tmp;

            bool stop;

            for (int i = list.Count - 1; i > 0; --i)
            {
                stop = true;

                for (int j = 1; j <= i; ++j)
                {
                    action = comparison(list[j - 1], list[j]);

                    if (action > 0)
                    {
                        tmp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = tmp;
                    }

                    stop = false;
                }

                if (stop)
                {
                    break;
                }
            }

            return list;
        }
    }
}
