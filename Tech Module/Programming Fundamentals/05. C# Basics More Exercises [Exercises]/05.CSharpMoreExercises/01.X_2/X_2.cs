using System;

namespace _01.X_2
{
    class X_2
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            int leftInterval = 0;
            int rightInterval = 0;
            int middleInterval = n - 2;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string(' ', leftInterval));
                Console.Write("x");
                Console.Write(new string(' ', middleInterval));
                Console.Write("x");
                Console.WriteLine(new string(' ', rightInterval));

                leftInterval++;
                rightInterval++;
                middleInterval -= 2;
            }

            Console.Write(new string(' ', leftInterval));
            Console.Write("x");
            Console.WriteLine(new string(' ', rightInterval));

            middleInterval = 1;
            leftInterval--;
            rightInterval--;

            for (int row = 1; row <= n / 2; row++)
            {
                Console.Write(new string(' ', leftInterval));
                Console.Write("x");
                Console.Write(new string(' ', middleInterval));
                Console.Write("x");
                Console.WriteLine(new string(' ', rightInterval));

                middleInterval += 2;
                leftInterval--;
                rightInterval--;
            }
        }
    }
}
