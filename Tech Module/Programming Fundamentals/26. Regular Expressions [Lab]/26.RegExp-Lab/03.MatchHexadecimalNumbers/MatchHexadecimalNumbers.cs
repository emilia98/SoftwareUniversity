using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"\b(?:0x)?([0-9A-F]+)\b");

            var hexNumbers = pattern.Matches(input)
                                    .Cast<Match>()
                                    .Select(el => el.Value)
                                    .ToList();

            Console.WriteLine(String.Join(" ", hexNumbers));          
        }
    }
}
