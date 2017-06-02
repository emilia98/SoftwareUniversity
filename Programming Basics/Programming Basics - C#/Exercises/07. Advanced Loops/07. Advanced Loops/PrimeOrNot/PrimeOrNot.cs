using System;

namespace PrimeOrNot
{
    class PrimeOrNot
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;


            for (int divider = 2; divider < n; divider++)
            {
                if (n % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && n > 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
