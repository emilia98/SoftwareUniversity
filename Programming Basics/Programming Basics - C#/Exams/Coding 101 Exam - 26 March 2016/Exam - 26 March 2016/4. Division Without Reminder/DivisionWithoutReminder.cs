using System;

namespace _4.Division_Without_Reminder
{
    class DivisionWithoutReminder
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint x;
            double p1, p2, p3;
            int counter_p1 = 0, counter_p2 = 0, counter_p3 = 0;

            for (int i = 1; i <= n; i++)
            {
                x = uint.Parse(Console.ReadLine());

                if (x % 2 == 0)
                {
                    counter_p1++;
                }
                if (x % 3 == 0)
                {
                    counter_p2++;
                }
                if (x % 4 == 0)
                {
                    counter_p3++;
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

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
