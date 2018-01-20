using System;
using System.Linq;

namespace _02.SquareWithMaximumSum_2
{
    class SquareWithMaximumSum_2
    {
        static void Main()
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ', ',' },
                                                 StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();
            int rows = sizes[0];
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var numbers = Console.ReadLine().Split(new char[] { ' ', ',' },
                                                 StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToArray();

                matrix[row] = numbers;
            }

            int maxSumRowIndex = 0;
            int maxSumColIndex = 0;
            int maxSum = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    int sum = matrix[row][col] + matrix[row][col + 1] +
                              matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSumRowIndex = row;
                        maxSumColIndex = col;
                    }
                }
            }

            for (int row = maxSumRowIndex; row < maxSumRowIndex + 2; row++)
            {
                for (int col = maxSumColIndex; col < maxSumColIndex + 2; col++)
                {
                    Console.Write("{0} ", matrix[row][col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
