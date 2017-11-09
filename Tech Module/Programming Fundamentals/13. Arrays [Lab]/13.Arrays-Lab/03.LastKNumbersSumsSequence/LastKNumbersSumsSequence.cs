using System;
using System.Linq;

namespace _03.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int counter = 1; counter < n; counter++)
            {
                int startIndex = counter - k;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                long sum = sequence.Skip(startIndex).
                                    Take(k).
                                    Aggregate((a, b) => a + b);
                sequence[counter] = sum;
            }
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
