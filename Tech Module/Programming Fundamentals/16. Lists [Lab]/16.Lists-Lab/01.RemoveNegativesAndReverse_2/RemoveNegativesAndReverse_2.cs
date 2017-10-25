using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse_2
{
    class RemoveNegativesAndReverse_2
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers = numbers.Where(n => n >= 0).ToList();
            numbers.Reverse();

            if(numbers.Count() == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
