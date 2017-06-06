using System;

namespace _01.TimeSinceBirthday
{
    class TimeSinceBirthday
    {
        static void Main()
        {
            Console.Write("Years -  ");
            uint years = uint.Parse(Console.ReadLine());
            uint days = years * 365;
            uint hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine("{0} years = {1} days = {2} hours = {3} minutes",
                                years, days, hours, minutes);
        }
    }
}
