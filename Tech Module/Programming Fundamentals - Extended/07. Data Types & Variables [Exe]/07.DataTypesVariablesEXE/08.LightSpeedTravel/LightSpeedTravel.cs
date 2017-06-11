using System;

namespace _08.LightSpeedTravel
{
    class LightSpeedTravel
    {
        static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal totalKilometers = lightYears * 9450000000000m;
            decimal totalSeconds = totalKilometers / 300000;

            //Here we find the weeks
            decimal weeks = (int)(totalSeconds / (60 * 60 * 24 * 7));
            totalSeconds -= weeks * 60 * 60 * 24 * 7; //here we find the seconds, which left after we've found the weeks

            //Here we find the days
            decimal days = (int)(totalSeconds / (60 * 60 * 24));
            totalSeconds -= days * 60 * 60 * 24;
            totalSeconds = Math.Abs(totalSeconds); //here I had a problem -> the number was negative 

            //Here we find the hours
            decimal hours = (int)(totalSeconds / (60 * 60));
            totalSeconds -= hours * 60 * 60;

            //Here we find the minutes
            decimal minutes = (int)(totalSeconds / 60);
            totalSeconds -= minutes * 60;

            //Here we find the seconds
            decimal seconds = (int)(totalSeconds);

            Console.WriteLine($"{weeks:f0} weeks");
            Console.WriteLine($"{days:f0} days");
            Console.WriteLine($"{hours:f0} hours");
            Console.WriteLine($"{minutes:f0} minutes");
            Console.WriteLine($"{seconds:f0} seconds");
        }
    }
}
