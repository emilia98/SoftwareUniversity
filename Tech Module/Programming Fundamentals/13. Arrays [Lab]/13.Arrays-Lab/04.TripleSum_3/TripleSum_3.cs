using System;
using System.Linq;

namespace _04.TripleSum_3
{
    class TripleSum_3
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasTripleSum = false;
            int last = array.Length;

            for (int ind1 = 0; ind1 < last; ind1++)
            {
                int a = array[ind1];
                for (int ind2 = ind1 + 1; ind2 < last; ind2++)
                {
                    int b = array[ind2];
                    int sum = a + b;

                    if (array.Contains(sum))
                    {
                        hasTripleSum = true;
                        Console.WriteLine($"{a} + {b} == {sum}");
                    }
                }
            }

            if (!hasTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
