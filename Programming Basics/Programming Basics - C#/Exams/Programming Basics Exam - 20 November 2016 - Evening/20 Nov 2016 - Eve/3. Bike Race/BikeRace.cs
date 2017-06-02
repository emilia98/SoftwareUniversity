using System;

namespace _3.Bike_Race
{
    class BikeRace
    {
        static void Main()
        {
            uint juniors = uint.Parse(Console.ReadLine());
            uint seniors = uint.Parse(Console.ReadLine());
            string raceType = Console.ReadLine();

            const double juniorsTrail = 5.50;
            const double seniorsTrail = 7;
            const double juniorsCrossCountry = 8;
            const double seniorsCrossCountry = 9.50;
            const double juniorsDownhill = 12.25;
            const double seniorsDownhill = 13.75;
            const double juniorsRoad = 20;
            const double seniorsRoad = 21.50;

            double collectedSum = 0;
            double expenses;
            double finalSum;

            if (raceType == "trail")
            {
                collectedSum = juniors * juniorsTrail + seniors * seniorsTrail;
            }
            else if (raceType == "cross-country")
            {
                if (juniors + seniors >= 50)
                {
                    collectedSum = 0.75 * (juniors * juniorsCrossCountry + seniors * seniorsCrossCountry);
                }
                else
                {
                    collectedSum = (juniors * juniorsCrossCountry + seniors * seniorsCrossCountry);
                }
            }
            else if (raceType == "downhill")
            {
                collectedSum = juniors * juniorsDownhill + seniors * seniorsDownhill;
            }
            else
            {
                collectedSum = juniors * juniorsRoad + seniors * seniorsRoad;
            }

            expenses = collectedSum * 0.05;

            finalSum = collectedSum - expenses;

            Console.WriteLine("{0:0.00}", finalSum);
        }
    }
}
