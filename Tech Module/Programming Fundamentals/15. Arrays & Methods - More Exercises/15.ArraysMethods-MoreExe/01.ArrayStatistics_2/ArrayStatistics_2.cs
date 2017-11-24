using System;
using System.Linq;

namespace _01.ArrayStatistics_2
{
    class ArrayStatistics_2
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(array);
            int min = array[0];
            int max = array[array.Length - 1];
            long sum = array.Aggregate((a, b) => a + b);   
            double avg = sum * 1.0 / array.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {avg}");
            //goto input;
        }
    }
}
