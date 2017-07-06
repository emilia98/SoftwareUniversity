using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.InsertionSortWithList
{
    class InsertionSortWithList
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sortedList = new List<int>();

            DoInsertionSortWithList(list, sortedList);
            Console.WriteLine(String.Join(" ", sortedList));
        }

        static List<int> DoInsertionSortWithList(List<int> list, List<int> sortedList)
        {
            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                int elementToInsert = list[firstIndex];
                bool hasInserted = false;

                //Console.WriteLine(String.Join(" ", sortedList));
                for (int secondIndex = 0; secondIndex < sortedList.Count; secondIndex++)
                {                    
                    int currentElement = sortedList[secondIndex];
                    //Console.WriteLine("Current element = " + currentElement);
                    if (elementToInsert < currentElement)
                    {
                        sortedList.Insert(secondIndex, elementToInsert);
                        hasInserted = true;
                        break;
                    }
                }
                if(hasInserted == false)
                {
                    sortedList.Add(elementToInsert);
                }
            }
            return sortedList;
        }
    }
}

/* Firstly, in the sorted list we have zero elements. We don't enter in the for loop with the second index.
   We enter in if statement, because we haven;t inserted the current element. So that we add the first element
   to the sorted list.
   After we have more than zero elements, the action of the algorithm is obvious.
*/
