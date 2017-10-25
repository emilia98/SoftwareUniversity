using System;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            int index = 0;
            while(index < numbers.Count() - 1)
            {
                if (numbers[index] == numbers[index + 1])
                {
                    numbers[index] += numbers[index + 1];
                    numbers.RemoveAt(index + 1);
                    index = -1;
                }
                index++;               
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
