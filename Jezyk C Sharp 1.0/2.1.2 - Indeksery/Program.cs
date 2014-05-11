using System;

namespace Indeksery
{
    class Program
    {
        public static Grid grid = new Grid(4, 4);

        static void Main(string[] args)
        {
            FillGrid();
            ReadGrid();
        }

        public static void FillGrid()
        {
            try
            {
                for (int i = 0; i < grid.Rows; ++i)
                {
                    for (int j = 0; j < grid.Columns; ++j)
                    {
                        grid[i, j] = i * j;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
        }

        public static void ReadGrid()
        {
            try
            {
                for (int i = 0; i < grid.Rows; ++i)
                {
                    for (int j = 0; j < grid.Columns; ++j)
                    {
                        Console.Write("{0} ", grid[i][j]);
                    }

                    Console.Write(Environment.NewLine);
                }

                Console.Write(Environment.NewLine);

                for (int i = 0; i < grid.Rows; ++i)
                {
                    for (int j = 0; j < grid.Columns; ++j)
                    {
                        Console.Write("{0} ", grid[i, j]);
                    }

                    Console.Write(Environment.NewLine);
                }

                Console.Write(Environment.NewLine);

                Console.Write("{0}", grid[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.Message);
            }
        }
    }
}
