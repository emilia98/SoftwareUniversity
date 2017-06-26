using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers_2
{
    class CountNumbers_2
    {
        static List<int> numbers = new List<int>();

        static void Main()
        {
            numbers = GetNewList(numbers);
            string result = CountNumbers(numbers);
            Console.WriteLine(result);
        }

        static List<int> GetNewList(List<int> numbers)
        {
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return numbers;
        }

        static List<int> SortList(List<int> numbers)
        {
            numbers.Sort();
            return numbers;
        }

        static string CountNumbers(List<int> numbers)
        {
            numbers = SortList(numbers);
            string result = String.Empty;
            int counter = 1;

            for (int index = 0; index < numbers.Count - 1; index++)
            {
                if(numbers[index] == numbers[index + 1])
                {
                    counter++;
                }
                else
                {
                    result += $"{numbers[index]} -> {counter}\n";
                    counter = 1;
                }
            }
            result += $"{numbers[numbers.Count - 1]} -> {counter}";
            return result;
        }
    }
}
