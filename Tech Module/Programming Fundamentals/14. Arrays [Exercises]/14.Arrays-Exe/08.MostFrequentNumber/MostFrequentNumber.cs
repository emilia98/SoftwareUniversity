using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').ToArray();

            var numbers = new string[array.Length];
            var countTimes = new int[array.Length];

            int cnt = 0;
            
            for (int index = 0; index < array.Length; index++)
            {
                int indexOfCurrent = Array.IndexOf(numbers, array[index]);

                if (indexOfCurrent == -1)
                {
                    numbers[cnt] = array[index];
                    countTimes[cnt] = 1;
                    cnt++;
                }
                else
                {
                    countTimes[indexOfCurrent] += 1;
                }
            }
           
            int timesOfMostFrequent = countTimes[0];
            int mostFrequentIndex = 0;

            for (int index = 1; index < countTimes.Count(); index++)
            {
                if (timesOfMostFrequent < countTimes[index])
                {
                    timesOfMostFrequent = countTimes[index];
                    mostFrequentIndex = index;
                }
            }

            Console.WriteLine(int.Parse(numbers[mostFrequentIndex]));
            //goto input;
        }
    }
}
