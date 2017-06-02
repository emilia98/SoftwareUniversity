using System;

namespace _2.Cups
{
    class Cups
    {
        static void Main()
        {
            uint cupsCount = uint.Parse(Console.ReadLine());
            uint workersCount = uint.Parse(Console.ReadLine());
            uint daysCount = uint.Parse(Console.ReadLine());

            uint hoursWorked = 8 * workersCount * daysCount;
            uint cupsMade = (uint)Math.Floor(hoursWorked * 1.0 / 5);
            uint cupsDifference;
            double moneyEarned;
            double moneyLost;

            if (cupsMade >= cupsCount)
            {
                cupsDifference = cupsMade - cupsCount;
                moneyEarned = cupsDifference * 4.2;
                Console.WriteLine("{0:f2} extra money", moneyEarned);
            }
            else
            {
                cupsDifference = cupsCount - cupsMade;
                moneyLost = cupsDifference * 4.2;
                Console.WriteLine("Losses: {0:0.00}", moneyLost);
            }
        }
    }
}
