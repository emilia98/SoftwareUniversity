using System;

namespace _5.Fox
{
    class Fox
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int stars;
            int dashes;

            for (int row = 1; row <= n; row++)
            {
                stars = row;
                dashes = 2 * n + 3 - (2 * stars + 2);

                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.Write(new string('-', dashes));
                Console.Write("/");
                Console.WriteLine(new string('*', stars));
            }

            int middleRows = n / 3;
            stars = n / 2;
            int middleStars;

            for (int row = 1; row <= middleRows; row++)
            {
                middleStars = 2 * n + 3 - (2 * stars + 4);
                Console.Write("|");
                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.Write(new string('*', middleStars));
                Console.Write("/");
                Console.Write(new string('*', stars));
                Console.WriteLine("|");
                stars++;
            }

            for (int row = 1; row <= n; row++)
            {
                dashes = row;
                stars = 2 * n + 3 - (2 * dashes + 2);

                Console.Write(new string('-', dashes));
                Console.Write("\\");
                Console.Write(new string('*', stars));
                Console.Write("/");
                Console.WriteLine(new string('-', dashes));
            }
        }
    }
}
