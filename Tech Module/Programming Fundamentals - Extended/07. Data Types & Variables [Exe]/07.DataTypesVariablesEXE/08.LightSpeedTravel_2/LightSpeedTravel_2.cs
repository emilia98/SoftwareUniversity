using System;

namespace _08.LightSpeedTravel_2
{
    class LightSpeedTravel_2
    {
        static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal totalKilometers = lightYears * 9450000000000m;
            decimal totalSeconds = totalKilometers / 300000m;

            decimal weeks = totalSeconds / (60 * 60 * 24 * 7);
            decimal days = (totalSeconds / (60 * 60 * 24)) % 7;
            decimal hours = (totalSeconds / (60 * 60)) % 24;
            decimal minutes = (totalSeconds / 60) % 60;
            decimal seconds = (totalSeconds) % 60;

            Console.WriteLine($"{(int)weeks} weeks");
            Console.WriteLine($"{(int)days} days");
            Console.WriteLine($"{(int)hours} hours");
            Console.WriteLine($"{(int)minutes} minutes");
            Console.WriteLine($"{(int)seconds} seconds");
        }
    }
}
