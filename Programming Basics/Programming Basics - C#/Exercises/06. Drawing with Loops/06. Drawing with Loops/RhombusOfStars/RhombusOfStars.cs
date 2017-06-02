using System;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int intervals;
            int stars;

            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else
            {
                //This code is for the top part 
                for (int i = 1; i <= n; i++)
                {
                    intervals = n - i;
                    stars = i;

                    for (int j = 1; j <= intervals; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int m = 1; m <= stars; m++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }

                //This code is for the bottom part
                for (int i = n - 1; i >= 1; i--)
                {
                    intervals = n - i;
                    stars = i;
                    for (int j = 1; j <= intervals; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int m = 1; m <= stars; m++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
