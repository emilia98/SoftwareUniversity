using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    class SquareWithMaximumSum
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

            int[][] squareMatrix = new int[2][] { new int[2], new int[2] };

            int maxSum = 0;
            int leftHalfSum = matrix[0][0] + matrix[1][0];
            int rightHalfSum = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    rightHalfSum = matrix[row][col + 1] + matrix[row + 1][col + 1];

                    int sum = rightHalfSum + leftHalfSum;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        for (int r = 0; r < 2; r++)
                        {
                            for (int c = 0; c < 2; c++)
                            {
                                squareMatrix[r][c] = matrix[row + r][col + c];
                            }
                        }
                    }
                    leftHalfSum = rightHalfSum;
                }
            }

            foreach (var row in squareMatrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
            Console.WriteLine(maxSum);
        }
    }
}
