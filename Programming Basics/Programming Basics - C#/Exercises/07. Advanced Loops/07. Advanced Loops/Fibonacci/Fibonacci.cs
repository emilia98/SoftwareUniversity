using System;

namespace Fibonacci
{
    class Fibonacci
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
                int fibonacciSum = f1 + f0;
                //Descreses the value of N by 2, because we've already had the sum of first two members
                //of Fibonacci's sequence
                n = n - 2;
                while(n > 0)
                {                  
                    f0 = f1;
                    f1 = fibonacciSum;
                    fibonacciSum = (f0 + f1);
                    n--;
                }
                Console.WriteLine(fibonacciSum);
            }
            
        }
    }
}
