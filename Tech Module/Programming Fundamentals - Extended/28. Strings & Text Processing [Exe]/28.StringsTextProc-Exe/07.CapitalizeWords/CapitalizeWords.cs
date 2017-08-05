using System;
using System.Collections.Generic;

namespace _07.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitInput = input.Split(new[] { '.', ',', ' ', '-', '!', '?', ':', ';',
                                                            '(', ')', '/'},
                                                  StringSplitOptions.RemoveEmptyEntries);
                PrintTheWords(splitInput);
                input = Console.ReadLine();
            }
        }

        static void PrintTheWords(string[] splitInput)
        {
            var words = new List<string>();
            foreach (var word in splitInput)
            {
                var firstLetter = word.Substring(0, 1).ToUpper();
                var otherLetters = word.Substring(1).ToLower();               
                words.Add(firstLetter + otherLetters);
            }
            Console.WriteLine(String.Join(", ", words));
        }
    }
}
