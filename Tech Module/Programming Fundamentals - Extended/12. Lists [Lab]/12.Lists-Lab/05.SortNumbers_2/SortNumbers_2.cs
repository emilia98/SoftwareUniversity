using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers_2
{
    class SortNumbers_2
    {
        static List<decimal> numbers = GetNewList(numbers);

        static void Main()
        {
            SortList(numbers);
            string result = GetAResult(numbers);
            Console.WriteLine(result);
        }

        static List<decimal> GetNewList(List<decimal> numbers)
        {
            numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            return numbers;
        }

        static List<decimal> SortList(List<decimal> numbers)
        {
            numbers.Sort();
            return numbers;
        }

        static string GetAResult(List<decimal> numbers)
        {
            string result = String.Join(" => ", numbers);
            return result;
        }

    }
}
