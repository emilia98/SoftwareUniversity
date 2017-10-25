using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers_3
{
    class CountNumbers_3
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var ocurrencesData = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if(!ocurrencesData.ContainsKey(number))
                {
                    ocurrencesData.Add(number, 0);
                }
                ocurrencesData[number]++;
            }

            foreach(var element in ocurrencesData.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", element.Key, element.Value);
            }
        }
    }
}
