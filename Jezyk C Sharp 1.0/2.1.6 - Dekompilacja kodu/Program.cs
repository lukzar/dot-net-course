using System;

namespace DekompilacjaKodu
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr arr = new Arr(6);

            for (int i = 0; i < arr.Length; ++i)
            { 
                arr[i] = i * i;
            }

            Console.WriteLine(arr.Calculate());

            arr.changer = a => a * a;

            Console.WriteLine(arr.Calculate());

            arr.changer = a => a - a;

            Console.WriteLine(arr.Calculate());
        }
    }

    class Arr
    {
        protected int[] Data;

        public delegate int Changer(int a);

        public Changer changer = a => a;

        public int Length
        {
            get;
            protected set;
        }

        public Arr(int length)
        {
            Length = length;

            Data = new int[Length];
        }

        public int this[int index]
        {
            get
            {
                if ( ! CheckIfInRange(index))
                {
                    throw new IndexOutOfRangeException();
                }

                return Data[index];
            }
            set
            {
                if ( ! CheckIfInRange(index))
                {
                    throw new IndexOutOfRangeException();
                }

                Data[index] = value;
            }
        }

        protected bool CheckIfInRange(int index)
        {
            return (index > Length) || (index < 0);
        }

        public int Calculate()
        {
            int result = 0;

            for (int i = 0; i < Length; ++i)
            { 
                result += changer(Data[i]);
            }

            return result;
        }
    }
}
