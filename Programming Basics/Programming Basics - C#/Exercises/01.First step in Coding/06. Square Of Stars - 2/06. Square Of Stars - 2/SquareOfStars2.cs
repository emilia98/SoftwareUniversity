using System;

namespace _06.Square_Of_Stars___2
{
    class SquareOfStars2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', n));

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', n - 2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
