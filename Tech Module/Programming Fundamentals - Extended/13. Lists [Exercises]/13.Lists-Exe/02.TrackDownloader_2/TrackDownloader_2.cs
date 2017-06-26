using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TrackDownloader_2
{
    class TrackDownloader_2
    {
        static List<string> blacklist = new List<string>();

        static void Main()
        {
            blacklist = GetANewList(blacklist);
            List<string> tracklist = new List<string>();
            tracklist = AddToTrackList(tracklist);
            tracklist = RemoveBlacklistedTracks(blacklist, tracklist);

            tracklist.Sort();
            Console.WriteLine(String.Join("\n", tracklist));
        }

        static List<string> GetANewList(List<string> list)
        {
            list = Console.ReadLine().Split(' ').ToList();
            return list;
        }

        static List<string> AddToTrackList(List<string> tracklist)
        {
            string track = Console.ReadLine();

            while(track != "end")
            {
                tracklist.Add(track);
                track = Console.ReadLine();
            }
            return tracklist;
        }

        static List<string> RemoveBlacklistedTracks(List<string> blacklist, List<string> tracklist)
        {
            for (int i = 0; i < tracklist.Count; i++)
            {
                for (int j = 0; j < blacklist.Count; j++)
                {
                    if(tracklist[i].Contains(blacklist[j]))
                    {
                        tracklist.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
            return tracklist;
        }
    }
}
