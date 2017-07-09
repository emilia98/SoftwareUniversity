using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            List<string> arrayToList = array.ToList();
            GetAResult(arrayToList, array);
        }

        static void GetAResult(List<string> arrayToList, string[] array)
        {
            List<string> strings = new List<string>();
            List<int> times = new List<int>();

            for (int index = 0; index < array.Length; index++)
            {
                string currentElement = array[index];
                int counter = 1;
                for (int index2 = index + 1; index2 < array.Length; index2++)
                {
                    if (currentElement == array[index2])
                    {
                        counter++;
                    }
                }

                if (!strings.Contains(currentElement))
                {
                    strings.Add(currentElement);
                    times.Add(counter);
                }
            }
            //Here we sort the elements by the times the occur in our array. The most the occur,
            // the front postion the get when we print them
            times = SortElementsByOccurrences(times, strings).Item1;
            strings = SortElementsByOccurrences(times, strings).Item2;

            //Here we print the result
            for (int pos = 0; pos < strings.Count; pos++)
            {
                decimal percent = 100.0m * times[pos] / (array.Length * 1.0m);
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", strings[pos], times[pos], percent);
            }
        }

        static Tuple<List<int>, List<string>> SortElementsByOccurrences(List<int> times, List<string> strings)
        {
            List<string> elementsYouNeed = new List<string>();

            while (true)
            {
                bool isSwapped = false;
                for (int index = 0; index < times.Count - 1; index++)
                {
                    if (times[index] < times[index + 1])
                    {
                        int tempInt = times[index];
                        times[index] = times[index + 1];
                        times[index + 1] = tempInt;

                        string tempStr = strings[index];
                        strings[index] = strings[index + 1];
                        strings[index + 1] = tempStr;

                        isSwapped = true;
                    }
                }
                if (isSwapped == false)
                {
                    break;
                }
            }
            return new Tuple<List<int>, List<string>>(times, strings);
        }
    }
}
