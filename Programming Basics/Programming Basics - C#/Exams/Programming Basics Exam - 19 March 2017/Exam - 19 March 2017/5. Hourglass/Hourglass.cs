using System;

namespace _5.Hourglass
{
    class Hourglass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dots = 2;
            int stars;
            int atSigns = 2 * n + 1 - (2 * dots + 2);
            int intervals = 0;

            Console.WriteLine(new string('*', 2 * n + 1));
            Console.Write(".*");
            Console.Write(new string(' ', 2 * n - 3));
            Console.WriteLine("*.");

            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('@', atSigns));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));

                atSigns -= 2;
                dots++;
            }
            Console.Write(new string('.', dots));
            Console.Write("*");
            Console.WriteLine(new string('.', dots));

            dots -= 1;
            atSigns = 1;
            for (int row = 1; row <= n - 1; row++)
            {
                if (row == n - 1)
                {
                    dots = 1;
                    atSigns = 2 * n + 1 - (2 * dots + 2);
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.Write(new string('@', atSigns));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                }
                else
                {
                    Console.Write(new string('.', dots));
                    Console.Write("*");
                    Console.Write(new string(' ', intervals));
                    Console.Write(new string('@', atSigns));
                    Console.Write(new string(' ', intervals));
                    Console.Write("*");
                    Console.WriteLine(new string('.', dots));
                }

                intervals++;
                dots--;
            }
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
