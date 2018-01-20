using System;
using System.Collections.Generic;

namespace Matrix_From_List
{
    class Matrix_From_List
    {
        static void Main()
        {
            var matrix = new List<List<int>>();
            int rows = int.Parse(Console.ReadLine());

            // Responsible for the rows in out matrix
            for (int row = 0; row < rows; row++)
            {
                matrix.Add(new List<int>());
            }

            int counter = 10;
            int cols = rows;

            // Filling the cols int the matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row].Add(row + counter + col);
                }
            }
           
            // Printing the matrix
            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
