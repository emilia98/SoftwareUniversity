using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main()
        {
            string  input = Console.ReadLine();
            Regex pattern = new Regex(@"(^|(?<=\s))([-]?[0-9]+([.]{1}[0-9]+){0,1})($|(?=\s))");

            var matches = new List<string>();

            foreach (Match match in pattern.Matches(input))
            {
                matches.Add(match.ToString());
            }
            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
