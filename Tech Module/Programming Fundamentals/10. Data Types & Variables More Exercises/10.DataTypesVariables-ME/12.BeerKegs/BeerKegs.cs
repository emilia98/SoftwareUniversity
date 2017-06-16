using System;

namespace _12.BeerKegs
{
    class BeerKegs
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            string kegModel = Console.ReadLine();
            float radius = float.Parse(Console.ReadLine());
            long height = long.Parse(Console.ReadLine());

            float currentVolume = (float)(Math.PI * radius * radius * height);
            string kegWithBiggestVolume = kegModel;
            float maxVolume = currentVolume;

            for (uint i = 1; i < n; i++)
            {
                kegModel = Console.ReadLine();
                radius = float.Parse(Console.ReadLine());
                height = long.Parse(Console.ReadLine());
                currentVolume = (float)(Math.PI * radius * radius * height);

                if (currentVolume >= maxVolume)
                {
                    maxVolume = currentVolume;
                    kegWithBiggestVolume = kegModel;
                }
            }
            Console.WriteLine(kegWithBiggestVolume);
        }
    }
}
