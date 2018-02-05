using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            string names = Console.ReadLine();
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ {1}[A-Z][a-z]+\b");

            var matches = new List<string>();

            foreach (Match match in pattern.Matches(names))
            {
                matches.Add(match.ToString());
            }
            Console.WriteLine(String.Join(" ", matches));
        }
    }
}
