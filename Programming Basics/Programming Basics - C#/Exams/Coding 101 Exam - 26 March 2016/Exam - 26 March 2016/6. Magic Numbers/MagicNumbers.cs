using System;

namespace _6.Magic_Numbers
{
    class MagicNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int c1 = 1; c1 <= 9; c1++)
            {
                if (n % c1 == 0)
                {
                    for (int c2 = 1; c2 <= 9; c2++)
                    {
                        if (n % c2 == 0)
                        {
                            for (int c3 = 1; c3 <= 9; c3++)
                            {
                                if (n % c3 == 0)
                                {
                                    for (int c4 = 1; c4 <= 9; c4++)
                                    {
                                        if (n % c4 == 0)
                                        {
                                            for (int c5 = 1; c5 <= 9; c5++)
                                            {
                                                if (n % c5 == 0)
                                                {
                                                    for (int c6 = 1; c6 <= 9; c6++)
                                                    {
                                                        if (n == c1 * c2 * c3 * c4 * c5 * c6)
                                                        {
                                                            Console.Write("{0}{1}{2}{3}{4}{5} ", c1, c2, c3, c4, c5, c6);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
