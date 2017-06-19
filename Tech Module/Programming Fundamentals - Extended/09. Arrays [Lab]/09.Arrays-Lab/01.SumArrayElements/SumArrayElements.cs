using System;

namespace _01.SumArrayElements
{
    class SumArrayElements
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            long[] array = new long[n];

            for (uint i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }

            long sum = 0;
            for (uint i = 0; i < n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}
