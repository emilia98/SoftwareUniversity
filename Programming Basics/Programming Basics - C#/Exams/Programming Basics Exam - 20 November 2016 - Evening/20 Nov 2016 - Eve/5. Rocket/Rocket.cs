using System;

namespace _5.Rocket
{
    class Rocket
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int intervals;
            int dots;
            int stars;
            int backslashes;

            dots = (3 * n - 2) / 2;
            for (int row = 1; row <= n; row++)
            {
                intervals = 3 * n - (dots * 2 + 2);
                Console.Write(new string('.', dots));
                Console.Write("/");
                Console.Write(new string(' ', intervals));
                Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                dots--;
            }

            dots = n / 2;
            stars = 3 * n - 2 * dots;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));

            dots = n / 2;
            backslashes = 3 * n - (2 * dots + 2);
            for (int row = 1; row <= 2 * n; row++)
            {
                Console.Write(new string('.', dots));
                Console.Write("|");
                Console.Write(new string('\\', backslashes));
                Console.Write("|");
                Console.WriteLine(new string('.', dots));
            }

            for (int row = 1; row <= n / 2; row++)
            {
                stars = 3 * n - (2 * dots + 2);

                Console.Write(new string('.', dots));
                Console.Write("/");
                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                dots--;
            }
        }
    }
}
