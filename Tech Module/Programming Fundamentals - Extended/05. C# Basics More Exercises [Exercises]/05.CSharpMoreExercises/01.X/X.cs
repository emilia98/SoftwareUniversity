using System;

namespace _01.X
{
    class X
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            int leftInterval = -1;
            int rightInterval = -1;
            int middleInterval = n;

            for (int row = 1; row <= (n + 1)/2; row++) 
            {
                leftInterval++;
                rightInterval++;
               
                Console.Write(new string(' ',leftInterval));

                if (row == (n + 1) / 2)
                {
                    middleInterval--;
                }
                else
                {
                    middleInterval -= 2;
                    Console.Write("x");
                }

                Console.Write(new string(' ', middleInterval));
                Console.Write("x");
                Console.WriteLine(new string(' ', rightInterval));
            }

            for (int row = 1; row <= n / 2; row++)
            {
                leftInterval--;
                rightInterval--;

                Console.Write(new string(' ', leftInterval));
                Console.Write("x");
                if (row == 1)
                {
                    middleInterval++;
                }
                else
                {
                    middleInterval += 2;
                }

                Console.Write(new string(' ', middleInterval));
                Console.Write("x");
                Console.WriteLine(new string(' ', rightInterval));
            }

        }
    }
}
