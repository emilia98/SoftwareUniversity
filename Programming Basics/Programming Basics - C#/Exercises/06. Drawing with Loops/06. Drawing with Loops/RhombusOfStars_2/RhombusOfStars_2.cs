using System;

namespace RhombusOfStars_2
{
    class RhombusOfStars_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int spaces = n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', spaces));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spaces--;
                Console.WriteLine();
            }
            spaces = 1;
            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', spaces));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spaces++;
                Console.WriteLine();
            }
        }
    }
}
