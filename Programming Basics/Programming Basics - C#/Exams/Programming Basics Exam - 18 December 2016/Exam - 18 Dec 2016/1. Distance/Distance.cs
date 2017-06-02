using System;

namespace _1.Distance
{
    class Distance
    {
        static void Main()
        {
            int speedAtBeginning = int.Parse(Console.ReadLine());
            int timeBeforeSpeedIncreasing = int.Parse(Console.ReadLine());
            int timeBeforeSpeedDecreasing = int.Parse(Console.ReadLine());
            int timeUntilTheEnd = int.Parse(Console.ReadLine());

            double speedAfterSpeedIncreasing = speedAtBeginning + 0.1 * speedAtBeginning;
            double speedUntilTheEnd = speedAfterSpeedIncreasing - 0.05 * speedAfterSpeedIncreasing;

            double distAtBeginning;
            double distAfterSpeedIncreasing;
            double distUntilTheEnd;
            double finalDistance;

            distAtBeginning = speedAtBeginning * (timeBeforeSpeedIncreasing * 1.0 / 60);
            distAfterSpeedIncreasing = speedAfterSpeedIncreasing * (timeBeforeSpeedDecreasing * 1.0 / 60);
            distUntilTheEnd = speedUntilTheEnd * (timeUntilTheEnd * 1.0 / 60);

            finalDistance = distAtBeginning + distAfterSpeedIncreasing + distUntilTheEnd;
            Console.WriteLine("{0:0.00}", finalDistance);
        }
    }
}
