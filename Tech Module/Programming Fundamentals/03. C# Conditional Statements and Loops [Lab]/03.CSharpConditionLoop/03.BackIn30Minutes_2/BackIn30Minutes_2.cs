using System;

namespace _03.BackIn30Minutes_2
{
    class BackIn30Minutes_2
    {
        static void Main()
        {
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());

            minutes += 30;
            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
                /*or
                minutes = minute % 60;
                */
            }

            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
