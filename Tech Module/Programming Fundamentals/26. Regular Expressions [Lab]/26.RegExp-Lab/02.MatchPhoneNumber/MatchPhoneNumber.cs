using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(?<= |^)(\+359(?<sep>(\-| ){1})2\k<sep>([0-9]{3})\k<sep>([0-9]{4}))\b");

            var matches = new List<string>();

            foreach (Match match in pattern.Matches(input))
            {
                matches.Add(match.ToString());
            }
            Console.WriteLine(String.Join(", ", matches));
        }
    }
}
