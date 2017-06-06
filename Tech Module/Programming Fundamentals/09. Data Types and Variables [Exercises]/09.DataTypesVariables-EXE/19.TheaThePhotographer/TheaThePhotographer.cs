using System;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main()
        {
            ulong photosNumber = ulong.Parse(Console.ReadLine());
            ulong timeToFilter = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong timeToUpload = ulong.Parse(Console.ReadLine());

            ulong totalTime = photosNumber * timeToFilter;
            ulong goodPictures = (ulong)Math.Ceiling((photosNumber * filterFactor) / 100.0);
            totalTime += goodPictures * timeToUpload;

            ulong days = 0;
            ulong hours = 0, minutes = 0, seconds = 0;
            days = (ulong)(totalTime / (24 * 60 * 60));
            totalTime -= (ulong)(days * 24 * 60 * 60);

            hours = (ulong)(totalTime / (60 * 60));
            totalTime -= (ulong)(hours * 60 * 60);

            minutes = (ulong)(totalTime / 60);
            totalTime -= (ulong)(minutes * 60);

            seconds = (ulong)totalTime;

            Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}", days, hours, minutes, seconds);

            /* Alternitive solution:
              uint photosNumber = uint.Parse(Console.ReadLine());
                uint timeToFilter = uint.Parse(Console.ReadLine());
                byte filterFactor = byte.Parse(Console.ReadLine());
                uint timeToUpload = uint.Parse(Console.ReadLine());

                ulong totalTime = photosNumber * timeToFilter;
                uint goodPictures = (uint)Math.Ceiling((photosNumber * filterFactor) / 100.0);
                totalTime += goodPictures * timeToUpload;

                ulong days = 0;
                uint hours = 0, minutes = 0, seconds = 0;
                days = (ulong)(totalTime / (24 * 60 * 60));
                totalTime -= (ulong)(days * 24 * 60 * 60);

                hours = (uint)(totalTime / (60 * 60));
                totalTime -= (ulong)(hours * 60 * 60);

                minutes = (uint)(totalTime / 60);
                totalTime -= (ulong)(minutes * 60);

                seconds = (uint)totalTime;

                Console.WriteLine("{0}:{1:d2}:{2:d2}:{3:d2}", days, hours, minutes, seconds);
             * */
        }
    }
}
