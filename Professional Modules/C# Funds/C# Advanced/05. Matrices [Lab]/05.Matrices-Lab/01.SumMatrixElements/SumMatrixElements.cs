using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class SumMatrixElements
    {
        static void Main()
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ', ',' },
                                              StringSplitOptions.RemoveEmptyEntries).
                                              Select(int.Parse).
                                              ToArray();          
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];
            long sum = 0;

            for (int row = 0; row < rows; row++)
            {
                var numbersOnRow = Console.ReadLine().Split(new char[] { ' ', ',' },
                                                      StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse)
                                                     .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbersOnRow[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);       
        }
    }
}
