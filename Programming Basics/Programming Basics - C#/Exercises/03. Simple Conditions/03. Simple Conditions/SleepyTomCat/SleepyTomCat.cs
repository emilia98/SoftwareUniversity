using System;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main()
        {
            uint restDays = uint.Parse(Console.ReadLine());
            uint workDays = 365 - restDays;
            uint playTimePerYear;
            
            playTimePerYear = restDays * 127 + workDays * 63;

            if (playTimePerYear < 30000)
            {
                uint playTimeLeftMins;
                uint playTimeLeftHours;

                Console.WriteLine("Tom sleeps well");
                // All minutes left to play:
                playTimeLeftMins = 30000 - playTimePerYear;
                // Hours left to play, for output
                playTimeLeftHours = playTimeLeftMins / 60;
                // Minutes left to play, for output
                playTimeLeftMins = playTimeLeftMins - (playTimeLeftHours * 60);

                Console.WriteLine("{0} hours and {1} minutes less for play",playTimeLeftHours,playTimeLeftMins);
            }
            else
            {
                uint playTimeMoreMins;
                uint playTimeMoreHours;

                Console.WriteLine("Tom will run away");
                // All minutes more to play:
                playTimeMoreMins =  playTimePerYear - 30000;
                // Hours left to play, for output
                playTimeMoreHours = playTimeMoreMins / 60;
                // Minutes left to play, for output
                playTimeMoreMins = playTimeMoreMins - (playTimeMoreHours * 60);

                Console.WriteLine("{0} hours and {1} minutes more for play", playTimeMoreHours, playTimeMoreMins) ;
            }
        }
    }
}
