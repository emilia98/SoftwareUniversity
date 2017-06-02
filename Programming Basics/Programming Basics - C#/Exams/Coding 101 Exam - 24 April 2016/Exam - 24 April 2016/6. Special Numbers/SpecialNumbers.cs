using System;

namespace _6.Special_Numbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int c1 = 1; c1 <= 9; c1++)
            {
                if (n % c1 == 0)
                {
                    //Warning: All of the zeros cannot be 0s -> DivideByZero Exception
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
                                            Console.Write("{0}{1}{2}{3} ", c1, c2, c3, c4);
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
