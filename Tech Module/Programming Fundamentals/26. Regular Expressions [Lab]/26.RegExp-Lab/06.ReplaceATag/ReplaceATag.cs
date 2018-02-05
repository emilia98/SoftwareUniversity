using System;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"< *a *[^>]*href *= *(?<content1>.*)>(?<content2>.*)< *\/ *a *>");

            while (input != "end")
            {
                Match match = pattern.Match(input);

                if (match.Success)
                {
                    var content1 = match.Groups["content1"].Value;
                    var content2 = match.Groups["content2"].Value;
                    string result = $"[URL href={content1}]{content2}[/URL]";
                    input = Regex.Replace(input, pattern.ToString(), result);
                }

                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
