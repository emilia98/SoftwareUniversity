using System;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            ushort waterTankCapacity = 255;
            ushort litersPoured = 0;

            for (uint i = 1; i <= n; i++)
            {
                ushort liters = ushort.Parse(Console.ReadLine());
                litersPoured += liters;

                if (waterTankCapacity < litersPoured)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersPoured -= liters;
                }
            }
            Console.WriteLine(litersPoured);
        }
    }
}
