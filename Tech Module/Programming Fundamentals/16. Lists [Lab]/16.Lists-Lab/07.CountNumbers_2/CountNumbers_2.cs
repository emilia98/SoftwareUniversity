using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers_2
{
    class CountNumbers_2
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sorted = SortAList(numbers);
            PrintOccurrences(sorted);
        }

        static List<int> SortAList(List<int> list)
        {
            var sortedList = new List<int>();
            sortedList.Add(list[0]);
            int max = list[0];
            int min = list[0];

            for (int index = 1; index < list.Count; index++)
            {
                int element = list[index];

                if (element >= max)
                {
                    sortedList.Add(element);
                    max = element;
                }
                else if (element < min)
                {
                    sortedList.Insert(0, element);
                    min = element;
                }
                else
                {
                    // Element is neither max, nor min 
                    for (int innerIndex = 1; innerIndex <= index - 1; innerIndex++)
                    {
                        if (element >= sortedList[innerIndex - 1] &&
                                        element <= sortedList[innerIndex])
                        {                         
                            sortedList.Insert(innerIndex, element);                            
                            break;
                        }
                        else if (element >= sortedList[innerIndex] &&
                                        element <= sortedList[innerIndex + 1])
                        {
                            sortedList.Insert(innerIndex + 1, element);                          
                            break;
                        }
                    }
                }
            }
            return sortedList;
        }

        static void PrintOccurrences(List<int> sortedList)
        {
            int counter = 1;
            int element = sortedList[0];

            for(int index = 0; index < sortedList.Count - 1 ; index++)
            {               
                if(index < sortedList.Count - 1)
                {
                    if (element == sortedList[index + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("{0} -> {1}", element, counter);
                        counter = 1;
                        element = sortedList[index + 1];
                    }
                }
                else
                {
                    if (element == sortedList[index + 1])
                    {
                        counter++;
                        break;
                    }
                }
               
            }
            Console.WriteLine("{0} -> {1}", element, counter);
        }
    }
}
