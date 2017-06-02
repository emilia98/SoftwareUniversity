using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int x;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                sum += x;
            }
            Console.WriteLine(sum);
        }
    }
}
