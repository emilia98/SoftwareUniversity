using System;

namespace _01.SumArrayElements_2
{
    class SumArrayElements_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] array = new long[n];

            InitializeArray(array, n);
            long sum = SumElementsOfArray(array, n);
            Console.WriteLine(sum);
        }

        static void InitializeArray(long[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }
        }

        static long SumElementsOfArray(long[] array, int n)
        {
            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
