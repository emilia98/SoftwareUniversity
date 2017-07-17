using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ForumTopics_2
{
    class ForumTopics_2
    {
        static void Main()
        {
            var forumTopics = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();

            while (input != "filter")
            {
                string[] splitInput = input.Split(new string[] { " -> " },
                                                  StringSplitOptions.None).ToArray();
                string topic = splitInput[0];
                string[] tags = splitInput[1].Split(new string[] { ", " },
                                                    StringSplitOptions.None).ToArray();
                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics.Add(topic, new HashSet<string>());
                }
                for (int index = 0; index < tags.Length; index++)
                {
                    string currentTag = tags[index];
                    forumTopics[topic].Add(currentTag);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            foreach (var topic in forumTopics)
            {
                string topicTitle = topic.Key;
                HashSet<string> tags = topic.Value;

                bool areTheTagsFound = AreTheTagsFoundInTheTopic(tags, input);
                if (areTheTagsFound)
                {
                    Console.WriteLine("{0} | #{1}", topicTitle, String.Join(", #", tags));
                }
            }
        }

        static bool AreTheTagsFoundInTheTopic(HashSet<string> tags, string input)
        {
            string[] tagsToSearch = input.Split(new string[] { ", " },
                                                StringSplitOptions.None).ToArray();

            for (int index = 0; index < tagsToSearch.Length; index++)
            {
                string currentTag = tagsToSearch[index];
                if (!tags.Contains(currentTag))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
