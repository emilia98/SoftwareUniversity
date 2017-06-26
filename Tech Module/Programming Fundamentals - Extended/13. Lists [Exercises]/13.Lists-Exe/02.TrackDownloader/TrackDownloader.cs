using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrackDownloader
{
    class TrackDownloader
    {
        static void Main()
        {
            List<string> blacklist = Console.ReadLine().Split(' ').ToList();
            string track = Console.ReadLine();

            List<string> tracklist = new List<string>();
            while (track != "end")
            {
                tracklist.Add(track);
                track = Console.ReadLine();
            }

            for (int i = 0; i < tracklist.Count; i++)
            {
                for (int j = 0; j < blacklist.Count; j++)
                {
                    if (tracklist[i].Contains(blacklist[j]))
                    {                      
                        tracklist.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
            tracklist.Sort();
            Console.WriteLine(String.Join("\n", tracklist));
        }
    }
}
