using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int x;
            int sum = 0, max;

            x = int.Parse(Console.ReadLine());
            max = x;
            sum = x;

            for(int i = 2; i<=n; i++)
            {
                x = int.Parse(Console.ReadLine());
                sum += x;
                
                if (max < x)
                {
                    max = x;
                }
            }
            //Console.WriteLine(sum);
            //Console.WriteLine(max);

            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));
            }

        }
    }
}
