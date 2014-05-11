using System;
using System.Linq;

namespace DokumentowanieKodu
{
    /// <summary>
    /// Simple class to store data in MxN matrix.
    /// </summary>
    /// <example>
    /// This sample shows how to use the <see cref="Grid"/> class.
    /// <code>
    /// Grid grid = new Grid(2, 2);
    /// grid[0, 0] = 1;
    /// grid[0, 1] = 2;
    /// int[] row = grid[0]; // first row: 1, 2
    /// int cell = grid[0, 0];
    /// </code>
    /// </example>
    public class Grid
    {
        /// <summary>
        /// Two dimensional array to keep data.
        /// </summary>
        protected int[,] Data;

        /// <summary>
        /// Gets the total number of rows.
        /// </summary>
        public int Rows
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets the total number of columns.
        /// </summary>
        public int Columns
        {
            get;
            protected set;
        }

        /// <summary>
        /// Initializes a new isntance of the Grid class.
        /// </summary>
        /// <param name="rows">Number of rows.</param>
        /// <param name="columns">Number of columns.</param>
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

        /// <summary>
        /// Gets the row at the specified index.
        /// </summary>
        /// <param name="row">Row index.</param>
        /// <exception cref="System.IndexOutOfRangeException">Thrown when index is too large or too small.</exception>
        /// <returns>Array of integers.</returns>
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

        /// <summary>
        /// Gets or sets value at the specified index. 
        /// </summary>
        /// <param name="row">Row index.</param>
        /// <param name="column">Column index</param>
        /// <exception cref="System.IndexOutOfRangeException">Thrown when index is too large or too small.</exception>
        /// <returns>Integer.</returns>
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
