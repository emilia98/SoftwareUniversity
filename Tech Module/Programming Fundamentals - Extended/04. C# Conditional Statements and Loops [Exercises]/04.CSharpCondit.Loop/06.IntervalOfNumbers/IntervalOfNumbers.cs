using System;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main()
        {
            int interval1 = int.Parse(Console.ReadLine());
            int interval2 = int.Parse(Console.ReadLine());

            if(interval1 < interval2)
            {
                for (int i = interval1; i <= interval2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = interval2; i <= interval1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
