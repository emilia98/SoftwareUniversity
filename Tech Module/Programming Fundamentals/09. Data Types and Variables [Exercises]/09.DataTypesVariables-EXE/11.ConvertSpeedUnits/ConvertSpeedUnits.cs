using System;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            uint meters = uint.Parse(Console.ReadLine());
            uint hours = uint.Parse(Console.ReadLine());
            uint minutes = uint.Parse(Console.ReadLine());
            uint seconds = uint.Parse(Console.ReadLine());


            //Firstly, we find all seconds, because we have to find the meters per second
            //Secondly, we find all hours.
            uint allSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
            float allHours = allSeconds / 3600.0f;
            
            float metersPerSecond = (meters * 1.0f) / allSeconds;
            //The following two lines of code are necessery, because if we find kilometers per hour without 
            //calculating meters per hour and then kilometers only, we'll lost precision and Judge won't
            //give points. It doesn't matter it's correct, but for Judge it's not.
            float metersPerHour = meters / allHours;
            float kilometers = meters / 1000.0f;

            float kilometersPerHour = kilometers / allHours;
            float milesPerHours = (kilometersPerHour / 1.609f);  // 1 mile = 1609 meters = 1.609 kilometers
 
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHours);
        }
    }
}
