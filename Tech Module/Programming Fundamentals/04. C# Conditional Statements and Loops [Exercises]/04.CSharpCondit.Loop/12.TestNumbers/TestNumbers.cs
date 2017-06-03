using System;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            short m = short.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int combinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (maxSum > currentSum)
                    {
                        currentSum += i * j * 3;
                        combinations++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("{0} combinations", combinations);

            if (currentSum < maxSum)
            {             
                Console.WriteLine("Sum: {0}", currentSum);
            }
            else
            {
                Console.WriteLine("Sum: {0} >= {1}", currentSum, maxSum);
            }
        }
    }
}
