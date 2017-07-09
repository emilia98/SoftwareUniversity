using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main()
        {
            List<string> strings = Console.ReadLine().Split(' ').ToList();
            DoBubbleSort(strings);
            Console.WriteLine(String.Join(" ", strings));
        }

        static List<string> DoBubbleSort(List<string> strings)
        {
            bool isSorted = false;
            
            while (!isSorted)
            {
                bool isSwapped = false;

                for (int index = 0; index < strings.Count - 1; index++)
                {
                    string first = strings[index];
                    string second = strings[index + 1];
                    if (first.CompareTo(second) == 1)
                    {
                        strings[index] = Swap(first, second).Item1;
                        strings[index + 1] = Swap(first, second).Item2;

                        isSwapped = true;
                    }
                }
                if (isSwapped == false)
                {
                    break;
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
