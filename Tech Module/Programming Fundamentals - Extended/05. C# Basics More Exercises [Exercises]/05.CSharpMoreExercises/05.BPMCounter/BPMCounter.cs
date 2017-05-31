using System;

namespace _05.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            int beatsPerMinute = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());

            double bars = (numberOfBeats * 1.0) / 4;
            double beatsPerSecond = (beatsPerMinute * 1.0) / 60;
            int minutes = 0, seconds = 0;

            seconds = (int)(numberOfBeats / beatsPerSecond);
           
            if (seconds > 60)
            {
                minutes = seconds / 60;
                seconds -= minutes * 60;
            }
            Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {seconds}s");
        }
    }
}
