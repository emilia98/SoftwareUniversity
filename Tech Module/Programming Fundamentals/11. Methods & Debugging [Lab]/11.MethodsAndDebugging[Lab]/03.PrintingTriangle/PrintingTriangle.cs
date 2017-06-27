using System;

namespace _03.PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFirstPartOfTriangle(n);
            PrintSecondPartOfTriangle(n);
        }

        static void PrintFirstPartOfTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }

        static void PrintSecondPartOfTriangle(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
