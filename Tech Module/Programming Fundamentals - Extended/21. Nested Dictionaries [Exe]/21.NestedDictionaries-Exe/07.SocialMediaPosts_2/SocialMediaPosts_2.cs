using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SocialMediaPosts_2
{
    class SocialMediaPosts_2
    {
        static void Main()
        {
            var postInfo = new Dictionary<string, List<int>>();
            var commentsInfo = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();
            int likesInPost = 0;
            int dislikesInPost = 0;
            while (input != "drop the media")
            {
                string[] splitInput = input.Split(' ').ToArray();
                string command = splitInput[0];
                string postName = splitInput[1];

                if (command == "post")
                {
                    postInfo.Add(postName, new List<int>());
                    postInfo[postName].Add(0);
                    postInfo[postName].Add(0);
                }
                else if (command == "like")
                {
                    likesInPost++;
                    postInfo[postName][0]++;
                }
                else if (command == "dislike")
                {
                    dislikesInPost++;
                    postInfo[postName][1]++;
                }
                else if (command == "comment")
                {
                    if (!commentsInfo.ContainsKey(postName))
                    {
                        commentsInfo.Add(postName, new Dictionary<string, string>());
                    }
                    string commentator = splitInput[2];
                    //here the count of intervals is 3
                    int textLength = command.Length + postName.Length + commentator.Length + 3;
                    string text = input.Substring(textLength);
                    commentsInfo[postName].Add(commentator, text);
                }
                input = Console.ReadLine();
            }

            foreach (var post in postInfo)
            {
                string postName = post.Key;
                List<int> likesAndDislikes = post.Value;
                int likes = likesAndDislikes[0];
                int dislikes = likesAndDislikes[1];

                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}", postName, likes, dislikes);

                bool hasComments = false;
                Console.WriteLine("Comments:");

                if (commentsInfo.ContainsKey(postName))
                {
                    hasComments = true;
                    
                    foreach (var comment in commentsInfo[postName])
                    {
                        string commentator = comment.Key;
                        string text = comment.Value;
                        Console.WriteLine("*  {0}: {1}", commentator, text);
                    }
                }
                if (!hasComments)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}

/* TRY:
Input:
post FirstPost
like FirstPost
like FirstPost
dislike FirstPost
post SecondPost
comment FirstPost Isacc This is very cool
comment SecondPost Isacc Lol
like SecondPost
drop the media
------------------------
Output:
Post: FirstPost | Likes: 2 | Dislikes: 1
Comments:
*  Isacc: This is very cool
Post: SecondPost | Likes: 1 | Dislikes: 0
Comments:
* Isacc: Lol

*/
