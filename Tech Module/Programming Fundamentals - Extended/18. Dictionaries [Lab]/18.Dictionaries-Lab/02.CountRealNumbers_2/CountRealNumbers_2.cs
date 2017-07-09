using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CountRealNumbers_2
{
    class CountRealNumbers_2
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> doublesCount = new SortedDictionary<double, int>();
            GetANewDictionary(input, doublesCount);
            PrintNumbersAndOccurrences(doublesCount);
        }

        static SortedDictionary<double,int> GetANewDictionary(List<double> input, 
                                                              SortedDictionary<double, int> doublesCount)
        {
            for (int index = 0; index < input.Count; index++)
            {
                double currentNumber = input[index];

                if(!doublesCount.ContainsKey(currentNumber))
                {
                    doublesCount.Add(currentNumber, 0);
                }
                doublesCount[currentNumber]++;
            }
            return doublesCount;
        }

        static void PrintNumbersAndOccurrences(SortedDictionary<double,int> doublesCount)
        {
            foreach(KeyValuePair<double,int> number in doublesCount)
            {
                Console.WriteLine("{0} -> {1}", number.Key, number.Value);
            }
        }
    }
}
