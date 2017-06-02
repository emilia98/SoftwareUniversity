using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write(new string('*', 2 * n));
                    Console.Write(new string(' ', n));
                    Console.Write(new string('*', 2 * n));
                }
                else
                {
                    //For the first part of the sunglasses -> for the 1st lens
                    for (int j = 1; j <= 2 * n; j++)
                    {

                        if (j == 1 || j == 2 * n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }

                    //For the middle part of the sunglasses -> for the nose-frame of the sunglasses
                    if (n % 2 == 0 && i == n / 2)
                    {
                        Console.Write(new string('|', n));
                    }
                    else if (n % 2 == 1 && i == (n / 2) + 1)
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }

                    //For the second part of the sunglasses -> for the 2nd lens
                    for (int m = 1; m <= 2 * n; m++)
                    {
                        if (m == 1 || m == 2 * n)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write("/");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
