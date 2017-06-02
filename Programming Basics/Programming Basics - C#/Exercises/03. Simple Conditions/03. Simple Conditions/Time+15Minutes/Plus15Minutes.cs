using System;

namespace Time_15Minutes
{
    class Plus15Minutes
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;

            if (minutes >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 60;
            }

            if (hours >= 24)
            {
                hours = hours - 24;
            }
            Console.WriteLine("{0:0}:{1:00}",hours,minutes);

        }
    }
}
