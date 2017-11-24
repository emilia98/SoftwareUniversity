using System;
using System.Linq;

namespace _01.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue;
            int max = int.MinValue;
            long sum = 0;

            foreach (int number in array)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }

                sum += number;
            }

            double avg = sum * 1.0 / array.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
            //goto input;
        }
    }
}
