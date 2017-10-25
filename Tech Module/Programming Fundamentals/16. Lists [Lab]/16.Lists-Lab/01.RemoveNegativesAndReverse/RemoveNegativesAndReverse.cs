using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var nonNegatives = new List<int>();

            foreach(int number in numbers)
            {
                if(number >= 0)
                {
                    nonNegatives.Add(number);
                }
            }
            nonNegatives.Reverse();

            if(nonNegatives.Count() == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            Console.WriteLine(String.Join(" ", nonNegatives));
        }
    }
}
