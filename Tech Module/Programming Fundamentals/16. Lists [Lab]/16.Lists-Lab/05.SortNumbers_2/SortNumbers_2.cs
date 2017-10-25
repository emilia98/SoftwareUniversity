using System;
using System.Linq;

namespace _05.SortNumbers_2
{
    class SortNumbers_2
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(String.Join(" <= ", numbers));
        }
    }
}
