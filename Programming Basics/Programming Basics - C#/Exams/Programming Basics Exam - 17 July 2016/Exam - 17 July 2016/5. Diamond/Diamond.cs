using System;

namespace _5.Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dotsCount;
            int betweenSymbolsDots;

            //First part of the diamond -> n rows -> Between the line, consist of only stars
            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    dotsCount = n;
                    int symbolCount = 5 * n - 2 * n;
                    Console.Write(new string('.', dotsCount));
                    Console.Write(new string('*', symbolCount));
                    Console.WriteLine(new string('.', dotsCount));
                }
                else
                {
                    dotsCount = n + 1 - row;
                    betweenSymbolsDots = 5 * n - 2 * (1 + dotsCount);
                    Console.Write(new string('.', dotsCount));
                    Console.Write("*");
                    Console.Write(new string('.', betweenSymbolsDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dotsCount));
                }
            }

            //The middle part of the diamond -> The single line, which has only stars 
            Console.WriteLine(new string('*', 5 * n));

            int secondPartRows = 3 * n + 2 - (n + 1);
            //The last part of the diamond -> (2 * n + 1) rows -> The lines after the middle part 
            for (int row = 1; row <= secondPartRows; row++)
            {
                dotsCount = row;
                betweenSymbolsDots = 5 * n - 2 * (1 + dotsCount);

                if (row == secondPartRows)
                {
                    Console.Write(new string('.', dotsCount));
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine(new string('.', dotsCount));
                }
                else
                {
                    Console.Write(new string('.', dotsCount));
                    Console.Write("*");
                    Console.Write(new string('.', betweenSymbolsDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dotsCount));
                }
            }
        }
    }
}
