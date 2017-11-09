using System;

namespace _03.LastKNumbersSumsSequence_2
{
    class LastKNumbersSumsSequence_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int counter = 1; counter < n; counter++)
            {
                int startIndex = counter - 1;
                int endIndex = counter - k;

                if (endIndex < 0)
                {
                    endIndex = 0;
                }

                long sum = 0;

                for (int index = startIndex; index >= endIndex; index--)
                {
                    sum += sequence[index];
                }
                sequence[counter] = sum;
            }
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
