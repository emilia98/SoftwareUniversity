using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main()
        {
            List<string> strings = Console.ReadLine().Split(' ').ToList();

            List<string> result = new List<string>();
            for (int i = 0; i < strings.Count; i++)
            {
                string currentString = strings[i];
                if ((i + 1) % 2 == 0)
                {
                    result.Add(currentString);
                }
            }
            Console.WriteLine(String.Join("", result));
        }
    }
}
