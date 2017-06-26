using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> splitInput = input.Split(' ').ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < splitInput.Count; i++)
            {
                numbers.Add(int.Parse(splitInput[i]));
            }

            numbers.Sort();

            int count = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if(numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", numbers[i], count++);
                    count = 1;
                }
            }
            Console.WriteLine("{0} -> {1}", numbers[numbers.Count - 1], count++);
        }
    }
}
