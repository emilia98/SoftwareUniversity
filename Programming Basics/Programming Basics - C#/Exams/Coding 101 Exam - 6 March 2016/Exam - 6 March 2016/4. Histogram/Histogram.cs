using System;

namespace _4.Histogram
{
    class Histogram
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint x;
            double p1, p2, p3, p4, p5;
            int counter_p1 = 0, counter_p2 = 0, counter_p3 = 0, counter_p4 = 0, counter_p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                x = uint.Parse(Console.ReadLine());

                if (x < 200)
                {
                    counter_p1++;
                }
                else if (x >= 200 && x < 400)
                {
                    counter_p2++;
                }
                else if (x >= 400 && x < 600)
                {
                    counter_p3++;
                }
                else if (x >= 600 && x < 800)
                {
                    counter_p4++;
                }
                else
                {
                    counter_p5++;
                }
            }

            //p1
            if (counter_p1 == 0)
            {
                p1 = 0;
            }
            else
            {
                p1 = (counter_p1 * 1.0 / n) * 100;
            }

            //p2
            if (counter_p2 == 0)
            {
                p2 = 0;
            }
            else
            {
                p2 = (counter_p2 * 1.0 / n) * 100;
            }

            //p3
            if (counter_p3 == 0)
            {
                p3 = 0;
            }
            else
            {
                p3 = (counter_p3 * 1.0 / n) * 100;
            }

            //p4
            if (counter_p4 == 0)
            {
                p4 = 0;
            }
            else
            {
                p4 = (counter_p4 * 1.0 / n) * 100;
            }

            //p5
            if (counter_p5 == 0)
            {
                p5 = 0;
            }
            else
            {
                p5 = (counter_p5 * 1.0 / n) * 100;
            }

            Console.WriteLine("{0:0.00}%", p1);
            Console.WriteLine("{0:0.00}%", p2);
            Console.WriteLine("{0:0.00}%", p3);
            Console.WriteLine("{0:0.00}%", p4);
            Console.WriteLine("{0:0.00}%", p5);
        }
    }
}
