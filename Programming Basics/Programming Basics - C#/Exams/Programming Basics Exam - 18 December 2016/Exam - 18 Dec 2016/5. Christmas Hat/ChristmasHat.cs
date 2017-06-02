using System;

namespace _5.Christmas_Hat
{
    class ChristmasHat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int dots = 2 * n - 1;
            int dashes = 0;

            for (int row = 1; row <= 2; row++)
            {
                Console.Write(new string('.', dots));
                if (row == 1)
                {
                    Console.Write("/|\\");
                }
                else
                {
                    Console.Write("\\|/");
                }
                Console.WriteLine(new string('.', dots));
            }

            for (int row = 1; row <= 2 * n; row++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.Write(new string('-', dashes));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));

                dots--;
                dashes++;
            }

            Console.WriteLine(new string('*', 4 * n + 1));

            for (int col = 1; col <= 4 * n + 1; col++)
            {
                if (col % 2 == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();

            Console.WriteLine(new string('*', 4 * n + 1));
        }
    }
}
