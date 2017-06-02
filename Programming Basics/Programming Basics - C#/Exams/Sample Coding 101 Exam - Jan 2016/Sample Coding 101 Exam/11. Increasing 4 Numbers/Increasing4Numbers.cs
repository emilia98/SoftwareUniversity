using System;

namespace _11.Increasing_4_Numbers
{
    class Increasing4Numbers
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if ((second + 1 - first) < 4)
            {
                Console.WriteLine("No");
            }
            else if ((second + 1 - first) == 4)
            {
                Console.WriteLine("{0} {1} {2} {3}", first, first + 1, first + 2, second);
            }
            else
            {
                for (int c1 = first; c1 <= second; c1++)
                {
                    for (int c2 = c1 + 1; c2 <= second; c2++)
                    {
                        for (int c3 = c2 + 1; c3 <= second; c3++)
                        {
                            for (int c4 = c3 + 1; c4 <= second; c4++)
                            {
                                Console.WriteLine("{0} {1} {2} {3}", c1, c2, c3, c4);
                            }
                        }
                    }
                }
            }
        }
    }
}
