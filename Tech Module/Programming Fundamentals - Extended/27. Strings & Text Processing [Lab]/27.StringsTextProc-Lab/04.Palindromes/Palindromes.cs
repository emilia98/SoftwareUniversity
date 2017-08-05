using System;
using System.Collections.Generic;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            char[] delimiter = { '.', ',', '!', '?', ' ' };
            string[] words = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();
            foreach (var word in words)
            {
                int middle = (word.Length) / 2;
                string firstPart = word.Substring(0, word.Length - middle);
                string secondPart = word.Substring(middle);             
                secondPart = ReverseSecondPart(secondPart);
                
                if(string.Compare(firstPart, secondPart, false) == 0)
                {
                    palindromes.Add(word);
                }                
            }
            Console.WriteLine(String.Join(", ", palindromes));
        }

        static string ReverseSecondPart(string secondPart)
        {
            string reversedString = String.Empty;

            for (int index = secondPart.Length - 1; index >= 0; index--)
            {
                reversedString += secondPart[index];
            }
            return reversedString;
        }
    }
}
