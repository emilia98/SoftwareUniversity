using System;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i, j;

            for (i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}