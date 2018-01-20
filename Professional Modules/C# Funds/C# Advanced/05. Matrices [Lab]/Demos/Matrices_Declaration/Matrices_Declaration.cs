using System;

namespace Matrices_Declaration
{
    class Matrices_Declaration
    {
        static void Main()
        {
            // In this type of declaration, we should explicitly declare the
            // dimensions and sizes of our matrix
            int[,] matrix1 = new int[8, 8];

            // In this type of declaration, we should explicitly declare the
            // dimensions, but not the all sizes of the matrix. We could have only
            // size declared (for the rows)
            int[][] matrix2 = new int[5][];

            int counter = 10;
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    matrix1[row, col] = counter;
                    //matrix2[row][col] = counter;
                    counter++;
                }
            }

            counter = 10;
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                matrix2[row] = new int[5];
                for (int col = 0; col < matrix2[row].Length; col++)
                {
                    matrix2[row][col] = counter;
                    counter++;
                }
            }

            /*
             * This is how we can print both of two matrices.
             */

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix1[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(new string('*', 50));

            // We can print only the second matrix with foreach loop
            foreach (var row in matrix2)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            Console.WriteLine(new string('*', 50));

            // It's not forbidden to print like this, but we won't have the
            // result we have exprected
            foreach (var row in matrix1)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            Console.WriteLine(new string('*', 50));

            int[] array = new int[] { 1, 2, 3 };

            // This type of assigning to matrix one array is allowed only
            // with the second matrix 
            for (int row = 0; row < matrix2.Length; row++)
            {
                matrix2[row] = array;
            }

            /* IT'S FORBIDDEN
            for (int row = 0; row < matrix1.Length; row++)
            {
                matrix1[row] = array;
            }
            */
            
            foreach (var row in matrix2)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
