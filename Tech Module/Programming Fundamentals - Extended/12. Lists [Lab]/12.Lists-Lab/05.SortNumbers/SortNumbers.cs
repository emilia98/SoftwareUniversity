using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(String.Join(" => ", numbers));            
        }
    }
}
