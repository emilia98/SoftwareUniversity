using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            string typeYear = Console.ReadLine().ToLower();
            uint p = uint.Parse(Console.ReadLine());
            uint h = uint.Parse(Console.ReadLine());

            uint weekendsInSofia = 48 - h;
            double gamesAtWeekendInSofia = (weekendsInSofia * 1.0 * 3) / 4;
            double gamesPlayedInHomeTown = h;
            double holidayGames = (p * 2.0) / 3;
            double allGames = 0;

            double allGamesDespiteYears = gamesAtWeekendInSofia + gamesPlayedInHomeTown + holidayGames;

            if(typeYear == "leap")
            {
                allGames = Math.Truncate(allGamesDespiteYears * 1.15);
            }
            else
            {
                allGames = Math.Truncate(allGamesDespiteYears);
            }
            Console.WriteLine(allGames);
        }
    }
}
