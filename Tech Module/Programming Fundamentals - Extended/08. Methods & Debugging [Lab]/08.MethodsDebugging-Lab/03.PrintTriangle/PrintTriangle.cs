using System;

namespace _03.PrintTriangle
{
    class PrintTriangle
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTheTriangle(n);
        }

        static void PrintTheTriangle(int n)
        {
            PrintTop(n);
            PrintBottom(n);
        }

       static void PrintTop(int n)
       {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }   
        }

        static void PrintBottom(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }    
        }
    }
}
