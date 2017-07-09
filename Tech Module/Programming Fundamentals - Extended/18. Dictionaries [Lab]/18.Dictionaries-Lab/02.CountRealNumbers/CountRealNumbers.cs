using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main()
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> doublesCount = new SortedDictionary<double, int>();
            GetADictionary(input, doublesCount);
            PrintOccurencesOfRealNumbers(doublesCount);
        }

        static SortedDictionary<double,int> GetADictionary(List<double> input,
                                                     SortedDictionary<double,int> doublesCount)
        {
            for (int index = 0; index < input.Count; index++)
            {
                double currentNumber = input[index];

                if(doublesCount.ContainsKey(currentNumber) == false)
                {
                    doublesCount.Add(currentNumber, 1);
                }
                else
                {
                    doublesCount[currentNumber]++;
                }
            } 
            return doublesCount;
        }

        static void PrintOccurencesOfRealNumbers(SortedDictionary<double,int> doublesCount)
        {
           /* foreach(KeyValuePair<double, int> number in doublesCount)
            {
                Console.WriteLine("{0} --> {1}", number.Key, number.Value);
            }*/
            foreach (double key in doublesCount.Keys)
            {
                Console.WriteLine("{0} -> {1}",key, doublesCount[key]);
            }
        }
    }
}
