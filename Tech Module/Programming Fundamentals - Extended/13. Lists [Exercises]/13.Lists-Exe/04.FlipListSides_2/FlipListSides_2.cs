using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FlipListSides_2
{
    class FlipListSides_2
    {
        static List<int> list = new List<int>();

        static void Main()
        {
            list = GetANewList(list);
            int elementsCount = list.Count;
            list = FlipTheListSides(list, elementsCount);
            Console.WriteLine(String.Join(" ", list));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> FlipTheListSides(List<int> list, int elementsCount)
        {
            int iterations = elementsCount % 2 == 0 ? iterations = elementsCount / 2 - 1 :
                                                     iterations = (int)(elementsCount / 2);
            for (int i = 1; i <= iterations; i++)
            {
                int temp = list[i];
                list[i] = list[elementsCount - 1 - i];
                list[elementsCount - 1 - i] = temp;
            }
            return list;
        }
    }
}
