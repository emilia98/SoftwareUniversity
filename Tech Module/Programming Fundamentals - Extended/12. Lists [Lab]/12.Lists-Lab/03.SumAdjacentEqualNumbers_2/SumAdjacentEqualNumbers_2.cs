using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers_2
{
    class SumAdjacentEqualNumbers_2
    {
        static List<decimal> numbers = new List<decimal>();

        static void Main()
        {
            List<decimal> numbers = GetNewList();
            GetProcessedList(numbers);

            string result = String.Join(" ", GetProcessedList(numbers));
            Console.WriteLine(result);
        }

        static List<decimal> GetNewList()
        {
            numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            return numbers;
        }

        static List<decimal> GetProcessedList(List<decimal> numbers)
        {
            decimal sum = 0.0m;

            for (int cnt = 0; cnt < numbers.Count - 1; cnt++)
            {
                if(cnt >= 0)
                {
                    if(numbers[cnt] == numbers[cnt + 1])
                    {
                        sum = numbers[cnt] * 2;
                        numbers[cnt] = sum;
                        numbers.RemoveAt(cnt + 1);
                        cnt -= 2;
                    }
                }
            }
            return numbers;
        }
    }
}
