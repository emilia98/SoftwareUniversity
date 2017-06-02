using System;

namespace _06.Sum_3_Numbers
{
    class Sum3Numbers
    {
        static void Main()
        {
            uint x1 = uint.Parse(Console.ReadLine());
            uint x2 = uint.Parse(Console.ReadLine());
            uint x3 = uint.Parse(Console.ReadLine());

            if (x1 + x2 == x3)
            {
                if (x1 > x2)
                {
                    Console.WriteLine("{0} + {1} = {2}", x2, x1, x3);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", x1, x2, x3);
                }
            }
            else if (x1 + x3 == x2)
            {
                if (x1 > x3)
                {
                    Console.WriteLine("{0} + {1} = {2}", x3, x1, x2);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", x1, x3, x2);
                }
            }
            else if (x2 + x3 == x1)
            {
                if (x2 > x3)
                {
                    Console.WriteLine("{0} + {1} = {2}", x3, x2, x1);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2}", x2, x3, x1);
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
