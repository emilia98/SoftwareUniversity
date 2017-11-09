using System;
using System.Linq;

namespace _04.TripleSum_2
{
    class TripleSum_2
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
                    for (int ind3 = 0; ind3 < last; ind3++)
                    {
                        int c = array[ind3];

                        if (a + b == c)
                        {
                            hasTripleSum = true;
                            Console.WriteLine($"{a} + {b} == {c}");
                            break;
                        }
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
