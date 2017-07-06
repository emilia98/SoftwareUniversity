using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DistinctList_2
{
    class DistinctList_2
    {
        static List<int> numbers = new List<int>();

        static void Main()
        {
            numbers = GetANewList(numbers);
            numbers = RemoveAllRepeatableElements(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> RemoveAllRepeatableElements(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int currentNumber = list[i];

                for (int j = i + 1; j < list.Count; j++)
                {
                    if(currentNumber == list[j])
                    {
                        numbers.RemoveAt(j);
                        j--;
                    }
                }
            }
            return list;
        }
    }
}
