using System;

namespace _5.Axe
{
    class Axe
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dashes;
            int dashesBetweenStars = 0;
            int dashesAfterStars;

            //First part of the axe -> before the several the same rows
            for (int row = 1; row <= n; row++)
            {
                dashes = 3 * n;
                dashesBetweenStars = row - 1;
                dashesAfterStars = 2 * n - row - 1;
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.Write(new string('-', dashesBetweenStars));
                Console.Write("*");
                Console.WriteLine(new string('-', dashesAfterStars));
            }

            //The middle part of the axe -> prints same fex rows
            int middleRows = n / 2;
            int stars = 3 * n + 1;
            dashes = n - 1;

            for (int row = 1; row <= middleRows; row++)
            {
                Console.Write(new string('*', stars));
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.WriteLine(new string('-', dashes));
            }

            //The third and last end of the axe -> after the middle part of the axe
            int endRows = n / 2;
            dashesBetweenStars = n - 1;
            dashesAfterStars = dashesBetweenStars;
            dashes = 3 * n;

            for (int row = 1; row <= endRows; row++)
            {
                //The last row of the axe is quite different from the others
                if (row == endRows)
                {
                    dashes = 3 * n - (row - 1);
                    stars = dashesBetweenStars + 2;
                    dashesAfterStars = 5 * n - (dashes + stars);

                    Console.Write(new string('-', dashes));
                    Console.Write(new string('*', stars));
                    Console.WriteLine(new string('-', dashesAfterStars));
                }
                else
                {
                    Console.Write(new string('-', dashes));
                    Console.Write("*");
                    Console.Write(new string('-', dashesBetweenStars));
                    Console.Write("*");
                    Console.WriteLine(new string('-', dashesAfterStars));
                }
                dashesBetweenStars += 2;
                dashesAfterStars--;
                dashes--;
            }
        }
    }
}
