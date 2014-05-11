using System;
using System.Linq;
using System.Collections.Generic;

namespace ListaObiektowAnonimowych
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstWay();
            SecondWay();
            ThirdWay();
        }

        #region 1st

        public static void FirstWay()
        {
            var list = Enumerable
                .Empty<object>()
                .Select(o => new
                {
                    Name = string.Empty,
                    Surname = string.Empty,
                    Age = default(int)
                })
                .ToList();

            list.Add(new { Name = "Łukasz", Surname = "Kwiatkowski", Age = 20 });
            list.Add(new { Name = "Mariusz", Surname = "Kwiatkowski", Age = 26 });

            // ERROR - zła kolejność argumentów
            // list.Add(new { Name = "Łukasz", Age = 20, Surname = "Kwiatkowski" });

            list.ForEach(Console.WriteLine);
        }

        #endregion

        #region 2nd

        public static void SecondWay()
        {
            var person = new
            {
                Name = string.Empty,
                Surname = string.Empty,
                Age = default(int)
            };

            var list = MakeList(person);

            list.Add(new { Name = "Łukasz", Surname = "Kwiatkowski", Age = 20 });
            list.Add(new { Name = "Mariusz", Surname = "Kwiatkowski", Age = 26 });

            // ERROR - zła kolejność argumentów
            // list.Add(new { Name = "Mariusz", Age = 26, Surname = "Kwiatkowski" });

            list.ForEach(Console.WriteLine);
        }

        public static List<T> MakeList<T>(T item)
        {
            return new List<T>();
        }

        #endregion

        #region 3rd

        public static void ThirdWay()
        {
            var person = new
            {
                Name = string.Empty,
                Surname = string.Empty,
                Age = default(int)
            };

            var list = (new[] { person }).ToList();
            list.Clear();

            list.Add(new { Name = "Łukasz", Surname = "Kwiatkowski", Age = 20 });
            list.Add(new { Name = "Mariusz", Surname = "Kwiatkowski", Age = 26 });

            // ERROR - zła kolejność argumentów
            // list.Add(new { Name = "Mariusz", Age = 26, Surname = "Kwiatkowski" });

            list.ForEach(Console.WriteLine);
        }

        #endregion
    }
}
