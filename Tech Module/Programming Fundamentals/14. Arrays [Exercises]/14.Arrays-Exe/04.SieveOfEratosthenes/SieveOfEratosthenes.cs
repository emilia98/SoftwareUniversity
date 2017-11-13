using System;
using System.Linq;

namespace _04.SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main()
        {
            //input:
            int n = int.Parse(Console.ReadLine());
            int[] primes = new int[n - 1];

            for (int index = 2; index <= n; index++)
            {
                primes[index - 2] = index;
            }

            int currentNumber = 2;

            while (currentNumber <= n)
            {
                for (int index = currentNumber - 1; index <= n - 2; index++)
                {
                    if (primes[index] % currentNumber == 0)
                    {
                        primes[index] = 0;
                    }
                }
                currentNumber++;
            }

            Console.WriteLine(String.Join(" ", primes.Where(el => el != 0)));

            //goto input;
        }
    }
}
