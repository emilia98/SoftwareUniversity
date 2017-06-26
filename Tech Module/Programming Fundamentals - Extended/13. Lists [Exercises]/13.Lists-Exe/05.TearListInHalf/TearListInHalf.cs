using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TearListInHalf
{
    class TearListInHalf
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i >= 0 && i < numbers.Count / 2)
                {
                    firstHalf.Add(numbers[i]);
                }
                else
                {
                    int currentNumber = numbers[i];
                    int firstDigit = currentNumber / 10;
                    int secondDigit = currentNumber % 10;
                    secondHalf.Add(firstDigit);
                    secondHalf.Add(secondDigit);
                }
            }
           
            List<int> result = new List<int>();
            for (int iteration = 0; iteration < numbers.Count/ 2; iteration++)
            {
                result.Add(secondHalf[2 * iteration]);
                result.Add(firstHalf[iteration]);
                result.Add(secondHalf[2 * iteration + 1]);                
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
