using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int l,r;
            int leftSum = 0, rightSum = 0;

            //We have our left sum
            for (int i = 1; i <= n; i++)
            {
                l = int.Parse(Console.ReadLine());
                leftSum += l;
            }

            // We have our right sum
            for(int i = 1; i <= n; i++)
            {
                r = int.Parse(Console.ReadLine());
                rightSum += r;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }

        }
    }
}
