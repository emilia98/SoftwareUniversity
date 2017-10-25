using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            var sortedNumbers = new List<decimal>();
            int index = 0;

            while (index < numbers.Count())
            {
                decimal min = decimal.MaxValue;
                int position = 0;
                for (int cnt = 0; cnt < numbers.Count(); cnt++)
                {
                    if (numbers[cnt] < min)
                    {
                        min = numbers[cnt];
                        position = cnt;
                    }

                }
                sortedNumbers.Add(min);
                numbers.RemoveAt(position);
            }
            Console.WriteLine(String.Join(" <= ", sortedNumbers));
        }
    }
}
