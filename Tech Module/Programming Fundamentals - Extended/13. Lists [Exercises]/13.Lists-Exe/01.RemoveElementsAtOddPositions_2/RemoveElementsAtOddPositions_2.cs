using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveElementsAtOddPositions_2
{
    class RemoveElementsAtOddPositions_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> strings = new List<string>();
            strings = GetANewList(input);

            List<string> result = new List<string>();
            result = GetAResult(strings, result);

            Console.WriteLine(String.Join("", result));
       }

        static List<string> GetANewList(string input)
        {
            List<string> strings = input.Split(' ').ToList();
            return strings;
        }

        static List<string> GetAResult(List<string> strings, List<string> result)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                string currentString = strings[i];
                if((i + 1) % 2 == 0)
                {
                    result.Add(currentString);
                }
            }
            return result;
        }
    }
}
