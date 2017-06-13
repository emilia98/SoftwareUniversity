using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }

        static void PrintEndRow(int n)
        {
            Console.WriteLine(new string('-',2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            for (int row = 1; row <= n - 2; row++)
            {
                for (int col = 1; col <= 3; col++)
                {
                    if (col == 1 || col == 3)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        for (int j = 1; j <= n - 1; j++)
                        {
                            Console.Write(@"\/");
                        }
                        col = 2;
                    }  
                }
                Console.WriteLine();
            }
        }

        static void PrintSquare(int n)
        {
            PrintEndRow(n);
            PrintMiddleRow(n);
            PrintEndRow(n);
        }
    }
}
