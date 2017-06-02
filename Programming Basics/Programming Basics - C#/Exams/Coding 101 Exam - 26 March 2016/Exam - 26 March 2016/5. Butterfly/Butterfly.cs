using System;

namespace _5.Butterfly
{
    class Butterfly
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int stars = n - 2;
            int dashes = n - 2;

            for (int row = 1; row <= n - 2; row++)
            {
                if (row % 2 == 1)
                {
                    Console.Write(new string('*', stars));
                    Console.Write("\\ /");
                    Console.Write(new string('*', stars));
                }
                else
                {
                    Console.Write(new string('-', dashes));
                    Console.Write("\\ /");
                    Console.Write(new string('-', dashes));
                }
                Console.WriteLine();
            }

            Console.Write(new string(' ', n - 1));
            Console.WriteLine("@");


            for (int row = n; row <= 2 * (n - 2) + 1; row++)
            {
                if (row % 2 == 1)
                {
                    Console.Write(new string('*', stars));
                    Console.Write("/ \\");
                    Console.Write(new string('*', stars));
                }
                else
                {
                    Console.Write(new string('-', dashes));
                    Console.Write("/ \\");
                    Console.Write(new string('-', dashes));
                }
                Console.WriteLine();
            }
        }
    }
}
