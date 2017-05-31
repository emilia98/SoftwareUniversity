using System;

namespace _08.SumOfOddNumbers_2
{
    class SumOfOddNumbers_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
