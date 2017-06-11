using System;

namespace _05.DistanceOfTheStars
{
    class DistanceOfTheStars
    {
        static void Main()
        {
            /*
            double fromEarthToNearestStar = 4.22;
            double toCenterOfMilkyWay = 26000;
            double diameterOfMilkyWay = 100000;
            double fromEarthToEdgeOfUniverse = 46500000000;*/

            decimal fromEarthToNearestStar = 4.22m;
            decimal toCenterOfMilkyWay = 26000m;
            decimal diameterOfMilkyWay = 100000m;
            decimal fromEarthToEdgeOfUniverse = 46500000000m;

            Console.WriteLine( (fromEarthToNearestStar * 9450000000000).ToString("e2"));
            Console.WriteLine( (toCenterOfMilkyWay * 9450000000000).ToString("e2"));
            Console.WriteLine( (diameterOfMilkyWay *9450000000000).ToString("e2"));
            Console.WriteLine( (fromEarthToEdgeOfUniverse *9450000000000).ToString("e2"));
        }
    }
}
