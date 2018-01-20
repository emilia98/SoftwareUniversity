using System;
using System.Linq;

namespace _01.SumMatrixElements_2
{
    class SumMatrixElements_2
    {
        static void Main()
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ', ',' },
                                             StringSplitOptions.RemoveEmptyEntries).
                                             Select(int.Parse).
                                             ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var numbersOnRow = Console.ReadLine().Split(new char[] { ' ', ',' },
                                                      StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToArray();

                matrix[row] = numbersOnRow;
            }

            long sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    sum += matrix[row][col];
                }
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
