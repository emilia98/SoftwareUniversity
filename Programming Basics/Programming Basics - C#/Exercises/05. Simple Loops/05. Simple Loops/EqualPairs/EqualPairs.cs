using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int a, b;
            int sum = 0, previousSum;
            bool areEqual = true;
            int maxDiff = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sum = a + b;
            for (int i = 2; i <= n; i++)
            {
                previousSum = sum;
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                sum = a + b;

                if (sum != previousSum && areEqual == true)
                {
                    areEqual = false;
                    maxDiff = Math.Abs(previousSum - sum);
                }
                else if(sum != previousSum && areEqual == false)
                {
                    if(maxDiff < Math.Abs(previousSum - sum))
                    {
                        maxDiff = Math.Abs(previousSum - sum);
                    }
                }
            }
            if (areEqual)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }
        }
    }
}
