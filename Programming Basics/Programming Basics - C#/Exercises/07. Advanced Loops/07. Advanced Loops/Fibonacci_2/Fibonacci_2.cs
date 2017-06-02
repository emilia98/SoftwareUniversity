using System;

namespace Fibonacci_2
{
    class Fibonacci_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int f0 = 1, f1 = 1;
                int fibonacciSum;

                // Descreses the value of N by 2, because we've already had the sum of first two members
                // of Fibonacci's sequence. Starts from 0, because the furst member is on 0 position in 
                // Fibonacci's sequence.
                for (int i = 0; i <= n-2; i++)
                {
                    fibonacciSum = f0 + f1;
                    f0 = f1;
                    f1 = fibonacciSum;
                }
                Console.WriteLine(f1);
            }
        }
    }
}
