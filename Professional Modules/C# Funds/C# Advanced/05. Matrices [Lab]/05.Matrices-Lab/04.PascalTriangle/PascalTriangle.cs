using System;

namespace _04.PascalTriangle
{
    class PascalTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[][] matrix = new long[n][];
            int rows = n;
            int colsToFill = 0;

            for (int row = 1; row <= rows; row++)
            {
                int rowIndex = row - 1;
                matrix[rowIndex] = new long[row];
                matrix[rowIndex][0] = 1;
                matrix[rowIndex][rowIndex] = 1;

                colsToFill = row - 2;
                for (int col = 1; col <= colsToFill; col++)
                {
                    matrix[rowIndex][col] = matrix[rowIndex - 1][col - 1] + 
                                            matrix[rowIndex - 1][col];
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
