using System;

namespace _03.PrintingTriangle_2
{
    class PrintingTriangle_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }

            PrintLine(1, n);

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
