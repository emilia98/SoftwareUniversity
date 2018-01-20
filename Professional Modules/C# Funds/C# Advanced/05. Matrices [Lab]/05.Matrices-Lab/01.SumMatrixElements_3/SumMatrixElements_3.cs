using System;
using System.Linq;

namespace _01.SumMatrixElements_3
{
    class SumMatrixElements_3
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

            foreach (var row in matrix)
            {
                sum += row.Aggregate((a, b) => a + b);
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
