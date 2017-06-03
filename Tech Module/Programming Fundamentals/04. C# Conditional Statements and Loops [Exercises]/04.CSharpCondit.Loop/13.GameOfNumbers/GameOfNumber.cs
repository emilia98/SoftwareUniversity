using System;

namespace _13.GameOfNumbers
{
    class GameOfNumber
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            short m = short.Parse(Console.ReadLine());
            short magicalNumber = short.Parse(Console.ReadLine());

            int combinations = 0;
            int lastI = 0, lastJ = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    //Console.WriteLine($"{i} {j}");
                    combinations++;

                    if(i + j == magicalNumber)
                    {
                        lastI = i;
                        lastJ = j;
                    }
                }
            }

            if(lastI == 0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicalNumber);
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastI, lastJ,magicalNumber);
            }

        }
    }
}
