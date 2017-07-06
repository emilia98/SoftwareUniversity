using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LargestNElements
{
    class LargestNElements
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());
            List<int> resultList = new List<int>();
            DoBubbleSort(list);
            GetLargestNElements(list, n, resultList);
            Console.WriteLine(String.Join(" ", resultList));           
        }

        static List<int> DoBubbleSort(List<int> list)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                bool isSwapped = false;
                for (int index = 0; index < list.Count - 1; index++)
                {
                    if (list[index] < list[index + 1])
                    {
                        int temp = list[index];
                        list[index] = list[index + 1];
                        list[index + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (isSwapped == false)
                {
                    break;
                }
            }
            return list;

        }

        static List<int> GetLargestNElements(List<int> list, int n, List<int> resultList)
        {
            for (int i = 0; i < n; i++)
            {
                int currentElement = list[i];
                resultList.Add(currentElement);
            }
            return resultList;
        }
    
    }
}
