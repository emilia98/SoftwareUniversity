using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int x;
            int sumOdd = 0, sumEven = 0;

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += x;
                }
                else
                {
                    sumOdd += x;
                }
            }

            if(sumEven == sumOdd)
            {
                Console.WriteLine("Yes \nSum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No \nDiff = {0}",Math.Abs(sumOdd - sumEven));
            }

        }
    }
}
