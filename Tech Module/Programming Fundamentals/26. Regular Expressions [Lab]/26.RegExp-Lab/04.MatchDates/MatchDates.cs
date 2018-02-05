using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var pattern = @"\b((?<day>[0-9]{2})(?<sep>[\-\/\.]{1})(?<month>[A-Z][a-z]{2})\k<sep>(?<year>[0-9]{4}))\b";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", day, month, year);
            }
        }
    }
}
