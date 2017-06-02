using System;

namespace Odd_EvenPosition
{
    class OddEvenPosition
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            double x;
            double oddSum = 0, evenSum = 0;
            double oddMax = - 1000000000.0, evenMax = - 1000000000.0;
            double oddMin = 1000000000.0, evenMin = 1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                x = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += x;

                    if (evenMax < x)
                    {
                        evenMax = x;
                    }
                    if (evenMin > x)
                    {
                        evenMin = x;
                    }
                }
                else
                {
                    oddSum += x;

                    if (oddMax < x)
                    {
                        oddMax = x;
                    }
                    if (oddMin > x)
                    {
                        oddMin = x;
                    }
                }
            }

            // for ODD numbers
            Console.WriteLine("OddSum={0},", oddSum);
            //---------------------------------------------------------------------------------------------------------------------
            if (oddMin == 1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin={0},", oddMin);
            }
            //---------------------------------------------------------------------------------------------------------------------
            if (oddMax == -1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMax={0},", oddMax);
            }
            //---------------------------------------------------------------------------------------------------------------------
            // for EVEN numbers
            Console.WriteLine("EvenSum={0},", evenSum);
            //---------------------------------------------------------------------------------------------------------------------
            if (evenMin == 1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin={0},", evenMin);
            }
            //---------------------------------------------------------------------------------------------------------------------
            if (evenMax == -1000000000.0)
            {
                Console.WriteLine("EvenMax=No,");
            }
            else
            {
                Console.WriteLine("EvenMax={0},", evenMax);
            }

            //OddSum = 1, OddMin = 1, OddMax = 1, EvenSum = 0, EvenMin = No, EvenMax = No

        }
    }
}
