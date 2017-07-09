using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortArrayOfStrings_2
{
    class SortArrayOfStrings_2
    {
        static void Main()
        {
            List<string> strings = Console.ReadLine().Split(' ').ToList();
            DoInsertionSort(strings);
            Console.WriteLine(String.Join(" ", strings));
        }

        static List<string> DoInsertionSort(List<string> strings)
        {
            for (int firstIndex = 0; firstIndex < strings.Count; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    string first = strings[secondIndex - 1];
                    string second = strings[secondIndex];

                    if(first.CompareTo(second) == 1)
                    {
                        strings[secondIndex - 1] = Swap(first, second).Item1;
                        strings[secondIndex] = Swap(first, second).Item2;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return strings;
        }

        static Tuple<string, string> Swap(string first, string second)
        {
            string temp = first;
            first = second;
            second = temp;
            return new Tuple<string, string>(first, second);
        }
    }
}
