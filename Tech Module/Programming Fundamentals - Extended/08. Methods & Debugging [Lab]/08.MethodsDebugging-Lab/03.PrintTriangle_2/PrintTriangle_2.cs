using System;

namespace _03.PrintTriangle_2
{
    class PrintTriangle_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //First half of triangle -> without the row in the middle
            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }

            //Here is the middle row -> If we have i <= n in the first for loop, we don't need to print the 
            //middle row separetly
            PrintLine(1,n);

            //Second half of triangle -> without the row in the middle 
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
