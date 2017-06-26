using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TearListInHalf_2
{
    class TearListInHalf_2
    {
        static List<int> numbers = new List<int>();
        static void Main()
        {
            numbers = GetANewList(numbers);
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            firstHalf = GetTheTwoHalves(numbers, firstHalf, secondHalf).Item1;
            secondHalf = GetTheTwoHalves(numbers, firstHalf, secondHalf).Item2;

            List<int> result = new List<int>();
            result = GetAResult(numbers, result, firstHalf, secondHalf);
            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static Tuple<List<int>, List<int>> GetTheTwoHalves(List<int> list, List<int> firstHalf,
                                                          List<int> secondHalf)

        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i >= 0 && i < list.Count / 2)
                {
                    firstHalf.Add(list[i]);
                }
                else
                {
                    int currentNumber = list[i];
                    int firstDigit = currentNumber / 10;
                    int secondDigit = currentNumber % 10;
                    secondHalf.Add(firstDigit);
                    secondHalf.Add(secondDigit);
                }
            }
            return new Tuple<List<int>, List<int>>(firstHalf, secondHalf);
        }

        static List<int> GetAResult(List<int> numbers, List<int> result,
                                    List<int> firstHalf, List<int> secondHalf)
        {
            for (int iteration = 0; iteration < numbers.Count / 2; iteration++)
            {
                result.Add(secondHalf[iteration * 2]);
                result.Add(firstHalf[iteration]);
                result.Add(secondHalf[iteration * 2 + 1]);
            }
            return result;
        }
    }
}
