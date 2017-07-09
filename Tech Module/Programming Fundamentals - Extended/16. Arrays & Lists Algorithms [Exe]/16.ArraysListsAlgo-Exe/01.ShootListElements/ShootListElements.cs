using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ShootListElements
{
    class ShootListElements
    {
        static void Main()
        {
            List<int> list = new List<int>();
            GiveCommands(list);
        }

        static void GiveCommands(List<int> list)
        {
            string command = Console.ReadLine();

            int sum = 0;
            decimal average = 0;
            int lastNumber = 0;
            int countElements = 0;

            while (command != "stop")
            {
                int number;
                bool isNumber = int.TryParse(command, out number);
                if (isNumber)
                {
                    list = InsertNumber(list, number, ref sum, ref countElements);
                    average = (sum * 1.0m / list.Count());
                    lastNumber = number;
                }
                else if (command == "bang")
                {
                    if (list.Count > 0)
                    {                      
                        list = RemoveElement(list, average, ref sum, ref countElements, ref lastNumber);
                        average = (sum * 1.0m / countElements);                   
                    }
                }

                command = Console.ReadLine();

                if (list.Count == 0)
                {
                    if (command == "bang")
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}", lastNumber);
                        return;
                    }
                    else if (command == "stop")
                    {
                        Console.WriteLine("you shot them all. last one was {0}", lastNumber);
                        return;
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("survivors: {0}", String.Join(" ", list));
        }

        static List<int> InsertNumber(List<int> list, int number, ref int sum, ref int countElements)
        {
            list.Insert(0, number);
            sum += number;
            countElements++;
            return list;
        }

        static List<int> RemoveElement(List<int> list, decimal average, ref int sum, ref int countElements,
                                        ref int lastNumber)
        {
            bool isFirstBelowAverage = true;
            for (int index = 0; index < list.Count; index++)
            {
                int currentElement = list[index];

                if (list.Count == 1)
                {
                    Console.WriteLine("shot {0}", currentElement);
                    list.RemoveAt(0);
                    lastNumber = currentElement;
                    return list;
                }
                else if (currentElement <= average && isFirstBelowAverage)
                {
                    Console.WriteLine("shot {0}", currentElement);
                    list.RemoveAt(index); //Remove the element from the list
                    isFirstBelowAverage = false; //here, we ensure that we won't remove the next smaller element
                    // from the list. We remove only the first one
                    index--; //decrease the current index because after we remove the first smaller element
                    // we skip the next element
                    sum -= currentElement; //decrease the sum
                    countElements--; //decrease the count of elements, because of removal
                }
                else
                {
                    //For all element, except the first smaller element than the average sum, we
                    //decrease them by one. We do the same with the sum - decrease it by one.
                    currentElement--;  
                    sum--;
                    list[index] = currentElement;
                }
            }
            return list;
        }
    }
}
