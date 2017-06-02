using System;

namespace _09.Perfect_Diamond
{
    class PerfectDiamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int symbols;
            int intervals = n - 1;

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    Console.Write(new string(' ', intervals));
                    Console.Write("*");
                    Console.Write(new string(' ', intervals));
                }
                else
                {
                    Console.Write(new string(' ', intervals));
                    symbols = 2 * row - 1;

                    for (int i = 1; i <= symbols; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.Write(new string(' ', intervals));
                }
                Console.WriteLine();
                intervals--;
            }

            intervals = 1;

            for (int row = n - 1; row >= 1; row--)
            {
                if (row == 1)
                {
                    Console.Write(new string(' ', intervals));
                    Console.Write("*");
                    Console.Write(new string(' ', intervals));
                }
                else
                {
                    Console.Write(new string(' ', intervals));
                    symbols = 2 * row - 1;

                    for (int i = 1; i <= symbols; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                    }
                    Console.Write(new string(' ', intervals));
                }
                Console.WriteLine();
                intervals++;
            }
        }
    }
}
