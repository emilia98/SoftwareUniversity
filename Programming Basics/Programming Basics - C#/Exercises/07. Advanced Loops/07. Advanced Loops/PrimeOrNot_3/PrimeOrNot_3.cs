using System;

namespace PrimeOrNot_3
{
    class PrimeOrNot_3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if(n < 2)
            {
                Console.WriteLine("Not prime");
                return;
            }
            else
            {
                bool isPrime = true;
                double nSqrt = Math.Sqrt(n);

                /* Algorithm:
                    36
                       -> 2 * 18
                          3 * 12
                          4 * 9
                          6 * 6  
                          ------ -> out breaking line, after which we have 
                          9 * 4 
                          12 * 3
                          18 * 2

                 * -> In the conditional statement of the for-loop, we should have an "=" sign, because:
                         If we have 121:
                            121 : 1,11,121
                            So Math.Sqrt(121) = 11, and if there isn't "=", we won't catch is as a composite number
                */
                for (int divider = 2; divider <= nSqrt; divider++)
                {
                    if (n % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == false || n < 2)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
           
        }
    }
}
