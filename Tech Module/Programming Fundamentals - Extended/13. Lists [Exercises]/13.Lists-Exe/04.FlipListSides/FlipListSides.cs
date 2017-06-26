using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int elementsCount = list.Count;

            int iterations = elementsCount % 2 == 0 ? iterations = elementsCount / 2 -1 : 
                                                                   iterations = (int)(elementsCount / 2);
                                                            
            for (int i = 1; i <= iterations; i++)
            {               
                int temp = list[i];
                list[i] = list[elementsCount - 1 - i];
                list[elementsCount - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
