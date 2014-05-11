using System;
using System.Linq;

namespace Indeksery
{
    class Grid
    {
        protected int[,] Data;

        public int Rows
        {
            get;
            protected set;
        }

        public int Columns
        {
            get;
            protected set;
        }

        public Grid(int rows, int columns)
        {
            if (rows < 0 && columns < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Rows = rows;
            Columns = columns;

            Data = new int[Rows, Columns];
        }

        public int[] this[int row]
        {
            get
            {
                if (row > Rows || row < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return GetRow(row);
            }
        }

        protected int[] GetRow(int row)
        {
            return Data
                .Cast<int>()
                .Skip(row * Columns)
                .Take(Columns)
                .ToArray();
        }

        public int this[int row, int column]
        {
            get
            {
                if ( ! CheckIfInRange(row, column))
                {
                    throw new IndexOutOfRangeException();
                }

                return Data[row, column];
            }
            set
            {
                if ( ! CheckIfInRange(row, column))
                {
                    throw new IndexOutOfRangeException();
                }
                
                Data[row, column] = value;
            }
        }

        protected bool CheckIfInRange(int row, int column)
        {
            return (row < Rows) || (column < Columns) || (row >= 0) || (column >= 0);
        }
    }
}
